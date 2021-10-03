using Todo.GroupManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Todo.GroupManagement.Permissions
{
    public class GroupManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(GroupManagementPermissions.GroupName, L("Permission:GroupManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<GroupManagementResource>(name);
        }
    }
}