/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

public class AudioTrackConfiguration : IEntityTypeConfiguration<AudioTrack>
{
    public void Configure(EntityTypeBuilder<AudioTrack> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.FilePath)
            .IsRequired()
            .HasMaxLength(AudioTrackConsts.FilePathMaxLength);
        
        builder.Property(x => x.Format)
            .HasMaxLength(AudioTrackConsts.FormatMaxLength);

        builder.HasOne<Song>()
            .WithMany()
            .HasForeignKey(x => x.SongId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.SongId);
    }
}