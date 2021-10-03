using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Todo.GroupManagement
{
    [Dependency(ReplaceServices = true)]
    public class GroupManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "GroupManagement";
    }
}
