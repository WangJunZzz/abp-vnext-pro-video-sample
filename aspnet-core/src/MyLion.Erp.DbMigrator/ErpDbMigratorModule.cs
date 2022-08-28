namespace MyLion.Erp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ErpEntityFrameworkCoreModule),
        typeof(ErpApplicationContractsModule)
        )]
    public class ErpDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
