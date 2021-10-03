using System;
using Todo.GroupManagement.Group;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Todo.GroupManagement
{
    public class GroupAppService : CrudAppService<Entities.Group, GroupDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGroupDto, CreateUpdateGroupDto>, IGroupAppService
    {

        public GroupAppService(IRepository<Entities.Group, Guid> repository) : base(repository)
        {
        }
    }
}
