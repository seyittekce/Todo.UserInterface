using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Todo.TaskManagement.EntityFrameworkCore
{
    public static class TaskManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureTaskManagement(
            this ModelBuilder builder,
            Action<TaskManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new TaskManagementModelBuilderConfigurationOptions(
                TaskManagementDbProperties.DbTablePrefix,
                TaskManagementDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}