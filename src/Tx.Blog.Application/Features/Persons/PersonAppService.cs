using Microsoft.AspNetCore.Authorization;
using Tx.Blog.Features.Persons.Dtos;
using Tx.Blog.Features.Persons.Events;
using Tx.Blog.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Local;

namespace Tx.Blog.Features.Persons;

[Authorize(BlogPermissions.Persons.Default)]
public class PersonAppService(
    IRepository<Person, Guid> personRepository,
    ILocalEventBus eventBus
    // BlogPersonToPersonListItemResponseMapper blogPersonToPersonListItemResponseMapper,
    // BlogPersonToPersonDetailResponseMapper blogPersonToPersonDetailResponseMapper,
    // BlogPersonCreateRequestToPersonMapper blogPersonCreateRequestToPersonMapper,
    // BlogPersonUpdateRequestToPersonMapper blogPersonUpdateRequestToPersonMapper
) : TxBlogAppService, IPersonAppService
{

    private static readonly Dictionary<string, string> SortAliasMap =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "name", nameof(Person.Name) },
            { "country", nameof(Person.Country) },
            { "isActive", nameof(Person.IsActive) },
            { "creationTime", nameof(Person.CreationTime) }
        };

    public virtual async Task<PersonDetailResponse> GetAsync(Guid id)
    {
        var query = await personRepository.WithDetailsAsync(x => x.Artists);
        var person = await AsyncExecuter.FirstOrDefaultAsync(
            query.Where(x => x.Id == id));

        if (person is null)
        {
            throw new EntityNotFoundException(typeof(Person), id);
        }

        return ObjectMapper.Map<Person, PersonDetailResponse>(person);
    }

    public virtual async Task<PagedResultDto<PersonListItemResponse>> GetListAsync(PersonGetListRequest input)
    {
        var query = await personRepository.GetQueryableAsync();

        if (!string.IsNullOrWhiteSpace(input.NameFilter))
            query = query.Where(x => x.Name.Contains(input.NameFilter));

        if (!string.IsNullOrWhiteSpace(input.Country))
            query = query.Where(x => x.Country == input.Country.ToUpperInvariant());

        if (input.IsActive.HasValue)
            query = query.Where(x => x.IsActive == input.IsActive.Value);

        var totalCount = await AsyncExecuter.CountAsync(query);

        var sorted = SortingHelper.ApplySorting(
            query, input.Sorting, SortAliasMap, "name ASC, id ASC");

        var items = await AsyncExecuter.ToListAsync(
            sorted.Skip(input.SkipCount).Take(input.MaxResultCount));

        return new PagedResultDto<PersonListItemResponse>(
            totalCount,
            items.Select(ObjectMapper.Map<Person, PersonListItemResponse>).ToList());
    }

    [Authorize(BlogPermissions.Persons.Create)]
    public virtual async Task<PersonDetailResponse> CreateAsync(PersonCreateRequest input)
    {
        var person = ObjectMapper.Map<PersonCreateRequest, Person>(input);
        person.Country = CountryCodeValidateHelper.ToDatabaseCountryCode(input.Country);
        await personRepository.InsertAsync(person);
        return ObjectMapper.Map<Person, PersonDetailResponse>(person);
    }

    [Authorize(BlogPermissions.Persons.Edit)]
    public virtual async Task<PersonDetailResponse> UpdateAsync(Guid id, PersonUpdateRequest input)
    {
        var person = await personRepository.GetAsync(id);
        if (person is null)
        {
            throw new EntityNotFoundException(typeof(Person), id);
        }
        ObjectMapper.Map<PersonUpdateRequest, Person>(input, person);
        person.Country = CountryCodeValidateHelper.ToDatabaseCountryCode(input.Country);
        await personRepository.UpdateAsync(person);
        return ObjectMapper.Map<Person, PersonDetailResponse>(person);
    }

    [Authorize(BlogPermissions.Persons.Delete)]
    public virtual async Task DeleteAsync(Guid id)
    {
        var person = await personRepository.GetAsync(id);
        await personRepository.DeleteAsync(id);
        await eventBus.PublishAsync(new PersonDeletedEvent(person));
    }
}