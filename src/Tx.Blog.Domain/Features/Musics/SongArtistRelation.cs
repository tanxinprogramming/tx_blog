/*
 * 修改日期：20261001
 * 状态：已完成
 */

using Tx.Blog.Features.Artists;
using Tx.Blog.Features.Persons;

namespace Tx.Blog.Features.Musics;

/// <summary>
/// 歌曲艺人关系。
/// 用于写 TPE1/TPE2，排序规则 Order + ArtistId。
/// </summary>
public class SongArtistRelation : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 歌曲 Id。
    /// </summary>
    public Guid SongId { get; set; }

    /// <summary>
    /// 艺人 Id。
    /// </summary>
    public Guid ArtistId { get; set; }

    /// <summary>
    /// 艺人角色 Id。
    /// </summary>
    public Guid ArtistRoleId { get; set; }

    /// <summary>
    /// 艺人查询歌曲时候用的排序。
    /// </summary>
    public int SongOrder { get; set; }

    /// <summary>
    /// 歌曲查询艺人时候用的排序。
    /// </summary>
    public int ArtistOrder { get; set; }
    
    /// <summary>
    /// 是否主要。
    /// </summary>
    public bool IsPrimaryArtist { get; set; }
    
    /// <summary>
    /// 导航属性
    /// </summary>
    public Song? Song { get; set; }
    
    /// <summary>
    /// 导航属性
    /// </summary>
    public Artist? Artist { get; set; }
    
    /// <summary>
    /// 导航属性
    /// </summary>
    public ArtistRole? ArtistRole { get; set; }
}