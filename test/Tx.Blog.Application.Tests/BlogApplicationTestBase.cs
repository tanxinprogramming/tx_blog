using Volo.Abp.Modularity;

namespace Tx.Blog;

public abstract class BlogApplicationTestBase<TStartupModule> : BlogTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
