using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Todo.GroupManagement.Web.Menus
{
    public class GroupManagementMenuContributor : IMenuContributor
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
            context.Menu.AddItem(
                new ApplicationMenuItem(
                    "Groups",
                    "Gruplar",
                    icon: "fas fa-users"
                ).AddItem(
                    new ApplicationMenuItem(
                        "Groups.Group",
                        "Gruplar",
                        url: "/GroupManagement/Group"
                        )
                )
            );

            return Task.CompletedTask;
        }
    }
}