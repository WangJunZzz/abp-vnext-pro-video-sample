using Lion.AbpPro.Extension.Customs.Dtos;
using Lion.AbpPro.Extension.System;
using MyLion.Erp.Blogs;
using MyLion.Erp.Blogs.Dto;

namespace MyLion.Erp.FreeSqlRepository;

public class BlogFreeSqlRepository : FreeSqlBasicRepository, IBlogFreeSqlRepository
{
    public async Task<CustomePagedResultDto<BlogFreeSqlPagingDto>> PagingAsync(GetBlogFreeSqlPagingDto input)
    {
        var sql = "select id, " +
                  " Name, " +
                  " Signature, " +
                  " Github, " +
                  "    from ErpBlog  " +
                  " where IsDeleted = 0 ";

        if (input.Filter.IsNotNullOrWhiteSpace())
        {
            sql += " and Name = ?filter";
        }


        var result = await FreeSql.Select<BlogFreeSqlPagingDto>()
            .WithSql(sql, input)
            .Count(out var total)
            .Page(input.PageIndex, input.PageSize)
            .ToListAsync();
        return new CustomePagedResultDto<BlogFreeSqlPagingDto>(total, result);
    }
}