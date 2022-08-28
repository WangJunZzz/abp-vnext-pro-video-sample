using Lion.AbpPro.DataDictionaryManagement;

namespace MyLion.Erp
{
    [DependsOn(
        typeof(ErpDomainModule),
        typeof(ErpApplicationContractsModule),
        typeof(BasicManagementApplicationModule),
        typeof(NotificationManagementApplicationModule),
        typeof(DataDictionaryManagementApplicationModule),
        typeof(ErpFreeSqlModule),
        typeof(AbpBackgroundJobsHangfireModule)
        )]
    public class ErpApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ErpApplicationModule>();
            });
            
        }
    }
}
