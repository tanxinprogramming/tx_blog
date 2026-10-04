using System.Globalization;
using FluentValidation;
using Tx.Blog.Features.Commons;
using Tx.Blog.Features.Commons.Helpers;
using Tx.Blog.Features.Persons.Dtos;

namespace Tx.Blog.Features.Persons.Validators;

public class PersonCreateRequestValidator : AbstractValidator<PersonCreateRequest>
{
    public PersonCreateRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MinimumLength(PersonConsts.NameMinLength)
            .MaximumLength(PersonConsts.NameMaxLength);

        RuleFor(x => x.OriginalName)
            .MinimumLength(PersonConsts.OriginalNameMinLength)
            .MaximumLength(PersonConsts.OriginalNameMaxLength)
            .NotEmpty()
            .When(x => x.OriginalName is not null);

        RuleFor(x => x.Country)
            .Must(CountryCodeValidateHelper.ValidateIsoCountryCode)
            .When(x => x.Country is not null)
            .WithMessage("Country '{PropertyValue}' 不是有效的 ISO 3166-1 alpha-2 国家代码（如 CN、JP、US）。");

        RuleFor(x => x.Description)
            .MinimumLength(PersonConsts.DescriptionMinLength)
            .MaximumLength(PersonConsts.DescriptionMaxLength)
            .NotEmpty()
            .When(x => x.Description is not null);
    }
}