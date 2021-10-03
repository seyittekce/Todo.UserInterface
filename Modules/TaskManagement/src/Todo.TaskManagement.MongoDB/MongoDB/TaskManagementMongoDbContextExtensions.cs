using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Todo.TaskManagement.MongoDB
{
    public static class TaskManagementMongoDbContextExtensions
    {
        public static void ConfigureTaskManagement(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new TaskManagementMongoModelBuilderConfigurationOptions(
                TaskManagementDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}