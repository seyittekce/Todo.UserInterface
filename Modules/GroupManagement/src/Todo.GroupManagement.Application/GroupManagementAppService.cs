using Todo.GroupManagement.Localization;
using Volo.Abp.Application.Services;

namespace Todo.GroupManagement
{
    public abstract class GroupManagementAppService : ApplicationService
    {
        protected GroupManagementAppService()
        {
            LocalizationResource = typeof(GroupManagementResource);
            ObjectMapperContext = typeof(GroupManagementApplicationModule);
        }
    }
}
