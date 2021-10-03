using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.GroupManagement.Group;
using Todo.TaskManagement.Lists;

namespace Todo.TaskManagement.Web.Pages.TaskManagement.Lists
{
    public class UpdateModel : TaskManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }
        private readonly IGroupAppService _groupAppService;
        public CreateUpdateTdListDto TdList { get; set; }
        public UpdateModel(IGroupAppService groupAppService)
        {
            _groupAppService = groupAppService;
        }

        public async Task OnGetAsync(Guid listId)
        {
           var list =await _groupAppService.GetAsync(listId);
           if (list!=null)
           {
               
           }



        }
    }
}
