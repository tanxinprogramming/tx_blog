using Volo.Abp.Domain.Entities.Events;

namespace Tx.Blog.Features.Persons.Events;

public class PersonDeletedEvent(Person entity) : EntityDeletedEventData<Person>(entity);