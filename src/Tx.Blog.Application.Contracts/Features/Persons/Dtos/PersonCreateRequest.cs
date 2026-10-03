namespace Tx.Blog.Features.Persons.Dtos;

/// <summary>
/// 创建本体请求 DTO。不含 Id 和 Artists。
/// </summary>
public record PersonCreateRequest(
    string Name,
    string? OriginalName,
    DateTimeOffset? BirthDate,
    string? Country,
    string? Description,
    bool IsActive = true
);