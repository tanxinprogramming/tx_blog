using Microsoft.AspNetCore.Mvc;
using Tx.Blog.Permissions;
using Tx.Blog.Shared;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Content;

namespace Tx.Blog.Books;

[RemoteService]          // 远程服务逻辑名，proxy 用
[Route("api/app/book")]                // 实际 URL 路径
[Authorize(BlogPermissions.Books.Default)]
public class BookController(
    IBookAppService bookAppService    
) : AbpControllerBase, IBookAppService
{
    [HttpGet("{id}")]
    public Task<BookDto> GetAsync(Guid id)
    {
        return bookAppService.GetAsync(id);
    }

    [HttpGet]
    public Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return bookAppService.GetListAsync(input);
    }

    [HttpPost]
    [Authorize(BlogPermissions.Books.Create)]
    public Task<BookDto> CreateAsync(CreateUpdateBookDto input)
    {
        return bookAppService.CreateAsync(input);
    }

    [HttpPut("{id}")]
    [Authorize(BlogPermissions.Books.Edit)]
    public Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
    {
        return bookAppService.UpdateAsync(id, input);
    }

    [HttpDelete("{id}")]
    [Authorize(BlogPermissions.Books.Delete)]
    public Task DeleteAsync(Guid id)
    {
        return bookAppService.DeleteAsync(id);
    }

    [AllowAnonymous]
    [HttpGet("as-excel-file")]
    public Task<IRemoteStreamContent> GetListAsExcelFileAsync(BookExcelDownloadDto input)
    {
        return bookAppService.GetListAsExcelFileAsync(input);
    }

    [HttpGet("download-token")]
    public Task<DownloadTokenResultDto> GetDownloadTokenAsync()
    {
        return bookAppService.GetDownloadTokenAsync();
    }
}