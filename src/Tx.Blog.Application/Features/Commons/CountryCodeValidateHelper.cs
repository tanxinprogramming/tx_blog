using System.Collections.Frozen;
using System.Globalization;
using Tx.Blog.Features.Exceptions;

namespace Tx.Blog.Features.Commons;

public static class CountryCodeValidateHelper
{
    private static readonly FrozenSet<string> ValidIsoCodes =
        ISO3166.Country.List.Select(x => x.TwoLetterCode).ToFrozenSet(StringComparer.OrdinalIgnoreCase);
    
    public static bool ValidateIsoCountryCode(string? countryCode)
        => string.IsNullOrWhiteSpace(countryCode) || ValidIsoCodes.Contains(countryCode);

    public static string? ToDatabaseCountryCode(string? countryCode)
    {
        if (countryCode is null)
        {
            return null;
        }
        
        if (string.IsNullOrWhiteSpace(countryCode) || !ValidIsoCodes.Contains(countryCode))
        {
            // 由于校验了，正常情况应该不会走这里
            throw new InvalidCountryCodeException(countryCode);
        }

        return countryCode.ToUpperInvariant();
    }
}