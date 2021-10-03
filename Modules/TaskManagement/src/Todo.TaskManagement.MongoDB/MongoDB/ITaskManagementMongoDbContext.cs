using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Todo.TaskManagement.MongoDB
{
    [ConnectionStringName(TaskManagementDbProperties.ConnectionStringName)]
    public interface ITaskManagementMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
