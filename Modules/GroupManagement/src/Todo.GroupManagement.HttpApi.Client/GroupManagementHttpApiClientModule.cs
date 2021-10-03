using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Todo.GroupManagement
{
    [DependsOn(
        typeof(GroupManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class GroupManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "GroupManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(GroupManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
