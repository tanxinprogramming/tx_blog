namespace Tx.Blog.Features.Persons.Dtos;

/// <summary>
/// 本体列表查询请求 DTO。
/// 继承 ABP 分页基类，无法用主构造函数，故用 class。
/// </summary>
public class PersonGetListRequest : PagedAndSortedResultRequestDto
{
    /// <summary>按名称模糊搜索。</summary>
    public string? NameFilter { get; init; }

    /// <summary>按国家 ISO 3166-1 alpha-2 代码过滤。</summary>
    public string? Country { get; init; }

    /// <summary>按是否启用过滤。</summary>
    public bool? IsActive { get; init; }
}