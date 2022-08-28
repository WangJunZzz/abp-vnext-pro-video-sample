using System.ComponentModel.DataAnnotations;

namespace MyLion.Erp.Blogs.Dto;

public class CreateBlogInput
{
    [Required(ErrorMessage = "名称必填")] public string Name { get; set; }

    public string Signature { get; set; }

    public string Github { get; set; }
}