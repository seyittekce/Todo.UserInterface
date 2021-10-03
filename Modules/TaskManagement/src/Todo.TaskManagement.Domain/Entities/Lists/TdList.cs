using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Todo.TaskManagement.Entities.Lists
{
    public class TdList:AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }

    }
}