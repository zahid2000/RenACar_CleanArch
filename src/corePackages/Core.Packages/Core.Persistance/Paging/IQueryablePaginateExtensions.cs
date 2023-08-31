using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Core.Persistence.Paging;

public static class IQueryablePaginateExtensions
{
    public static async Task<Paginate<T>> ToPaginateAsync<T>(
        this IQueryable<T> source,
        int index,
        int size,
        CancellationToken cancellationToken = default
        )
    {
        int count = await source.CountAsync(cancellationToken).ConfigureAwait(false);
        List<T> items = await source.Skip(index * size).Take(size).ToListAsync(cancellationToken).ConfigureAwait(false);
        Paginate<T> result = new()
        {
            Index = index,
            Size = size,
            Items = items,
            Count = count,
            Pages = (int)Math.Ceiling(count / (double)size)

        };
        return result;
    }
    public static Paginate<T> ToPaginate<T>(
        this IQueryable<T> source,
        int index,
        int size)
    {
        int count = source.Count();
        List<T> items = source.Skip(index * size).Take(size).ToList();
        Paginate<T> result = new()
        {
            Index = index,
            Size = size,
            Items = items,
            Count = count,
            Pages = (int)Math.Ceiling(count / (double)size)

        };
        return result;
    }
}
