using System;
using helloWorld.Datas;
using helloWorld.DBContex;
using helloWorld.Models;

namespace helloWorld.Repositories
{
	public class SkillRepository : ISkillRepository
    {
        private readonly AppDbContex _appDbContext;

        public SkillRepository(AppDbContex appDbContext)
		{
            _appDbContext = appDbContext;
		}

        public void addSkill(Skill skills)
        {
            _appDbContext.skills.Add(skills);
            _appDbContext.SaveChanges();
        }

        public Skill getSkill(string skillDescription)
        {
            return _appDbContext.skills.Where(s => s.skillDescription == skillDescription).First();
        }

    }
}

