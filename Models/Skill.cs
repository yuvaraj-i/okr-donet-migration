using System;
using System.ComponentModel.DataAnnotations;

namespace helloWorld.Models
{
	public class Skill
	{
        [Key]
        public int skillId { get; set; }
        [Required]
        [StringLength(1000)]
        public String? skillDescription { get; set; }
        public bool isDeleted { get; set; }
    }
}

