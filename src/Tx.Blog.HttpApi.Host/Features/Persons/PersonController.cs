using Microsoft.AspNetCore.Mvc;
using Tx.Blog.Features.Persons.Dtos;
using Tx.Blog.Permissions;
using Volo.Abp.Application.Dtos;

namespace Tx.Blog.Features.Persons;

[Area("blog")]                          // ABP 内部分组
[RemoteService(Name = "person")]          // 远程服务逻辑名，proxy 用
[Route("api/persons")]
public class PersonController(
    IPersonAppService personAppService
) : TxBlogControllerBase
{

    [HttpGet("{id}")]
    [Authorize(BlogPermissions.Persons.Default)]
    public Task<PersonDetailResponse> GetAsync(Guid id)
        => personAppService.GetAsync(id);

    [HttpGet]
    [Authorize(BlogPermissions.Persons.Default)]
    public Task<PagedResultDto<PersonListItemResponse>> GetListAsync([FromQuery] PersonGetListRequest input)
        => personAppService.GetListAsync(input);

    [HttpPost]
    [Authorize(BlogPermissions.Persons.Create)]
    public Task<PersonDetailResponse> CreateAsync([FromBody] PersonCreateRequest input)
        => personAppService.CreateAsync(input);

    [HttpPut("{id}")]
    [Authorize(BlogPermissions.Persons.Edit)]
    public Task<PersonDetailResponse> UpdateAsync(Guid id, [FromBody] PersonUpdateRequest input)
        => personAppService.UpdateAsync(id, input);

    [HttpDelete("{id}")]
    [Authorize(BlogPermissions.Persons.Delete)]
    public Task DeleteAsync(Guid id)
        => personAppService.DeleteAsync(id);
}