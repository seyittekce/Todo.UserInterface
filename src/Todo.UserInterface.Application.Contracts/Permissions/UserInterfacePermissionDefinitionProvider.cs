using Todo.UserInterface.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Todo.UserInterface.Permissions
{
    public class UserInterfacePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(UserInterfacePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(UserInterfacePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UserInterfaceResource>(name);
        }
    }
}
