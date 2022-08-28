namespace MyLion.Erp.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public interface IErpDbContext : IEfCoreDbContext
    {
        DbSet<Blog> Blogs { get; set; }
    }
}