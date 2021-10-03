using Todo.TaskManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Todo.TaskManagement
{
    public abstract class TaskManagementController : AbpController
    {
        protected TaskManagementController()
        {
            LocalizationResource = typeof(TaskManagementResource);
        }
    }
}
