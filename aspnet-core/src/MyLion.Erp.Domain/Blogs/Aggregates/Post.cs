using MyLion.Erp.Blogs.Enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyLion.Erp.Blogs.Aggregates;

public class Post : FullAuditedEntity<Guid>
{
    private Post()
    {
        
    }

    public Post(Guid id, Guid blogId, string title, string content, PostType postType) : base(id)
    {
        BlogId = blogId;
        Title = title;
        Content = content;
        PostType = postType;
    }

    public Guid BlogId { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public PostType PostType { get; set; }
}