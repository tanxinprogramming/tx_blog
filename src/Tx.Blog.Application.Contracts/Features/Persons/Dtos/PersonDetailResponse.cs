using Tx.Blog.Features.Artists.Dtos;

namespace Tx.Blog.Features.Persons.Dtos;

/// <summary>
/// 本体明细响应 DTO。
/// </summary>
public sealed record PersonDetailResponse(
    Guid Id,
    string Name,
    string? OriginalName,
    DateTimeOffset? BirthDate,
    string? Country,
    string? Description,
    bool IsActive,
    List<ArtistListItemResponse> Artists
);