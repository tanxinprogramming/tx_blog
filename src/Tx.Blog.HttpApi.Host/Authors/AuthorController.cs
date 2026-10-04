using Microsoft.AspNetCore.Mvc;
using Tx.Blog.Permissions;
using Tx.Blog.Shared;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Content;

namespace Tx.Blog.Authors;

[RemoteService]          // 远程服务逻辑名，proxy 用
[Route("api/app/author")]                // 实际 URL 路径
[Authorize(BlogPermissions.Authors.Default)]
public class AuthorController(
    IAuthorAppService authorAppService
) : AbpControllerBase, IAuthorAppService
{
    [HttpGet("{id}")]
    public Task<AuthorDto> GetAsync(Guid id)
    {
        return authorAppService.GetAsync(id);
    }

    [HttpGet]
    public Task<PagedResultDto<AuthorDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return authorAppService.GetListAsync(input);
    }

    [HttpPost]
    [Authorize(BlogPermissions.Authors.Create)]
    public Task<AuthorDto> CreateAsync(CreateUpdateAuthorDto input)
    {
        return authorAppService.CreateAsync(input);
    }

    [HttpPut("{id}")]
    [Authorize(BlogPermissions.Authors.Edit)]
    public Task<AuthorDto> UpdateAsync(Guid id, CreateUpdateAuthorDto input)
    {
        return authorAppService.UpdateAsync(id, input);
    }

    [HttpDelete("{id}")]
    [Authorize(BlogPermissions.Authors.Delete)]
    public Task DeleteAsync(Guid id)
    {
        return authorAppService.DeleteAsync(id);
    }

    [AllowAnonymous]
    [HttpGet("as-excel-file")]
    public Task<IRemoteStreamContent> GetListAsExcelFileAsync(AuthorExcelDownloadDto input)
    {
        return authorAppService.GetListAsExcelFileAsync(input);
    }

    [HttpGet("download-token")]
    public Task<DownloadTokenResultDto> GetDownloadTokenAsync()
    {
        return authorAppService.GetDownloadTokenAsync();
    }
}