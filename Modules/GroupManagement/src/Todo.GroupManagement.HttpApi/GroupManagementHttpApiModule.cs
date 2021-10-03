using Localization.Resources.AbpUi;
using Todo.GroupManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Todo.GroupManagement
{
    [DependsOn(
        typeof(GroupManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class GroupManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(GroupManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<GroupManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
