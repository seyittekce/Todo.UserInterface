using System.Threading.Tasks;

namespace Todo.UserInterface.Data
{
    public interface IUserInterfaceDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
