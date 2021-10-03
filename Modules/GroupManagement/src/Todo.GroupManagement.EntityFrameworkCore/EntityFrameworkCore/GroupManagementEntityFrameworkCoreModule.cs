using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Todo.GroupManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(GroupManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class GroupManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<GroupManagementDbContext>(options =>
            {
                options.AddDefaultRepositories<IGroupManagementDbContext>();
            });
        }
    }
}