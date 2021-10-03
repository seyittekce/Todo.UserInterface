using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Todo.TaskManagement.MongoDB
{
    [ConnectionStringName(TaskManagementDbProperties.ConnectionStringName)]
    public class TaskManagementMongoDbContext : AbpMongoDbContext, ITaskManagementMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureTaskManagement();
        }
    }
}