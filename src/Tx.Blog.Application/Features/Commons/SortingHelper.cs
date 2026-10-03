namespace Tx.Blog.Features.Commons;

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
                throw new BusinessException("Tx:InvalidSortingField")
                    .WithData("Field", alias);

            parsed.Add($"{realField} {(descending ? "DESC" : "ASC")}");
        }

        return query.OrderBy(string.Join(", ", parsed));
    }
}