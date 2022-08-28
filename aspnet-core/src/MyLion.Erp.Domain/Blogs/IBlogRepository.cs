using MyLion.Erp.Blogs.Aggregates;
using Volo.Abp.Domain.Repositories;

namespace MyLion.Erp.Blogs;

public interface IBlogRepository : IBasicRepository<Blog, Guid>
{
    Task<Blog> FindByNameAsync(string name, bool include = true);

    Task<List<Blog>> ListAsync(string filter, int maxResultCount = 10, int skipCount = 0);
    Task<long> CountAsync(string filter);
}