using System.ComponentModel;

namespace MyLion.Erp.Blogs.Enums;

public enum PostType
{
    [Description("文章")] Article = 10,
    [Description("随笔")] Essay = 20
}