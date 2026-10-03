/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

/// <summary>
/// 歌曲收听状态。
/// </summary>
public enum SongStatus
{
    /// <summary>
    /// 想听。
    /// </summary>
    WishToListen = 0,

    /// <summary>
    /// 在听，可以理解为还记得不熟
    /// </summary>
    Listening = 1,

    /// <summary>
    /// 听过，可以理解为听了熟悉了
    /// </summary>
    Listened = 2,

    /// <summary>
    /// 弃听，听了但不喜欢
    /// </summary>
    Dropped = 3
}