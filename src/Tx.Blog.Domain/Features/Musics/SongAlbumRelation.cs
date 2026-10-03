/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

/// <summary>
/// 歌曲专辑关系。
/// </summary>
public class SongAlbumRelation : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 歌曲 Id。
    /// </summary>
    public Guid SongId { get; set; }

    /// <summary>
    /// 专辑 Id。
    /// </summary>
    public Guid AlbumId { get; set; }

    /// <summary>
    /// 碟号。
    /// </summary>
    public uint DiscNumber { get; set; }

    /// <summary>
    /// 音轨号。
    /// </summary>
    public uint TrackNumber { get; set; }
}