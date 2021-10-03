using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Todo.GroupManagement.Group;
using Volo.Abp.Identity;
using IdentityUser = Microsoft.AspNetCore.Identity.IdentityUser;

namespace Todo.GroupManagement.Web.Pages.GroupManagement.Group
{
    public class CreateModel : GroupManagementPageModel
    {
        [BindProperty]
        public CreateUpdateGroupDto Group { get; set; } = new();
        [BindProperty]
        public string[] Users { get; set; }
        private readonly IGroupAppService _groupAppService;
        public  CreateModel(IGroupAppService groupAppService )
        {
            _groupAppService = groupAppService;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _groupAppService.CreateAsync(Group);
            return NoContent();
        }
    }
}
