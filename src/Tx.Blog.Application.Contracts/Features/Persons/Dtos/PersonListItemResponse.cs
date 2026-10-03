namespace Tx.Blog.Features.Persons.Dtos;

/// <summary>
/// 本体列表项响应 DTO。
/// </summary>
public sealed record PersonListItemResponse(
    Guid Id,
    string Name,
    string? Country,
    bool IsActive,
    DateTimeOffset CreationTime
);