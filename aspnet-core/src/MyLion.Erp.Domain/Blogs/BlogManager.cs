using MyLion.Erp.Blogs.Aggregates;
using MyLion.Erp.Blogs.Dto;
using MyLion.Erp.Blogs.Exceptions;
using Volo.Abp.Caching;

namespace MyLion.Erp.Blogs;

public class BlogManager : ErpDomainService
{
    private readonly IBlogRepository _blogRepository;
    private readonly IDistributedCache<BlogDto> _distributedCache;

    public BlogManager(IBlogRepository blogRepository, IDistributedCache<BlogDto> distributedCache)
    {
        _blogRepository = blogRepository;
        _distributedCache = distributedCache;
    }

    /// <summary>
    /// 新增博客
    /// </summary>
    public async Task<BlogDto> CreateAsync(Guid id, string name, string github, string signature)
    {
        var blog = await _blogRepository.FindByNameAsync(name);
        if (blog != null) throw new BlogDomainException("博客已存在");

        blog = new Blog(id, name, signature, github);

        blog = await _blogRepository.InsertAsync(blog);

        return ObjectMapper.Map<Blog, BlogDto>(blog);
    }


    public async Task<BlogDto> FindByNameAsync(string name)
    {
        var result = await _distributedCache.GetOrAddAsync(BlogDto.CalculateCacheKey(name), async () =>
        {
            var blog = await _blogRepository.FindByNameAsync(name);

            return ObjectMapper.Map<Blog, BlogDto>(blog);
        });

        return result;
    }


    public async Task<List<BlogDto>> ListAsync(string filter, int maxResultCount = 10, int skipCount = 0)
    {
        var result = await _blogRepository.ListAsync(filter, maxResultCount, skipCount);
        return ObjectMapper.Map<List<Blog>, List<BlogDto>>(result);
    }


    public async Task<long> CountAsync(string filter)
    {
        return await _blogRepository.CountAsync(filter);
    }
}