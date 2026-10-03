/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Commons;

public class ImageAssetConfiguration : IEntityTypeConfiguration<ImageAsset>
{
    public void Configure(EntityTypeBuilder<ImageAsset> builder)
    {
        builder.ConfigureByConvention();
        
        builder.Property(x => x.EntityType)
            .HasConversion<string>()
            .HasMaxLength(ImageAssetConsts.EntityTypeMaxLength);
        
        builder.Property(x => x.RelativePath)
            .IsRequired()
            .HasMaxLength(ImageAssetConsts.RelativePathMaxLength);
        
        builder.Property(x => x.FileName)
            .IsRequired()
            .HasMaxLength(ImageAssetConsts.FileNameMaxLength);
        
        builder.Property(x => x.OriginalFileName)
            .IsRequired()
            .HasMaxLength(ImageAssetConsts.OriginalFileNameMaxLength);

        builder.HasIndex(x => new { x.EntityType, x.EntityId });
    }
}