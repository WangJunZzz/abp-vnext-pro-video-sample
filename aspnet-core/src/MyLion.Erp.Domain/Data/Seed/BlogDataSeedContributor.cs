using MyLion.Erp.Blogs;
using MyLion.Erp.Blogs.Aggregates;

namespace MyLion.Erp.Data.Seed;

public class BlogDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IBlogRepository _blogRepository;

    public BlogDataSeedContributor(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        var blog = await _blogRepository.FindByNameAsync(ErpConsts.Xunit.BlogNmae);
        if (blog != null) return;

        blog = new Blog(ErpConsts.Xunit.BlogId, ErpConsts.Xunit.BlogNmae, "abp vnext pro", "github.com");
        await _blogRepository.InsertAsync(blog);
    }
}