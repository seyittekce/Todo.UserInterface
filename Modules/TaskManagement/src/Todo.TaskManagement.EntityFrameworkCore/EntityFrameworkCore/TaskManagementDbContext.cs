using Microsoft.EntityFrameworkCore;
using Todo.TaskManagement.Entities.Lists;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Todo.TaskManagement.EntityFrameworkCore
{
    [ConnectionStringName(TaskManagementDbProperties.ConnectionStringName)]
    public class TaskManagementDbContext : AbpDbContext<TaskManagementDbContext>, ITaskManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DbSet<TdList> TdList { get; set; }
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureTaskManagement();
        }
    }
}