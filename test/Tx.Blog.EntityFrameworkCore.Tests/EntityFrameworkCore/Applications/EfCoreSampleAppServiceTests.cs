using Tx.Blog.Samples;
using Xunit;

namespace Tx.Blog.EntityFrameworkCore.Applications;

[Collection(BlogTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BlogEntityFrameworkCoreTestModule>
{

}
