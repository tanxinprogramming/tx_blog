/*
 * 修改日期：20261001
 * 状态：已完成
 */

using Tx.Blog.Features.Artists;
using Tx.Blog.Features.Persons;

namespace Tx.Blog.Features.Musics;

public class AlbumConfig : IEntityTypeConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(AlbumConsts.TitleMaxLength);
        
        builder.Property(x => x.OriginalTitle)
            .HasMaxLength(AlbumConsts.OriginalTitleMaxLength);
        
        builder.Property(x => x.Label)
            .HasMaxLength(AlbumConsts.LabelMaxLength);
        
        builder.Property(x => x.CatalogNumber)
            .HasMaxLength(AlbumConsts.CatelogNumberMaxLength);

        builder.HasOne<Artist>(x => x.AlbumArtist)
            .WithMany()
            .HasForeignKey(x => x.AlbumArtistId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.AlbumArtistId);
    }
}