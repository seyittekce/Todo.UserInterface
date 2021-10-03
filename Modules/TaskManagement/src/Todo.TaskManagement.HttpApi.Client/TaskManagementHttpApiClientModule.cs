using Microsoft.Extensions.DependencyInjection;
using Todo.GroupManagement;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Todo.TaskManagement
{
    [DependsOn(
        typeof(TaskManagementApplicationContractsModule),
        typeof(AbpHttpClientModule),
        typeof(GroupManagementHttpApiClientModule))]
    public class TaskManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "TaskManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(TaskManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
