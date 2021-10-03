﻿using Todo.TaskManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Todo.TaskManagement.Permissions
{
    public class TaskManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TaskManagementPermissions.GroupName, L("Permission:TaskManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TaskManagementResource>(name);
        }
    }
}