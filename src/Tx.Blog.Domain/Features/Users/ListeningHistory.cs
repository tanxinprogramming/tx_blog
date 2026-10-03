namespace Tx.Blog.Features.Users;

/// <summary>
/// 收听历史。
/// </summary>
public class ListeningHistory : FullAuditedAggregateRoot<Guid>
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
    /// 播放会话 Id。
    /// 用于合并暂停/继续为同一次播放。
    /// </summary>
    public Guid? PlaySessionId { get; set; }
    
    /// <summary>
    /// 本次播放开始时间
    ///
    /// 现实时间
    /// </summary>
    public DateTimeOffset PlayedAt { get; set; }

    /// <summary>
    /// 本次播放结束时间
    ///
    /// 现实时间
    /// </summary>
    public DateTimeOffset? EndedAt { get; set; }

    /// <summary>
    /// 实际收听时长，毫秒。
    /// 只累计未跳过的播放时间。
    /// </summary>
    public int? ListenedMs { get; set; }

    /// <summary>
    /// 播放结束时的进度位置，毫秒。
    /// </summary>
    public int? EndPositionMs { get; set; }

    /// <summary>
    /// 是否完整播放。
    /// 由应用层根据 ListenedMs / 歌曲时长 判断。
    /// 阈值暂时设置为80%以上就是Complete
    /// </summary>
    public bool IsCompleted { get; set; }
}