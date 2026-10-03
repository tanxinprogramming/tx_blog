using Microsoft.Extensions.Localization;
using Tx.Blog.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Tx.Blog;

[Dependency(ReplaceServices = true)]
public class BlogBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BlogResource> _localizer;

    public BlogBrandingProvider(IStringLocalizer<BlogResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
