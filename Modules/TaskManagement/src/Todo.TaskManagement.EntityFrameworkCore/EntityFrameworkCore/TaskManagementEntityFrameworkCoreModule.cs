using Microsoft.Extensions.DependencyInjection;
using Todo.GroupManagement.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Todo.TaskManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(TaskManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(GroupManagementEntityFrameworkCoreModule)
    )]
    public class TaskManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TaskManagementDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}