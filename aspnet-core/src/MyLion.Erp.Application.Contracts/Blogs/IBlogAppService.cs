using MyLion.Erp.Blogs.Dto;
using Volo.Abp.Application.Dtos;

namespace MyLion.Erp.Blogs;

public interface IBlogAppService : IApplicationService
{
    Task CreateAsync(CreateBlogInput input);

    Task<PagedResultDto<BlogPagingOutput>> PageAsync(BlogPagingInput input);
}