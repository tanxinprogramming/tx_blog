/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

/// <summary>
/// 专辑艺人关系。
/// </summary>
public class AlbumArtistRelation : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 专辑 Id。
    /// </summary>
    public Guid AlbumId { get; set; }

    /// <summary>
    /// 艺人 Id。
    /// </summary>
    public Guid ArtistId { get; set; }

    /// <summary>
    /// 艺人角色 Id。
    /// </summary>
    public Guid ArtistRoleId { get; set; }

    /// <summary>
    /// 排序。
    /// </summary>
    public int AlbumOrder { get; set; }
    
    /// <summary>
    /// 排序。
    /// </summary>
    public int ArtistOrder { get; set; }

    /// <summary>
    /// 是否主要。
    /// </summary>
    public bool IsPrimaryArtist { get; set; }
}