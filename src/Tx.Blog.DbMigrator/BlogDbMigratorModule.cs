using Tx.Blog.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Tx.Blog.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BlogEntityFrameworkCoreModule),
    typeof(BlogApplicationContractsModule)
)]
public class BlogDbMigratorModule : AbpModule
{
}
