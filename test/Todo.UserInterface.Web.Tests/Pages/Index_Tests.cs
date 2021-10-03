using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Todo.UserInterface.Pages
{
    public class Index_Tests : UserInterfaceWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
