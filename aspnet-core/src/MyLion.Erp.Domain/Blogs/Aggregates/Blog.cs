using Lion.AbpPro.Extension.Customs;
using MyLion.Erp.Blogs.Enums;
using MyLion.Erp.Blogs.Exceptions;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyLion.Erp.Blogs.Aggregates;

public class Blog : FullAuditedAggregateRoot<Guid>

{
    private Blog()
    {
        Posts = new List<Post>();
    }


    public Blog(Guid id, string name, string signature, string github) : base(id)
    {
        SetName(name);
        Signature = signature;
        Github = github;
        Posts = new List<Post>();
    }


    public string Name { get; private set; }

    public string Signature { get; private set; }

    public string Github { get; private set; }

    public List<Post> Posts { get; private set; }


    public void SetName(string name)
    {
        Guard.Length(name, nameof(name), BlogMaxLengthConsts.Name);
        Name = name;
    }


    public void AddPost(Guid id, string title, string content, PostType postType)
    {
        if (Posts.Any(e => e.Title == title)) return;

        Posts.Add(new Post(id, Id, title, content, postType));
    }
}