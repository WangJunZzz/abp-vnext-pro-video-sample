namespace MyLion.Erp
{
    /* Inherit your application services from this class.
     */
    public abstract class ErpAppService : ApplicationService
    {
        protected ErpAppService()
        {
            LocalizationResource = typeof(ErpResource);
        }
    }
}
