using System.Linq.Expressions;
using Lion.AbpPro.Extension.System;

namespace MyLion.Erp.EntityFrameworkCore.Blogs;

public class EFCoreBlogRepository : EfCoreRepository<IErpDbContext, Blog, Guid>, IBlogRepository
{
    public EFCoreBlogRepository(IDbContextProvider<IErpDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<Blog> FindByNameAsync(string name, bool include = true)
    {
        return await (await GetDbSetAsync())
            .IncludeDetails(include)
            .Where(e => e.Name == name)
            .FirstOrDefaultAsync();
    }

    public async Task<List<Blog>> ListAsync(string filter, int maxResultCount = 10, int skipCount = 0)
    {
        return await (await GetDbSetAsync())
            .WhereIf(filter.IsNotNullOrWhiteSpace(), e => filter.Contains(e.Name))
            .OrderByDescending(e => e.CreationTime)
            .PageBy(skipCount, maxResultCount)
            .ToListAsync();
    }

    
    public async Task<long> CountAsync(string filter)
    {
        return await (await GetDbSetAsync())
            .WhereIf(filter.IsNotNullOrWhiteSpace(), e => filter.Contains(e.Name))
            .CountAsync();
    }


    public override async Task<IQueryable<Blog>> WithDetailsAsync(params Expression<Func<Blog, object>>[] propertySelectors)
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}