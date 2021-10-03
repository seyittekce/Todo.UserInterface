using Todo.UserInterface.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Todo.UserInterface.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(UserInterfaceEntityFrameworkCoreModule),
        typeof(UserInterfaceApplicationContractsModule)
        )]
    public class UserInterfaceDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
