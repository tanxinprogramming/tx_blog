/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

/// <summary>
/// 版本类型。
/// </summary>
public enum VersionType
{
    /// <summary>
    /// 录音室版。
    /// </summary>
    Studio = 0,

    /// <summary>
    /// 现场版。
    /// </summary>
    Live = 1,

    /// <summary>
    /// 器乐版。
    /// </summary>
    Instrumental = 2,

    /// <summary>
    /// 原声版。
    /// </summary>
    Acoustic = 3,

    /// <summary>
    /// 混音版。
    /// </summary>
    Remix = 4,

    /// <summary>
    /// 小样。
    /// </summary>
    Demo = 5,

    /// <summary>
    /// 翻唱。
    /// </summary>
    Cover = 6,

    /// <summary>
    /// 电台剪辑版。
    /// </summary>
    RadioEdit = 7,

    /// <summary>
    /// 其他。
    /// </summary>
    Other = 8
}