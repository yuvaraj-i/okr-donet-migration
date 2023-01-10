using System;
using helloWorld.Models;

namespace helloWorld.Repositories
{
	public interface ISkillRepository
	{
        public void addSkills(Skill skills);
        public List<Skill> getSkillByUserId(int userId);
    }
}

