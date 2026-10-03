using System.Threading.Tasks;
using Tx.Blog.Features.Persons.Dtos;
using Volo.Abp.Application.Services;

namespace Tx.Blog.Features.Persons;

public interface IPersonAppService : IApplicationService
{
    Task<PersonDetailResponse> GetAsync(Guid id);
    Task<PagedResultDto<PersonListItemResponse>> GetListAsync(PersonGetListRequest input);
    Task<PersonDetailResponse> CreateAsync(PersonCreateRequest input);
    Task<PersonDetailResponse> UpdateAsync(Guid id, PersonUpdateRequest input);
    Task DeleteAsync(Guid id);
}