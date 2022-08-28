using Lion.AbpPro.Extension.Customs.Dtos;

namespace MyLion.Erp.Blogs.Dto;

public class GetBlogFreeSqlPagingDto : PagingBase
{
    public string Filter { get; set; }
}