using System;
using helloWorld.Models;

namespace helloWorld.Services
{
	public interface ISkillService
	{
        public void addSkill(List<Skill> skills, int userId);
        public List<Skill> getUserSkills(int userId);
    }
}

