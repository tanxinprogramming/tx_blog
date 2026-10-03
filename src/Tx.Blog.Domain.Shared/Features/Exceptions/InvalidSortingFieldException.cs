using Volo.Abp;

namespace Tx.Blog.Features.Exceptions;

public class InvalidSortingFieldException : BusinessException
{
    public InvalidSortingFieldException(string field) : base("ErrorCode:InvalidSortingField")
    {
        WithData("field", field);
    }
}