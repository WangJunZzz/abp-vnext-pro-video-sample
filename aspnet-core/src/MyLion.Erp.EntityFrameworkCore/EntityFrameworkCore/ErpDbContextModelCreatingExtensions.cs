using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MyLion.Erp.EntityFrameworkCore
{
    public static class ErpDbContextModelCreatingExtensions
    {
        public static void ConfigureErp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Blog>(b =>
            {
                b.ToTable(ErpConsts.DbTablePrefix + nameof(Blog), ErpConsts.DbSchema);
                b.Property(e => e.Name).HasMaxLength(BlogMaxLengthConsts.Name).HasComment("博客名称");
                b.Property(e => e.Github).HasMaxLength(BlogMaxLengthConsts.Github).HasComment("github地址");
                b.Property(e => e.Signature).HasMaxLength(BlogMaxLengthConsts.Signature).HasComment("签名");
                b.HasIndex(e => e.Name).IsUnique();
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            
            builder.Entity<Post>(b =>
            {
                b.ToTable(ErpConsts.DbTablePrefix + nameof(Post), ErpConsts.DbSchema);
                b.Property(e => e.Title).HasMaxLength(BlogMaxLengthConsts.Name).HasComment("文章标题");
                b.Property(e => e.Content).HasMaxLength(BlogMaxLengthConsts.Github).HasComment("文章内容");
                b.HasIndex(e => e.Title).IsUnique();
                b.ConfigureByConvention(); //auto configure for the base class props
            });
        }
    }
}