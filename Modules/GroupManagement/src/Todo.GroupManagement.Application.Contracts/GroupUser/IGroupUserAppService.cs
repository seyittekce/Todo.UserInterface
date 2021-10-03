using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Todo.GroupManagement.GroupUser
{
    public interface IGroupUserAppService : ICrudAppService<GroupUserDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGroupUserDto, CreateUpdateGroupUserDto>
    {
        public Task AddUsersToGroup(Guid groupId, Guid[] userId);
    }
}
