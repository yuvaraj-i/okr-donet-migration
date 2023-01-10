using System;
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

        public void addSkills(Skill skills)
        {
            _appDbContext.skills.Add(skills);
        }

        public List<Skill> getSkillByUserId(int userId)
        {
            var userSkill = _appDbContext.skillSetMappings.Where(s => s.User.id == userId).Select(s => s.Skill).ToList();

            return userSkill;
        }
    }
}

