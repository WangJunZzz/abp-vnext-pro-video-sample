using MyLion.Erp.Blogs.Aggregates;
using MyLion.Erp.Blogs.Dto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Guids;

namespace MyLion.Erp.Blogs;

[Authorize]
public class BlogAppService : ErpAppService, IBlogAppService
{
    private readonly BlogManager _blogManager;
    private readonly IGuidGenerator _guidGenerator;

    public BlogAppService(BlogManager blogManager, IGuidGenerator guidGenerator)
    {
        _blogManager = blogManager;
        _guidGenerator = guidGenerator;
    }

    [Authorize(ErpPermissions.BlogManagement.Blog.Created)]
    public async Task CreateAsync(CreateBlogInput input)
    {
        await _blogManager.CreateAsync(_guidGenerator.Create(), input.Name, input.Github, input.Signature);
    }


    public async Task<PagedResultDto<BlogPagingOutput>> PageAsync(BlogPagingInput input)
    {
        var result = new PagedResultDto<BlogPagingOutput>
        {
            TotalCount = await _blogManager.CountAsync(input.Filter)
        };
        var blogs = await _blogManager.ListAsync(input.Filter, input.PageSize, input.SkipCount);
        result.Items = ObjectMapper.Map<List<BlogDto>, List<BlogPagingOutput>>(blogs);
        return result;
    }
}