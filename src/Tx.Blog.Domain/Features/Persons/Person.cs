/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Persons;

/// <summary>
/// 署名本体。
/// 公司、组合、个人、企划均可建 Person。
/// 一个 Person 可以有多个 Artist（艺名/马甲/历史名）。
/// </summary>
public class Person : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 主要使用名称
    ///
    /// 在Music区，用于ID3v2 TPE1
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 本名
    ///
    /// 例如Revo应该是某太郎，一般我不去了解本名
    /// </summary>
    public string? OriginalName { get; set; }

    /// <summary>
    /// 出生日期。
    /// </summary>
    public DateTimeOffset? BirthDate { get; set; }

    /// <summary>
    /// 国家。
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// 描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 是否启用。
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// 查看对应了多少
    /// </summary>
    public List<Artist> Artists { get; set; } = [];
}