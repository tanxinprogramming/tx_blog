namespace Tx.Blog.Features.Commons;

public interface ICountryAppService : IApplicationService
{
    List<string> GetCountries();
}