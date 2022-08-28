namespace MyLion.Erp.Blogs.Dto;

public class BlogDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Signature { get; set; }

    public string Github { get; set; }

    public List<PostDto> Posts { get; set; }

    private const string CacheKeyFormat = "n:{0}";

    public static string CalculateCacheKey(string name)
    {
        return string.Format(CacheKeyFormat, name);
    }
 
}