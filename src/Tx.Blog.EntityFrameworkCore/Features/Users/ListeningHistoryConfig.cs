using Tx.Blog.Features.Musics;

namespace Tx.Blog.Features.Users;

public class ListeningHistoryConfiguration : IEntityTypeConfiguration<ListeningHistory>
{
    public void Configure(EntityTypeBuilder<ListeningHistory> builder)
    {
        builder.ConfigureByConvention();

        builder.HasOne<Song>()
            .WithMany()
            .HasForeignKey(x => x.SongId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => new { x.UserId, x.PlayedAt });
        
        builder.HasIndex(x => new { x.SongId, x.PlayedAt });
        
        builder.HasIndex(x => new { x.UserId, x.SongId, x.PlayedAt });
        
        builder.HasIndex(x => x.PlaySessionId);
    }
}