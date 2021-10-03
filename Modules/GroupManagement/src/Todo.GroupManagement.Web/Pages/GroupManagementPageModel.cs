using Todo.GroupManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Todo.GroupManagement.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class GroupManagementPageModel : AbpPageModel
    {
        protected GroupManagementPageModel()
        {
            LocalizationResourceType = typeof(GroupManagementResource);
            ObjectMapperContext = typeof(GroupManagementWebModule);
        }
    }
}