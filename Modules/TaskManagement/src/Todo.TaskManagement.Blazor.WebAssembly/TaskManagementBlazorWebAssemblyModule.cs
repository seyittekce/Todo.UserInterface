using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Todo.TaskManagement.Blazor.WebAssembly
{
    [DependsOn(
        typeof(TaskManagementBlazorModule),
        typeof(TaskManagementHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class TaskManagementBlazorWebAssemblyModule : AbpModule
    {
        
    }
}