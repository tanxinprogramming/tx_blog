using Riok.Mapperly.Abstractions;
using Tx.Blog.Features.Persons.Dtos;
using Volo.Abp.Mapperly;

namespace Tx.Blog.Features.Persons.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class BlogPersonToPersonListItemResponseMapper : MapperBase<Person, PersonListItemResponse>
{
    public override partial PersonListItemResponse Map(Person source);

    public override partial void Map(Person source, PersonListItemResponse destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class BlogPersonToPersonDetailResponseMapper : MapperBase<Person, PersonDetailResponse>
{
    public override partial PersonDetailResponse Map(Person source);

    public override partial void Map(Person source, PersonDetailResponse destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Source)]
public partial class BlogPersonCreateRequestToPersonMapper : MapperBase<PersonCreateRequest, Person>
{
    [MapperIgnoreTarget(nameof(Person.Id))]
    [MapperIgnoreTarget(nameof(Person.Artists))]
    public override partial Person Map(PersonCreateRequest source);

    [MapperIgnoreTarget(nameof(Person.Id))]
    [MapperIgnoreTarget(nameof(Person.Artists))]
    public override partial void Map(PersonCreateRequest source, Person destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Source)]
public partial class BlogPersonUpdateRequestToPersonMapper : MapperBase<PersonUpdateRequest, Person>
{
    [MapperIgnoreTarget(nameof(Person.Id))]
    [MapperIgnoreTarget(nameof(Person.Artists))]
    public override partial Person Map(PersonUpdateRequest source);

    [MapperIgnoreTarget(nameof(Person.Id))]
    [MapperIgnoreTarget(nameof(Person.Artists))]
    public override partial void Map(PersonUpdateRequest source, Person destination);
}