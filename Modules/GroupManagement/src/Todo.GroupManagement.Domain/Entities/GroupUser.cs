using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace Todo.GroupManagement.Entities
{
    public class GroupUser : AuditedAggregateRoot<Guid>
    {

        public Guid GroupId{ get; set; }
        public Guid UserId{ get; set; }
   

    }
}
