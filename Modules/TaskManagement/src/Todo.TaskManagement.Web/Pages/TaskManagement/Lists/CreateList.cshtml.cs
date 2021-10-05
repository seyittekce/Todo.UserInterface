using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Todo.TaskManagement.Lists;
namespace Todo.TaskManagement.Web.Pages.TaskManagement.Lists
{
    public class CreateListModel : TaskManagementPageModel
    {
        [BindProperty]
        public CreateUpdateTdTasksDto TdList { get; set; } = new();
        private readonly ITdListAppService _tdListAppService;
        public CreateListModel(ITdListAppService tdListAppService)
        {
            _tdListAppService = tdListAppService;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _tdListAppService.CreateAsync(TdList);
            return NoContent();
        }
    }
}
