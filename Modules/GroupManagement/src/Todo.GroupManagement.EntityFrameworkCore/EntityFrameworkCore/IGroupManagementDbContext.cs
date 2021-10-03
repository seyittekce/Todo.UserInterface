using Microsoft.EntityFrameworkCore;
using Todo.GroupManagement.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Todo.GroupManagement.EntityFrameworkCore
{
    [ConnectionStringName(GroupManagementDbProperties.ConnectionStringName)]
    public interface IGroupManagementDbContext : IEfCoreDbContext
    {
         DbSet<Group> Groups { get; set; }
         DbSet<GroupUser> GroupUsers { get; set; }
    }
}