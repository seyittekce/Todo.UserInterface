using System.ComponentModel.DataAnnotations;

namespace Todo.TaskManagement.Lists
{
    public class CreateUpdateTdListDto
    {
        [Required]
        [Display(Name = "Ad")]
        public string Name { get; set; }
   
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Ikon")]
        public string Icon { get; set; }
    }
}