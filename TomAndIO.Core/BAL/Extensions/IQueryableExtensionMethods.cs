using TomAndIO.Models.Entities.Pagination;

namespace TomAndIO.Core.BAL.Extensions;

public static class QueryableExtensionMethods
{
    public static PagedResult<T> GetPage<T>(this IQueryable<T> query, int page, int pageSize) where T : class
    {
        var result = new PagedResult<T>();
        result.CurrentPage = page;
        result.PageSize = pageSize;
        result.RowCount = query.Count();

        var pageCount = (double)result.RowCount / pageSize;
        result.PageCount = (int)Math.Ceiling(pageCount);

        var skip = (page - 1) * pageSize;
        result.Results = query.Skip(skip).Take(pageSize).ToList();

        return result;
    }
}