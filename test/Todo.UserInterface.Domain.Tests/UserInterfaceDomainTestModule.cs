using Todo.UserInterface.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Todo.UserInterface
{
    [DependsOn(
        typeof(UserInterfaceEntityFrameworkCoreTestModule)
        )]
    public class UserInterfaceDomainTestModule : AbpModule
    {

    }
}