using Todo.UserInterface.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Todo.UserInterface.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class UserInterfacePageModel : AbpPageModel
    {
        protected UserInterfacePageModel()
        {
            LocalizationResourceType = typeof(UserInterfaceResource);
        }
    }
}