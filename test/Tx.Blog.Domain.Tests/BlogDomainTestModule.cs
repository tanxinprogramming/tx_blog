using Volo.Abp.Modularity;

namespace Tx.Blog;

[DependsOn(
    typeof(BlogDomainModule),
    typeof(BlogTestBaseModule)
)]
public class BlogDomainTestModule : AbpModule
{

}
