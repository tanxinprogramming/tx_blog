using System;
using System.Collections.Frozen;
using System.Linq;

namespace Tx.Blog.Features.Commons.Helpers;

public static class CountryCodeValidateHelper
{
    private static readonly FrozenSet<string> ValidIsoCodes =
        ISO3166.Country.List.Select(x => x.TwoLetterCode).ToFrozenSet(StringComparer.OrdinalIgnoreCase);
    
    
    public static bool ValidateIsoCountryCode(string? countryCode)
        => string.IsNullOrWhiteSpace(countryCode) || ValidIsoCodes.Contains(countryCode);

    public static string? ToDatabaseCountryCode(string? countryCode)
    {
        if (!ValidateIsoCountryCode(countryCode))
        {
            return null;
        }
        
        // 上面已经将不合法的字符串和空值排除了
        return countryCode!.ToUpperInvariant();
    }
}