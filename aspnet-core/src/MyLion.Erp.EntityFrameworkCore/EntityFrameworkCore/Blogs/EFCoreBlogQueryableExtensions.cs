namespace MyLion.Erp.EntityFrameworkCore.Blogs;

public static class EFCoreBlogQueryableExtensions
{
    public static IQueryable<Blog> IncludeDetails(this IQueryable<Blog> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable.Include(x => x.Posts);
    }
}