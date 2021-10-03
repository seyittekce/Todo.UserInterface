using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.GroupManagement.GroupUser;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
namespace Todo.GroupManagement
{
    public class GroupUserAppService : CrudAppService<Entities.GroupUser, GroupUserDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGroupUserDto, CreateUpdateGroupUserDto>, IGroupUserAppService
    {
        private readonly IRepository<Entities.GroupUser> _groupUsers;
        private readonly IRepository<Entities.Group> _group;
        private readonly IIdentityUserRepository _identityUserRepository;
        public GroupUserAppService(IRepository<Entities.GroupUser, Guid> repository, IRepository<Entities.GroupUser> groupUsers, IRepository<Entities.Group> group, IdentityUserManager userManager, IIdentityUserRepository identityUserRepository) : base(repository)
        {
            _groupUsers = groupUsers;
            _group = group;
            _identityUserRepository = identityUserRepository;
        }
        public async Task AddUsersToGroup(Guid groupId, Guid[] userId)
        {
            await _groupUsers.DeleteManyAsync(await _groupUsers.GetListAsync(x=>x.GroupId==groupId));
            await _groupUsers.InsertManyAsync(userId.Select(x => new Entities.GroupUser { UserId = x, GroupId = groupId }));
        }
    }
}
