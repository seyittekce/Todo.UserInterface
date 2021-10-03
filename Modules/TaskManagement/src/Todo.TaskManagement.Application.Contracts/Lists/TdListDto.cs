using System;
using Volo.Abp.Application.Dtos;

namespace Todo.TaskManagement.Lists
{
    public class TdListDto:EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
    }
}