/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

public class LyricConfig : IEntityTypeConfiguration<Lyric>
{
    public void Configure(EntityTypeBuilder<Lyric> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.PrimaryLanguage)
            .IsRequired()
            .HasMaxLength(LyricConsts.PrimaryLanguageMaxLength);
        
        builder.Property(x => x.SecondaryLanguage)
            .HasMaxLength(LyricConsts.SecondaryLanguageMaxLength);
        
        builder.Property(x => x.Content)
            .IsRequired()
            .HasColumnType("text");
        
        builder.Property(x => x.Copyright)
            .HasMaxLength(LyricConsts.CopyrightMaxLength);

        builder.HasOne<Song>()
            .WithMany()
            .HasForeignKey(x => x.SongId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.SongId);
    }
}