using System;
using System.Net;
using System.Security;
using Volo.Abp.Domain.Entities.Auditing;

namespace Todo.TaskManagement.Entities.Tasks
{
    public class TdTask:AuditedAggregateRoot<Guid>
    {
        public Guid ListId { get; set; }
        public Guid ParentId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public Status Status { get; set; } = Status.InProgress;

    }
}