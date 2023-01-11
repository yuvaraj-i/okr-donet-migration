using System;
using helloWorld.Datas;
using helloWorld.DBContex;
using helloWorld.Models;

namespace helloWorld.Repositories
{
	public class SkillSetMappingRepository : ISkillSetMappingRepository
    {
        private readonly AppDbContex _DbContext;

        public SkillSetMappingRepository(AppDbContex appDbContex)
		{
			_DbContext = appDbContex;

        }

		public void addSkillSet(SkillSetMapping skillSet)
		{
			_DbContext.skillSetMappings.Add(skillSet);
			_DbContext.SaveChanges();
		}

        public SkillSetMapping getSkillById(int skillSetId)
        {
           return _DbContext.skillSetMappings.Find(skillSetId);
        }

        public List<Skill> getSkillByUserId(int userId)
        {
            var userSkill = _DbContext.skillSetMappings.Where(s => s.User.id == userId).Select(s => s.Skill).ToList();

            return userSkill;
        }

        public SkillSetMapping getSkillSetById(int skillSetId, int userId)
        {
            var userSkillSet = _DbContext.skillSetMappings.Where(s => s.User.id == userId && s.Id == skillSetId).First();

            return userSkillSet;
        }

        public Skill getUserSkillBySkill(int userId, int skillId)
        {
            var userSkill = _DbContext.skillSetMappings.Where(s => s.User.id == userId && s.Id == skillId).Select(s => s.Skill).First();

            return userSkill;
        }

        public void updateSkillSet(SkillSetMapping skillSet)
        {
            _DbContext.skillSetMappings.Update(skillSet);
            _DbContext.SaveChanges();
        }
    }
}

