using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Todo.TaskManagement.Web.Menus
{
    public class TaskManagementMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(TaskManagementMenus.Prefix, displayName: "TaskManagement", "~/TaskManagement", icon: "fa fa-globe"));

            return Task.CompletedTask;
        }
    }
}