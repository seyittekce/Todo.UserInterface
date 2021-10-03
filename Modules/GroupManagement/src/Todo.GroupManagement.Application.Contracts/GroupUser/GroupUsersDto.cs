using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Todo.GroupManagement.GroupUser
{
    public class GroupUsersDto : EntityDto<Guid>
    {
        public Guid GroupId { get; set; }
        public List<Guid> UserIds { get; set; }
    }
}
