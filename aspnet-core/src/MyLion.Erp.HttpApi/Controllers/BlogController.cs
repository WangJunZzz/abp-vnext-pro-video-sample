using MyLion.Erp.Blogs;
using MyLion.Erp.Blogs.Dto;
using Volo.Abp.Application.Dtos;

namespace MyLion.Erp.Controllers;

[Route("blogs")]
public class BlogController : ErpController, IBlogAppService
{
    private readonly IBlogAppService _blogAppService;

    public BlogController(IBlogAppService blogAppService)
    {
        _blogAppService = blogAppService;
    }

    [HttpPost("createBlog")]
    [SwaggerOperation(summary: "创建博客", Tags = new[] { "Blogs" })]
    public Task CreateAsync(CreateBlogInput input)
    {
        return _blogAppService.CreateAsync(input);
    }

    [HttpPost("pageBlog")]
    [SwaggerOperation(summary: "分页获取博客", Tags = new[] { "Blogs" })]
    public Task<PagedResultDto<BlogPagingOutput>> PageAsync(BlogPagingInput input)
    {
        return _blogAppService.PageAsync(input);
    }
}