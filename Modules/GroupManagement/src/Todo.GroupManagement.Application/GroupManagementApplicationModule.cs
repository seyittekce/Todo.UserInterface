using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Todo.GroupManagement.Group;

namespace Todo.GroupManagement
{
    [DependsOn(
        typeof(GroupManagementDomainModule),
        typeof(GroupManagementApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class GroupManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<GroupManagementApplicationModule>();
            context.Services.AddTransient<IGroupAppService, GroupAppService>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<GroupManagementApplicationModule>(validate: true);
            });
        }
    }
}
