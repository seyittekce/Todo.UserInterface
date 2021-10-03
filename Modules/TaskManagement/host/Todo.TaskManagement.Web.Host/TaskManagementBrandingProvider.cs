using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Todo.TaskManagement
{
    [Dependency(ReplaceServices = true)]
    public class TaskManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TaskManagement";
    }
}
