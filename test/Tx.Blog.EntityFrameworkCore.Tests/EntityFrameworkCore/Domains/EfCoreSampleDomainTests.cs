using Tx.Blog.Samples;
using Xunit;

namespace Tx.Blog.EntityFrameworkCore.Domains;

[Collection(BlogTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BlogEntityFrameworkCoreTestModule>
{

}
