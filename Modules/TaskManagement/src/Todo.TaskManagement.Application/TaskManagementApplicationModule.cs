using Microsoft.Extensions.DependencyInjection;
using Todo.GroupManagement;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Todo.TaskManagement
{
    [DependsOn(
        typeof(TaskManagementDomainModule),
        typeof(TaskManagementApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(GroupManagementApplicationModule)
        )]
    public class TaskManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<TaskManagementApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<TaskManagementApplicationModule>(validate: true);
            });
        }
    }
}
