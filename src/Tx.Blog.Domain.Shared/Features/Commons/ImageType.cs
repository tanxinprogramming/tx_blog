/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Commons;

/// <summary>
/// 图片类型。
/// </summary>
public enum ImageType
{
    /// <summary>
    /// 封面
    ///
    /// 显示到列表的，尽量一张图片只有一个
    /// 如果有多个，按照最新上传的为准
    /// </summary>
    Cover = 0,

    /// <summary>
    /// 内部图片
    ///
    /// 显示在内容内部图片专栏的图片
    /// </summary>
    Photo = 1,

    /// <summary>
    /// 背景
    ///
    /// 显示为背景的
    /// </summary>
    Background = 2,

    /// <summary>
    /// 缩略图
    ///
    /// 显示为缩略图的
    /// </summary>
    Thumbnail = 3,

    /// <summary>
    /// 其他
    ///
    /// 难以归类的
    /// </summary>
    Other = 999
}