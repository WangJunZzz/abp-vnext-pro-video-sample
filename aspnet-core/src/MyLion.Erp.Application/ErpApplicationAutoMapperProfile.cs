using MyLion.Erp.Blogs.Dto;

namespace MyLion.Erp
{
    public class ErpApplicationAutoMapperProfile : Profile
    {
        public ErpApplicationAutoMapperProfile()
        {
            CreateMap<BlogDto, BlogPagingOutput>();
        }
    }
}
