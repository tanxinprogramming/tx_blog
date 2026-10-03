/*
 * 修改日期：20261001
 * 状态：已完成
 */
using Tx.Blog.Features.Persons;

namespace Tx.Blog.Features.Musics;

/// <summary>
/// 专辑。
/// </summary>
public class Album : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 标题。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 原始标题。
    /// </summary>
    public string? OriginalTitle { get; set; }

    /// <summary>
    /// 发行日期。
    /// </summary>
    public DateTimeOffset? ReleaseDate { get; set; }

    /// <summary>
    /// 厂牌。
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// 目录编号。
    /// </summary>
    public string? CatalogNumber { get; set; }

    /// <summary>
    /// 是否虚拟专辑。
    /// </summary>
    public bool IsVirtual { get; set; }

    /// <summary>
    /// 专辑艺人 Id。
    /// </summary>
    public Guid? AlbumArtistId { get; set; }

    /// <summary>
    /// 总曲目数。
    /// </summary>
    public int? TotalTracks { get; set; }

    /// <summary>
    /// 总碟数。
    /// </summary>
    public int? TotalDiscs { get; set; }

    /// <summary>
    /// 是否启用。
    /// </summary>
    public bool IsActive { get; set; }
    
    /// <summary>
    /// 导航属性
    ///
    /// 如果有专辑艺人就指向
    /// </summary>
    public Artist? AlbumArtist { get; set; }

    // /// <summary>
    // /// 导航属性
    // ///
    // /// 本专辑包含的歌曲
    // /// </summary>
    // public List<Song> Songs { get; set; } = [];
}