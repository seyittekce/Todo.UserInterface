using Todo.GroupManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Todo.GroupManagement
{
    public abstract class GroupManagementController : AbpController
    {
        protected GroupManagementController()
        {
            LocalizationResource = typeof(GroupManagementResource);
        }
    }
}
