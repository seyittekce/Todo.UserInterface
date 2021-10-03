using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Todo.GroupManagement.Group;
using Todo.GroupManagement.GroupUser;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Alert;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Card;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Identity;
namespace Todo.GroupManagement.Web.Pages.GroupManagement.Group
{
    public class AddUserToGroupModel : GroupManagementPageModel
    {
        [BindProperty]
        public DetailModel DetailedModel { get; set; }
        public CreateUpdateGroupDto Group { get; set; }
        public List<SelectListItem> UserSelectListItems { get; set; }
        [BindProperty]
        public string[] Users { get; set; }
        private readonly IGroupAppService _groupAppService;
        private readonly IGroupUserAppService _groupUserAppService;
        public  AddUserToGroupModel(IGroupUserAppService groupUserAppService, IGroupAppService groupAppService, IIdentityUserRepository identityUserRepository)
        {
            _groupUserAppService = groupUserAppService;
            _groupAppService = groupAppService;
            UserSelectListItems = identityUserRepository.GetListAsync().Result.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name + " " + x.Surname}).ToList();
        }
        public async void OnGetAsync(Guid groupId)
        {
            DetailedModel = new()
            {
                GroupId = groupId
            };
            Group = ObjectMapper.Map<GroupDto, CreateUpdateGroupDto>(await _groupAppService.GetAsync(groupId));
           
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _groupUserAppService.AddUsersToGroup(this.DetailedModel.GroupId, this.Users.Select(x => new Guid(x)).ToArray());
            return NoContent();
        }
        public class DetailModel
        {
            [HiddenInput] public Guid GroupId { get; set; }
        }
    }
}
