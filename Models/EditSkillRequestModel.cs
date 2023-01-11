using System;
using System.ComponentModel.DataAnnotations;

namespace helloWorld.Models
{
	public class EditSkillRequestModel
	{
        public int skillId { get; set; }
        public int skillSetId { get; set; }
        public int rating { get; set; }
        public bool isDeleted { get; set; } = false;
    }
	
}

