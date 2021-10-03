using Todo.TaskManagement.Localization;
using Volo.Abp.Application.Services;

namespace Todo.TaskManagement
{
    public abstract class TaskManagementAppService : ApplicationService
    {
        protected TaskManagementAppService()
        {
            LocalizationResource = typeof(TaskManagementResource);
            ObjectMapperContext = typeof(TaskManagementApplicationModule);
        }
    }
}
