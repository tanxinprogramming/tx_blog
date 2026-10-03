/*
 * 修改日期：20261001
 * 状态：已完成
 */
using Tx.Blog.Features.Musics;

namespace Tx.Blog.Features.Users;

public class UserSongInteractionConfiguration : IEntityTypeConfiguration<UserSongInteraction>
{
    public void Configure(EntityTypeBuilder<UserSongInteraction> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.Comment)
            .HasMaxLength(UserSongInteractionConsts.CommentMaxLength);
        
        builder.HasOne<Song>()
            .WithMany()
            .HasForeignKey(x => x.SongId)
            .OnDelete(DeleteBehavior.Cascade);

        // 索引
        builder.HasIndex(x => x.RecommendedAt);
        
        builder.HasIndex(x => new { x.UserId, x.SongId })
            .IsUnique();
        
        builder.HasIndex(x => new { x.UserId, x.IsRecommended });
    }
}