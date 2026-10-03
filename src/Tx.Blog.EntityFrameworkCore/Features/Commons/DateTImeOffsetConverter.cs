using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Tx.Blog.Features.Commons;

/// <summary>
/// DateTimeOffset 全局 ValueConverter。
/// 写入时 ToUniversalTime()，读取原样。
/// </summary>
public static class DateTimeOffsetConverter
{
    public static readonly ValueConverter<DateTimeOffset, DateTimeOffset> Instance =
        new(
            v => v.ToUniversalTime(),
            v => v);
}