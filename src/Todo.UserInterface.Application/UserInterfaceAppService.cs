using System;
using System.Collections.Generic;
using System.Text;
using Todo.UserInterface.Localization;
using Volo.Abp.Application.Services;

namespace Todo.UserInterface
{
    /* Inherit your application services from this class.
     */
    public abstract class UserInterfaceAppService : ApplicationService
    {
        protected UserInterfaceAppService()
        {
            LocalizationResource = typeof(UserInterfaceResource);
        }
    }
}
