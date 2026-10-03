/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

public class SongAlbumRelationConfiguration : IEntityTypeConfiguration<SongAlbumRelation>
{
    public void Configure(EntityTypeBuilder<SongAlbumRelation> builder)
    {
        builder.ConfigureByConvention();

        builder.HasIndex(x => new { x.SongId, x.AlbumId })
            .IsUnique();
        
        builder.HasIndex(x => new { x.AlbumId, x.DiscNumber, x.TrackNumber })
            .IsUnique();

        builder.HasOne<Song>()
            .WithMany()
            .HasForeignKey(x => x.SongId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Album>()
            .WithMany()
            .HasForeignKey(x => x.AlbumId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}