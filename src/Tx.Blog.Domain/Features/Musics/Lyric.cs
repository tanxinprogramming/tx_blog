/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

/// <summary>
/// 歌词。
/// </summary>
public class Lyric : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 歌曲 Id。
    /// </summary>
    public Guid SongId { get; set; }

    /// <summary>
    /// 主语言，BCP 47。
    /// </summary>
    public required string PrimaryLanguage { get; set; }

    /// <summary>
    /// 副语言，BCP 47，可空。
    /// </summary>
    public string? SecondaryLanguage { get; set; }

    /// <summary>
    /// LRC 全文。
    /// </summary>
    public required string Content { get; set; }

    /// <summary>
    /// 版权。
    /// </summary>
    public string? Copyright { get; set; }

    /// <summary>
    /// 优先显示顺序
    /// </summary>
    public int Order { get; set; }
}