/*
 * 修改日期：20261001
 * 状态：已完成
 */

using Tx.Blog.Features.Commons;

namespace Tx.Blog.Features.Artists;

/// <summary>
/// 人员角色。
/// </summary>
public class ArtistRole : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 媒体类型。
    /// </summary>
    public MediaType MediaType { get; set; }

    /// <summary>
    /// 作用域。
    /// </summary>
    public Scope Scope { get; set; }

    /// <summary>
    /// 名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 排序。
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// 描述。
    /// </summary>
    public string? Description { get; set; }
}