using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Todo.GroupManagement.EntityFrameworkCore
{
    public class GroupManagementHttpApiHostMigrationsDbContext : AbpDbContext<GroupManagementHttpApiHostMigrationsDbContext>
    {
        public GroupManagementHttpApiHostMigrationsDbContext(DbContextOptions<GroupManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureGroupManagement();
        }
    }
}
