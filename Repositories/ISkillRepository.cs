using System;
using helloWorld.Models;

namespace helloWorld.Repositories
{
	public interface ISkillRepository
	{
        public void addSkill(Skill skills);
        public Skill getSkill(string skillDescription);
    }
}

