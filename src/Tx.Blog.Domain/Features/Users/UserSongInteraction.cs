/*
 * 修改日期：20261001
 * 状态：已完成
 */
using Tx.Blog.Features.Musics;

namespace Tx.Blog.Features.Users;

/// <summary>
/// 用户歌曲交互。
/// </summary>
public class UserSongInteraction : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 用户 Id。
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// 歌曲 Id。
    /// </summary>
    public Guid SongId { get; set; }

    /// <summary>
    /// 收听状态
    ///
    /// 一种筛选条件，可以和收藏歌单正交性筛选
    /// </summary>
    public SongStatus? Status { get; set; }

    /// <summary>
    /// 评分，1-10。
    /// </summary>
    public int? Rating { get; set; }

    /// <summary>
    /// 是否收藏，放入收藏歌单
    /// </summary>
    public bool IsFavorite { get; set; }

    /// <summary>
    /// 唯一评价，可编辑。
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// 最后交互时间。
    /// </summary>
    public DateTimeOffset? LastInteractedAt { get; set; }
    
    /// <summary>
    /// 收藏时间
    ///
    /// 暂定用于收藏歌单的排序
    /// </summary>
    public DateTimeOffset? FavoriteAt { get; set; }
    
    /// <summary>
    /// 是否推荐
    ///
    /// 如果推荐说明超级好听
    /// </summary>
    public bool IsRecommended { get; set; }

    /// <summary>
    /// 推荐时间
    /// </summary>
    public DateTimeOffset? RecommendedAt { get; set; }
}