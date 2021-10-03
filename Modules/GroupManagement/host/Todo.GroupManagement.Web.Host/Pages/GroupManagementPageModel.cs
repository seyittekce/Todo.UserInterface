using Todo.GroupManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Todo.GroupManagement.Pages
{
    public abstract class GroupManagementPageModel : AbpPageModel
    {
        protected GroupManagementPageModel()
        {
            LocalizationResourceType = typeof(GroupManagementResource);
        }
    }
}