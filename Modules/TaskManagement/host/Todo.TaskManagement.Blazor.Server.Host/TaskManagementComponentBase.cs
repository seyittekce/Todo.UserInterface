using Todo.TaskManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Todo.TaskManagement.Blazor.Server.Host
{
    public abstract class TaskManagementComponentBase : AbpComponentBase
    {
        protected TaskManagementComponentBase()
        {
            LocalizationResource = typeof(TaskManagementResource);
        }
    }
}
