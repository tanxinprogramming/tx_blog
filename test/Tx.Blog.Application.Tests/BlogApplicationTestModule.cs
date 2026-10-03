using Volo.Abp.Modularity;

namespace Tx.Blog;

[DependsOn(
    typeof(BlogApplicationModule),
    typeof(BlogDomainTestModule)
)]
public class BlogApplicationTestModule : AbpModule
{

}
