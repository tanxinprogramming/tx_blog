/*
 * 修改日期：20261001
 * 状态：已完成
 */

using Tx.Blog.Features.Artists;
using Tx.Blog.Features.Persons;

namespace Tx.Blog.Features.Musics;

public class SongArtistRelationConfig : IEntityTypeConfiguration<SongArtistRelation>
{
    public void Configure(EntityTypeBuilder<SongArtistRelation> builder)
    {
        builder.ConfigureByConvention();

        builder.HasIndex(x => new { x.SongId, x.ArtistId, x.ArtistRoleId }).IsUnique();

        builder.HasOne<Song>(x => x.Song)
            .WithMany()
            .HasForeignKey(x => x.SongId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Artist>(x => x.Artist)
            .WithMany()
            .HasForeignKey(x => x.ArtistId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ArtistRole>(x => x.ArtistRole)
            .WithMany()
            .HasForeignKey(x => x.ArtistRoleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}