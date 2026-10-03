/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Commons;

/// <summary>
/// 多态图片资源。
/// 接受孤儿图片，定期清理时设 IsDeleted = true。
/// </summary>
public class ImageAsset : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 实体类型。
    ///
    /// 使用ImageAssetEntityTypeConsts限定值范围
    /// </summary>
    public ImageAssetEntityType EntityType { get; set; }

    /// <summary>
    /// 实体 Id。
    /// </summary>
    public Guid? EntityId { get; set; }

    /// <summary>
    /// 存放文件的目录路径，不包含文件名 
    /// </summary>
    public required string RelativePath { get; set; }
    
    /// <summary>
    /// 文件名，保存为这个文件名，一般用Guid存储（不加横线），带后缀
    /// </summary>
    public required string FileName { get; set; }
    
    /// <summary>
    /// 原始文件名，带后缀
    /// </summary>
    public required string OriginalFileName { get; set; }

    /// <summary>
    /// 图片用途类型
    /// </summary>
    public ImageType ImageType { get; set; }

    /// <summary>
    /// 排序
    ///
    /// 除了这个，还要按照上传时间排序
    /// </summary>
    public int Order { get; set; }
}