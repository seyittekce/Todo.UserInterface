using Volo.Abp.Modularity;

namespace Todo.UserInterface
{
    [DependsOn(
        typeof(UserInterfaceApplicationModule),
        typeof(UserInterfaceDomainTestModule)
        )]
    public class UserInterfaceApplicationTestModule : AbpModule
    {

    }
}