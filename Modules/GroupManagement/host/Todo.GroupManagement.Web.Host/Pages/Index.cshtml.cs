using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Todo.GroupManagement.Pages
{
    public class IndexModel : GroupManagementPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}