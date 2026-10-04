using Microsoft.AspNetCore.Mvc;

namespace Tx.Blog.Features.Commons;

// [Area("blog")]                          // ABP 内部分组
[RemoteService]          // 远程服务逻辑名，proxy 用
[Route("api/countries")]                // 实际 URL 路径
[Authorize]
public class CountryController(
    ICountryAppService countryAppService
) : TxBlogControllerBase
{
    [HttpGet]
    public List<string> Get()
    {
        return countryAppService.GetCountries();
    }
}