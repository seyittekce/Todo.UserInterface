using Todo.GroupManagement;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Todo.TaskManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(TaskManagementDomainSharedModule),
        typeof(GroupManagementDomainModule)
    )]
    public class TaskManagementDomainModule : AbpModule
    {

    }
}
