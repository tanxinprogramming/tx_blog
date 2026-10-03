using System.Threading.Tasks;

namespace Tx.Blog.Data;

public interface IBlogDbSchemaMigrator
{
    Task MigrateAsync();
}
