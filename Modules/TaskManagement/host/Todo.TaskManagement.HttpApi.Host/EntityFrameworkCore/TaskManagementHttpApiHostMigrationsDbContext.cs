using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Todo.TaskManagement.EntityFrameworkCore
{
    public class TaskManagementHttpApiHostMigrationsDbContext : AbpDbContext<TaskManagementHttpApiHostMigrationsDbContext>
    {
        public TaskManagementHttpApiHostMigrationsDbContext(DbContextOptions<TaskManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureTaskManagement();
        }
    }
}
