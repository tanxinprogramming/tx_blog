/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Persons;

public class ArtistRoleConfig : IEntityTypeConfiguration<ArtistRole>
{
    public void Configure(EntityTypeBuilder<ArtistRole> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(ArtistRoleConsts.NameMaxLength);
        
        builder.Property(x => x.Description)
            .HasMaxLength(ArtistRoleConsts.DescriptionMaxLength);

        builder
            .HasIndex(x => new { x.MediaType, x.Scope, x.Name })
            .IsUnique();
    }
}