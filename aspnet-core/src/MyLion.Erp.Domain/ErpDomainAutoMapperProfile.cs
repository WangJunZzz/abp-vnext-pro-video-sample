using AutoMapper;
using MyLion.Erp.Blogs.Aggregates;
using MyLion.Erp.Blogs.Dto;

namespace MyLion.Erp;

public class ErpDomainAutoMapperProfile : Profile
{
    public ErpDomainAutoMapperProfile()
    {
        CreateMap<Blog, BlogDto>();
        CreateMap<Post, PostDto>();
    }
}