using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Todo.GroupManagement
{
    [DependsOn(
        typeof(GroupManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class GroupManagementApplicationContractsModule : AbpModule
    {

    }
}
