/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Persons;

public class ArtistConfig : IEntityTypeConfiguration<Artist>
{
    public void Configure(EntityTypeBuilder<Artist> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(ArtistConsts.NameMaxLength);
        
        builder.Property(x => x.PersonId)
            .IsRequired();

        builder.HasOne<Person>(x => x.Person)
            .WithMany(x => x.Artists)
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);

        // 不是所有数据库都会对外键加索引
        builder.HasIndex(x => x.PersonId);
    }
}