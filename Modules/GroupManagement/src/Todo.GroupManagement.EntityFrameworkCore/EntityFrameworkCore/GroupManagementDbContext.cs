using Microsoft.EntityFrameworkCore;
using Todo.GroupManagement.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Todo.GroupManagement.EntityFrameworkCore
{
    [ConnectionStringName(GroupManagementDbProperties.ConnectionStringName)]
    public class GroupManagementDbContext : AbpDbContext<GroupManagementDbContext>, IGroupManagementDbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }

        public GroupManagementDbContext(DbContextOptions<GroupManagementDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureGroupManagement();
        }
    }
}