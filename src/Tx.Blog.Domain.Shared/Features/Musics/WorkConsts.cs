/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

public static class WorkConsts
{
    // Title
    public const int TitleMinLength = 1;
    public const int TitleMaxLength = 512;
    
    // OriginalTitle
    public const int OriginalTitleMinLength = 1;
    public const int OriginalTitleMaxLength = 512;
    
    // Language
    public const int LanguageMinLength = 1;
    public const int LanguageMaxLength = 16;
    
    // BasedOnWorkId 无配置
    
    // Description
    public const int DescriptionMinLength = 1;
    public const int DescriptionMaxLength = 4000;
    
    // IsActive 无配置
}