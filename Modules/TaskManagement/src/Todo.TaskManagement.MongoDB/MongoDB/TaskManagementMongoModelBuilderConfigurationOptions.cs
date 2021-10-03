using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Todo.TaskManagement.MongoDB
{
    public class TaskManagementMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public TaskManagementMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}