using System.ComponentModel.DataAnnotations;

namespace Todo.GroupManagement.Group
{
    public class CreateUpdateGroupDto
    {
        [Required]
        [Display(Name = "Grup Adı")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Grup Açıklaması")]
        [StringLength(25)]
        public string Description { get; set; }
    }
}
