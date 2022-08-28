using MyLion.Erp.Blogs.Enums;

namespace MyLion.Erp.Blogs.Dto;

public class PostDto
{
    public Guid Id { get; set; }

    public Guid BlogId { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public PostType PostType { get; set; }
}