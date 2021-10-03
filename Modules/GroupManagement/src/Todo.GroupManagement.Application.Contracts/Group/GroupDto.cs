using System;
using Volo.Abp.Application.Dtos;

namespace Todo.GroupManagement.Group
{
    public class GroupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
