using System.ComponentModel.DataAnnotations;

namespace Todo.TaskManagement.Lists
{
    public class CreateUpdateTdTasksDto
    {
        [Required]
        [Display(Name = "Ad")]
        public string Name { get; set; }
   
        [Display(Name = "Açıklama")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Ikon")]
        public string Icon { get; set; }
    }
}