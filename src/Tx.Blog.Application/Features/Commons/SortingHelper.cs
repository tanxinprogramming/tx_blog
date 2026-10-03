using Tx.Blog.Features.Exceptions;

namespace Tx.Blog.Features.Commons;

/// <summary>
/// 通用白名单排序辅助类。
/// 支持多列排序、别名映射、方向指定。
/// </summary>
public static class SortingHelper
{
    public static IQueryable<T> ApplySorting<T>(
        IQueryable<T> query,
        string? sorting,
        IReadOnlyDictionary<string, string> aliasMap,
        string defaultSort)
    {
        if (string.IsNullOrWhiteSpace(sorting))
            return query.OrderBy(defaultSort);

        var parts = sorting.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        var parsed = new List<string>();

        foreach (var part in parts)
        {
            var tokens = part.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var alias = tokens[0];
            var descending = tokens.Length > 1
                             && tokens[1].Equals("desc", StringComparison.OrdinalIgnoreCase);

            if (!aliasMap.TryGetValue(alias, out var realField))
            {
                throw new InvalidSortingFieldException(alias);
            }

            parsed.Add($"{realField} {(descending ? "DESC" : "ASC")}");
        }

        return query.OrderBy(string.Join(", ", parsed));
    }
}