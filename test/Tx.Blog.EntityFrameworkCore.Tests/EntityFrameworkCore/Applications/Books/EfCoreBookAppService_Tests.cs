using Tx.Blog.Books;
using Xunit;

namespace Tx.Blog.EntityFrameworkCore.Applications.Books;

[Collection(BlogTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BlogEntityFrameworkCoreTestModule>
{

}