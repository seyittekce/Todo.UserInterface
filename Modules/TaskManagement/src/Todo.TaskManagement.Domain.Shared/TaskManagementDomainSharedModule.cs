using Todo.GroupManagement;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Todo.TaskManagement.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Todo.TaskManagement
{
    [DependsOn(
        typeof(GroupManagementDomainSharedModule),
        typeof(AbpValidationModule)
    )]
    public class TaskManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<TaskManagementDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<TaskManagementResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/TaskManagement");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("TaskManagement", typeof(TaskManagementResource));
            });
        }
    }
}
