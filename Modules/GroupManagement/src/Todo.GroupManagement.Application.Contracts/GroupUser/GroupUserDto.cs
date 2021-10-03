using System;
using Volo.Abp.Application.Dtos;

namespace Todo.GroupManagement.GroupUser
{
    public class GroupUserDto : EntityDto<Guid>
    {
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
    }
}
