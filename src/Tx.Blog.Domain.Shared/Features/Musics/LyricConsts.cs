/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

public static class LyricConsts
{
    // SongId 无配置

    // PrimaryLanguage
    public const int PrimaryLanguageMinLength = 1;
    public const int PrimaryLanguageMaxLength = 32;

    // SecondaryLanguage
    public const int SecondaryLanguageMinLength = 1;
    public const int SecondaryLanguageMaxLength = 32;

    // Content
    public const int ContentMinLength = 1;
    public const int ContentMaxLength = 4000;

    // Copyright
    public const int CopyrightMinLength = 1;
    public const int CopyrightMaxLength = 512;
    
    // Order 无配置
}