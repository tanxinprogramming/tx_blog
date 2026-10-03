/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

/// <summary>
/// 作品。
/// </summary>
public class Work : FullAuditedAggregateRoot<Guid>
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
    /// 语言。
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    /// 基于作品 Id。
    ///
    /// 例如：
    /// 1.乙歌手翻唱了甲歌手的曲目 Work A，那么这里就要指向Work A
    /// 2.如果是原创这里就是空
    /// </summary>
    public Guid? BasedOnWorkId { get; set; }

    /// <summary>
    /// 描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 是否启用。
    /// </summary>
    public bool IsActive { get; set; }
    
    /// <summary>
    /// 导航属性
    ///
    /// 翻唱自，无论是否修改了Work
    /// </summary>
    public Work? BasedOnWork { get; set; }

    /// <summary>
    /// 导航属性
    ///
    /// 被哪些Work翻唱了
    /// </summary>
    public List<Work> WorkChildren { get; set; } = [];

    /// <summary>
    /// 导航属性
    ///
    /// 有哪些歌属于这个作品
    /// </summary>
    public List<Song> Songs { get; set; } = [];
}