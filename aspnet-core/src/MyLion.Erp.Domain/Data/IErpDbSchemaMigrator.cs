namespace MyLion.Erp.Data
{
    public interface IErpDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
