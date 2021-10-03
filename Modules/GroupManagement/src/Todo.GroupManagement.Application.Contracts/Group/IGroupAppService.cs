using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Todo.GroupManagement.Group
{
    public interface IGroupAppService : ICrudAppService<GroupDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGroupDto, CreateUpdateGroupDto>
    {

    }
}
