using Lion.AbpPro.Extension.Customs.Dtos;

namespace MyLion.Erp.Blogs.Dto;

public class BlogPagingInput : PagingBase
{
    public string Filter { get; set; }
}