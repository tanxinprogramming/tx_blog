using Xunit;

namespace Tx.Blog.EntityFrameworkCore;

[CollectionDefinition(BlogTestConsts.CollectionDefinitionName)]
public class BlogEntityFrameworkCoreCollection : ICollectionFixture<BlogEntityFrameworkCoreFixture>
{

}
