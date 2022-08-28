using MyLion.Erp.Blogs.Exceptions;
using Volo.Abp.Guids;
using Shouldly;

namespace MyLion.Erp.Blogs;

public sealed class BlogManagerTests : ErpDomainTestBase
{
    private readonly BlogManager _blogManager;
    private readonly IGuidGenerator _guidGenerator;

    public BlogManagerTests()
    {
        _blogManager = GetRequiredService<BlogManager>();
        _guidGenerator = GetRequiredService<IGuidGenerator>();
    }

    [Fact]
    public async Task CreateAsync_Shuold_OK()
    {
        var result = await _blogManager.CreateAsync(_guidGenerator.Create(), "test", "test1", "test2");
        result.ShouldNotBeNull();
        result.Name.ShouldBe("test");
        result.Github.ShouldBe("test1");
        result.Signature.ShouldBe("test2");
    }

    [Fact]
    public async Task CreateAsync_Exception()
    {
        var result = await Should.ThrowAsync<BlogDomainException>(async () =>
        {

            await _blogManager.CreateAsync(_guidGenerator.Create(), ErpConsts.Xunit.BlogNmae, "test1", "test2");

        });
        result.Message.ShouldBe("博客已存在");
    }
}