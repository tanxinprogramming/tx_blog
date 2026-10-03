/*
 * 修改日期：20261001
 * 状态：已完成
 */
namespace Tx.Blog.Features.Musics;

/// <summary>
/// 音频轨道。
/// </summary>
public class AudioTrack : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 歌曲 Id。
    /// </summary>
    public Guid SongId { get; set; }

    /// <summary>
    /// 文件路径。
    /// </summary>
    public required string FilePath { get; set; }

    /// <summary>
    /// 格式。
    /// </summary>
    public string? Format { get; set; }

    /// <summary>
    /// 比特率。
    /// </summary>
    public uint? Bitrate { get; set; }

    /// <summary>
    /// 采样率。
    /// </summary>
    public uint? SampleRate { get; set; }

    /// <summary>
    /// 声道数。
    /// </summary>
    public uint? Channels { get; set; }

    /// <summary>
    /// 文件大小。
    /// </summary>
    public ulong? FileSize { get; set; }

    /// <summary>
    /// 文件实际时长，毫秒。
    /// </summary>
    public uint? DurationMs { get; set; }

    /// <summary>
    /// 是否主轨道
    ///
    /// 批量下载时，如果一个Song里面只有一首歌，那么无论是否勾选，直接下载对应AudioTrack
    /// 如果一个Song有多首歌，且只设置了一个IsPrimary，那么下载这个AudioTrack
    /// 如果设置了0个IsPrimary，则下载最新上传的一个AudioTrack
    /// 如果设置了超过1个IsPrimary，则下载设置了的最新上传的一个AudioTrack
    /// 最新使用审计属性的CreationDate
    /// </summary>
    public bool IsPrimary { get; set; }

    /// <summary>
    /// ID3 是否已同步。
    /// </summary>
    public bool Id3Synced { get; set; }
    
    /// <summary>
    /// 显示顺序
    /// </summary>
    public int Order { get; set; }
}