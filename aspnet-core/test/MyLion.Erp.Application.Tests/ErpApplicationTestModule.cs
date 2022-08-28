using Volo.Abp.Modularity;

namespace MyLion.Erp
{
    [DependsOn(
        typeof(ErpApplicationModule),
        typeof(ErpDomainTestModule)
        )]
    public class ErpApplicationTestModule : AbpModule
    {

    }
}