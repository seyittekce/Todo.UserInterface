using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Todo.GroupManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(GroupManagementDomainSharedModule)
    )]
    public class GroupManagementDomainModule : AbpModule
    {

    }
}
