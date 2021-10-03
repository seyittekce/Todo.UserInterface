using System;
using Volo.Abp.Application.Dtos;

namespace Todo.GroupManagement.GroupUser
{
    public class GroupUserListDto : EntityDto<Guid>
    {

        public string UserFullName { get; set; }
        public string GroupName { get; set; }
    }
}
