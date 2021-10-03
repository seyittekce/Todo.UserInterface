using System;
using System.ComponentModel.DataAnnotations;
namespace Todo.GroupManagement.GroupUser
{
    public class CreateUpdateGroupUserDto
    {
        [Required]
        public Guid GroupId { get; set; }
        [Required]
        public Guid UserId { get; set; }
    }
}
