using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Todo.GroupManagement.EntityFrameworkCore
{
    public class GroupManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public GroupManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}