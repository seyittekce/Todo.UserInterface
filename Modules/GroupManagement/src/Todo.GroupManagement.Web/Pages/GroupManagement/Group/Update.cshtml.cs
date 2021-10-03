using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.GroupManagement.Group;
namespace Todo.GroupManagement.Web.Pages.GroupManagement.Group
{
    public class UpdateModel : GroupManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]

        public Guid Id { get; set; }
        [BindProperty]
        public CreateUpdateGroupDto Group { get; set; }
        private readonly IGroupAppService _groupAppService;
        public UpdateModel(IGroupAppService groupAppService)
        {
            _groupAppService = groupAppService;
        }
        public async void OnGetAsync(Guid groupId)
        {
            this.Id = groupId;
            Group = ObjectMapper.Map<GroupDto, CreateUpdateGroupDto>(await _groupAppService.GetAsync(groupId));
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _groupAppService.UpdateAsync(Id, Group);
            return NoContent();
        }
    }
}
