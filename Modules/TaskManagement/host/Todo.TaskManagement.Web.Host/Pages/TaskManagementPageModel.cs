using Todo.TaskManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Todo.TaskManagement.Pages
{
    public abstract class TaskManagementPageModel : AbpPageModel
    {
        protected TaskManagementPageModel()
        {
            LocalizationResourceType = typeof(TaskManagementResource);
        }
    }
}