using Lion.AbpPro.BasicManagement.EntityFrameworkCore;
using Lion.AbpPro.DataDictionaryManagement;
using Lion.AbpPro.DataDictionaryManagement.DataDictionaries.Aggregates;
using Lion.AbpPro.DataDictionaryManagement.EntityFrameworkCore;
using Lion.AbpPro.NotificationManagement;
using Lion.AbpPro.NotificationManagement.EntityFrameworkCore;
using Lion.AbpPro.NotificationManagement.Notifications.Aggregates;

namespace MyLion.Erp.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See ErpMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class ErpDbContext : AbpDbContext<ErpDbContext>, IErpDbContext,
        IBasicManagementDbContext,
        INotificationManagementDbContext,
        IDataDictionaryManagementDbContext
    {
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        public DbSet<FeatureValue> FeatureValues { get; set; }
        public DbSet<PermissionGrant> PermissionGrants { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }
        public DbSet<BackgroundJobRecord> BackgroundJobs { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<DataDictionary> DataDictionary { get; set; }
        
        public DbSet<Blog> Blogs { get; set; }
        
        public ErpDbContext(DbContextOptions<ErpDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            NotificationManagementDbProperties.DbTablePrefix = "Abp";
            DataDictionaryManagementDbProperties.DbTablePrefix = "Abp";
            
            base.OnModelCreating(builder);


            builder.ConfigureErp();

            // ????????????
            builder.ConfigureBasicManagement();


            // ????????????
            builder.ConfigureNotificationManagement();
            
            //????????????
            builder.ConfigureDataDictionaryManagement();
        }


    
    }
}