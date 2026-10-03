using Volo.Abp;

namespace Tx.Blog.Features.Exceptions;

public class InvalidCountryCodeException : BusinessException
{
    public InvalidCountryCodeException(string countryCode) : base("ErrorCode:InvalidCountryCode")
    {
        WithData("countryCode", countryCode);
    }
}