using Microsoft.EntityFrameworkCore;
using Todo.TaskManagement.Entities.Lists;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Todo.TaskManagement.EntityFrameworkCore
{
    [ConnectionStringName(TaskManagementDbProperties.ConnectionStringName)]
    public interface ITaskManagementDbContext : IEfCoreDbContext
    {
        DbSet<TdList> TdList { get; set; }
    }
}