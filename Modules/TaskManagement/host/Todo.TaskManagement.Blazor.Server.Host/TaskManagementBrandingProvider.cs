using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Todo.TaskManagement.Blazor.Server.Host
{
    [Dependency(ReplaceServices = true)]
    public class TaskManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TaskManagement";
    }
}
