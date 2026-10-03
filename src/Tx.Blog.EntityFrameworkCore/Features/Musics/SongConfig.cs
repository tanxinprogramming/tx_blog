/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

public class SongConfig : IEntityTypeConfiguration<Song>
{
    public void Configure(EntityTypeBuilder<Song> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(SongConsts.TitleMaxLength);
        
        builder.Property(x => x.Subtitle)
            .HasMaxLength(SongConsts.SubtitleMaxLength);
        
        builder.Property(x => x.Isrc)
            .HasMaxLength(SongConsts.IsrcMaxLength);
        
        builder.Property(x => x.Language)
            .HasMaxLength(SongConsts.LanguageMaxLength);

        builder.HasOne<Work>(x => x.Work)
            .WithMany(x => x.Songs)
            .HasForeignKey(x => x.WorkId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.WorkId);
    }
}