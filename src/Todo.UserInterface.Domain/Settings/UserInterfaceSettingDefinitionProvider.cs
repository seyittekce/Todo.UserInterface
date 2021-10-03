using Volo.Abp.Settings;

namespace Todo.UserInterface.Settings
{
    public class UserInterfaceSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(UserInterfaceSettings.MySetting1));
        }
    }
}
