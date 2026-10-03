/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

public class WorkConfig : IEntityTypeConfiguration<Work>
{
    public void Configure(EntityTypeBuilder<Work> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(WorkConsts.TitleMaxLength);
        
        builder.Property(x => x.OriginalTitle)
            .HasMaxLength(WorkConsts.OriginalTitleMaxLength);
        
        builder.Property(x => x.Language)
            .HasMaxLength(WorkConsts.LanguageMaxLength);
        
        builder.Property(x => x.Description)
            .HasMaxLength(WorkConsts.DescriptionMaxLength);

        builder.HasOne<Work>(x => x.BasedOnWork)
            .WithMany(x => x.WorkChildren)
            .HasForeignKey(x => x.BasedOnWorkId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}