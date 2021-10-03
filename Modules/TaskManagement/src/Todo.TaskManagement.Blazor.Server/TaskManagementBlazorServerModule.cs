using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Todo.TaskManagement.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(TaskManagementBlazorModule)
        )]
    public class TaskManagementBlazorServerModule : AbpModule
    {
        
    }
}