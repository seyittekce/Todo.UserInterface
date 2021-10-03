using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Todo.UserInterface.Web
{
    [Dependency(ReplaceServices = true)]
    public class UserInterfaceBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "UserInterface";
    }
}
