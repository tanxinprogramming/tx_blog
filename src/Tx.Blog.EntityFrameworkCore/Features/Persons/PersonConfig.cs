/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Persons;

public class PersonConfig : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(PersonConsts.NameMaxLength);
        
        builder.Property(x => x.OriginalName)
            .HasMaxLength(PersonConsts.OriginalNameMaxLength);
        
        builder.Property(x => x.Country)
            .HasMaxLength(PersonConsts.CountryMaxLength);
        
        builder.Property(x => x.Description)
            .HasMaxLength(PersonConsts.DescriptionMaxLength);
    }
}