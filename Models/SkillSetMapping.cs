using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using helloWorld.Models;

namespace helloWorld.Datas
{
	public class SkillSetMapping
	{
        [Key]
        public int Id { get; set; }
        public Skill Skill { get; set; }
        public User User { get; set; }
        public int rating { get; set; }
        public bool isDeleted { get; set; }

    }
}

