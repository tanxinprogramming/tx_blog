using Tx.Blog.Features.Artists;
using Tx.Blog.Features.Persons.Events;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus;

namespace Tx.Blog.Features.Persons.EventHandlers;

/// <summary>
/// Person 删除事件处理器。
/// 在同一 UnitOfWork 内级联软删该 Person 的所有 Artist。
/// 任何一步失败都会导致整个事务回滚（包括 Person 的软删），不会产生孤儿 Artist。
/// </summary>
public class PersonDeletedEventHandler(
    IRepository<Artist, Guid> artistRepository
) : ILocalEventHandler<PersonDeletedEvent>, ITransientDependency
{
    public async Task HandleEventAsync(PersonDeletedEvent eventData)
    {
        var artists = await artistRepository.GetListAsync(x => x.PersonId == eventData.Entity.Id);

        foreach (var artist in artists)
        {
            await artistRepository.DeleteAsync(artist);
        }
    }
}