using Todo.GroupManagement;
using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Todo.TaskManagement
{
    [DependsOn(
        typeof(TaskManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule),
        typeof(GroupManagementApplicationContractsModule)
        )]
    public class TaskManagementApplicationContractsModule : AbpModule
    {

    }
}
