using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Todo.TaskManagement.Pages
{
    public class IndexModel : TaskManagementPageModel
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