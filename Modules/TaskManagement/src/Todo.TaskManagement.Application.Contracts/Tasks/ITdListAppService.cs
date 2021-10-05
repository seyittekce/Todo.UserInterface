using System;
using System.Threading.Tasks;
using Todo.GroupManagement.Group;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Todo.TaskManagement.Lists
{
    public interface ITdListAppService: ICrudAppService<TdListDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTdTasksDto, CreateUpdateTdTasksDto>
    {
        public Task ChangeOrder(TdListDto tdList);
    }
}