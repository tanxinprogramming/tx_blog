/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Commons;

public enum ImageAssetEntityType
{
    // Music 0开头
    /// <summary>
    /// 作品。
    /// </summary>
    Work = 1,
    /// <summary>
    /// 歌曲。
    /// </summary>
    Song = 2,
    /// <summary>
    /// 专辑。
    /// </summary>
    Album = 3,
    
    // Animation 1开头
    
    // Comic 2开头
    
    // Novel 3开头
    
    // Movie 4开头
    
    // Game 5开头

    // Person 6开头
    /// <summary>
    /// 本体。
    /// </summary>
    Person = 6001,
    /// <summary>
    /// 艺人。
    /// </summary>
    Artist = 6002,
    
    // Character 7开头
}