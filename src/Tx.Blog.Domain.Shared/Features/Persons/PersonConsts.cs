/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Persons;

public static class PersonConsts
{
    // Name
    public const int NameMinLength = 1;
    public const int NameMaxLength = 256;
    
    // OriginalName
    public const int OriginalNameMinLength = 1;
    public const int OriginalNameMaxLength = 256;
    
    // BirthDate 无配置
    
    // Country
    public const int CountryMinLength = 2;
    public const int CountryMaxLength = 2;
    
    // Description
    public const int DescriptionMinLength = 1;
    public const int DescriptionMaxLength = 4000;
    
    // IsActive 无配置
}