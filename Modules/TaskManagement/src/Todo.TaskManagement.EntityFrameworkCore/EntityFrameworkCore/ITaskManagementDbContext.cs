﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Todo.TaskManagement.EntityFrameworkCore
{
    [ConnectionStringName(TaskManagementDbProperties.ConnectionStringName)]
    public interface ITaskManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}