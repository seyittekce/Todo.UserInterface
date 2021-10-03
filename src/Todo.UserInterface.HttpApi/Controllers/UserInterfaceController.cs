using Todo.UserInterface.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Todo.UserInterface.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class UserInterfaceController : AbpController
    {
        protected UserInterfaceController()
        {
            LocalizationResource = typeof(UserInterfaceResource);
        }
    }
}