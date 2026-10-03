/*
 * 修改日期：20261001
 * 状态：已完成
 */
using Tx.Blog.Features.Persons;

namespace Tx.Blog.Features.Musics;

public class AlbumArtistRelationConfig : IEntityTypeConfiguration<AlbumArtistRelation>
{
    public void Configure(EntityTypeBuilder<AlbumArtistRelation> builder)
    {
        builder.ConfigureByConvention();

        builder.HasIndex(x => new { x.AlbumId, x.ArtistId, x.ArtistRoleId })
            .IsUnique();

        builder.HasOne<Album>()
            .WithMany()
            .HasForeignKey(x => x.AlbumId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Artist>()
            .WithMany()
            .HasForeignKey(x => x.ArtistId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ArtistRole>()
            .WithMany()
            .HasForeignKey(x => x.ArtistRoleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}