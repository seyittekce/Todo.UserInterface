using Volo.Abp.Modularity;

namespace Todo.TaskManagement
{
    [DependsOn(
        typeof(TaskManagementApplicationModule),
        typeof(TaskManagementDomainTestModule)
        )]
    public class TaskManagementApplicationTestModule : AbpModule
    {

    }
}
