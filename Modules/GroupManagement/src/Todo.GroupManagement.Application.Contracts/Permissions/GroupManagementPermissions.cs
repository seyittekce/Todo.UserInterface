using Volo.Abp.Reflection;

namespace Todo.GroupManagement.Permissions
{
    public class GroupManagementPermissions
    {
        public const string GroupName = "GroupManagement";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(GroupManagementPermissions));
        }
    }
}