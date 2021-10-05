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
        private readonly ITdListAppService _tdListAppService;

        public UpdateModel(ITdListAppService tdListAppService)
        {
            _tdListAppService = tdListAppService;
        }

        public CreateUpdateTdTasksDto TdList { get; set; }
      

        public async Task OnGetAsync(Guid listId)
        {
           var list =await _tdListAppService.GetAsync(listId);
           if (list!=null)
           {
               this.Id = list.Id;
               this.TdList = ObjectMapper.Map<TdListDto, CreateUpdateTdTasksDto>(list);
           }
        }
    }
}
