using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Todo.UserInterface.Data
{
    /* This is used if database provider does't define
     * IUserInterfaceDbSchemaMigrator implementation.
     */
    public class NullUserInterfaceDbSchemaMigrator : IUserInterfaceDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}