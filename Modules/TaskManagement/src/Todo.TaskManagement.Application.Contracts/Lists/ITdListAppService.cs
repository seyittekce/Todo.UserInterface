using System;
using System.Threading.Tasks;
using Todo.GroupManagement.Group;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Todo.TaskManagement.Lists
{
    public interface ITdListAppService: ICrudAppService<TdListDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTdListDto, CreateUpdateTdListDto>
    {
        public Task ChangeOrder(TdListDto tdList);
    }
}