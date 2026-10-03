/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Persons;

/// <summary>
/// 艺人署名身份。
/// 是所有工作人员署名的抽象，一个 Person 可以有多个 Artist。
/// 例如艺人改名后，Person 不变，Artist 变为两个。
/// </summary>
public class Artist : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 署名名称，写 TPE2。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 本体 Person Id。
    /// 其 Name 写 TPE1。
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// 是否启用。
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// 导航属性
    ///
    /// Person 1:N Artist
    /// </summary>
    public Person? Person { get; set; }
}