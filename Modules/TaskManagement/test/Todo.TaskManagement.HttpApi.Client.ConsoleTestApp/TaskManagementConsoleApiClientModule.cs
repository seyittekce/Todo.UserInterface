using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Todo.TaskManagement
{
    [DependsOn(
        typeof(TaskManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class TaskManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
