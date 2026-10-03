/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

/// <summary>
/// 歌曲。
/// </summary>
public class Song : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 作品 Id。
    /// </summary>
    public Guid WorkId { get; set; }

    /// <summary>
    /// 标题。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 副标题。
    /// </summary>
    public string? Subtitle { get; set; }

    /// <summary>
    /// 版本类型。
    /// </summary>
    public VersionType VersionType { get; set; }

    /// <summary>
    /// ISRC。
    /// </summary>
    public string? Isrc { get; set; }

    /// <summary>
    /// 语言。
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    /// 官方时长，毫秒。
    /// </summary>
    public int? DurationMs { get; set; }

    /// <summary>
    /// 录制日期。
    /// </summary>
    public DateTimeOffset? RecordingDate { get; set; }

    /// <summary>
    /// 是否启用。
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// 导航属性
    ///
    /// WorkId必填，但是Work可能由于没有Include为空
    /// </summary>
    public Work? Work { get; set; }
}