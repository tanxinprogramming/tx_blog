namespace Tx.Blog.Features.Artists.Dtos;

public record ArtistListItemResponse(
    Guid Id,
    Guid PersonId,
    string Name,
    bool IsActive
);