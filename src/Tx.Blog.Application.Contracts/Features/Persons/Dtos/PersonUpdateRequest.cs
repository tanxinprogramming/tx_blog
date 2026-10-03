namespace Tx.Blog.Features.Persons.Dtos;

/// <summary>
/// 更新本体请求 DTO。不含 Id 和 Artists。
/// </summary>
public record PersonUpdateRequest(
    string Name,
    string? OriginalName,
    DateTimeOffset? BirthDate,
    string? Country,
    string? Description,
    bool IsActive = true
);