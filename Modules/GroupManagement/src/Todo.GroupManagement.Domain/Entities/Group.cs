using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Todo.GroupManagement.Entities
{
    public class Group : AuditedAggregateRoot<Guid>
    {

        public string Name { get; set; }
        public string Description { get; set; }

    }
}
