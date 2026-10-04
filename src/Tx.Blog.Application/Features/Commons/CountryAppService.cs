using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Localization;
using Tx.Blog.Localization;
using Volo.Abp.Localization;

namespace Tx.Blog.Features.Commons;

public class CountryAppService(
    IStringLocalizerFactory localizerFactory
) : TxBlogAppService, ICountryAppService
{
    public List<string> GetCountries()
    {
        var localizer = localizerFactory.Create<CountryResource>();

        // ABP 的字典本地化器能枚举所有键
        if (localizer is AbpDictionaryBasedStringLocalizer dictLocalizer)
        {
            return dictLocalizer
                .GetAllStrings(includeParentCultures: true)
                .Where(s => s.Name.StartsWith("ISO3166:"))
                .Select(s => s.Name.Substring("ISO3166:".Length))
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }

        return new List<string>();
    }
}