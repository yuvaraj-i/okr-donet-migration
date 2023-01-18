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
            try
            {
                return _DbContext.skillSetMappings.Find(skillSetId);
            }

            catch
            {
                throw;
            }
        }

        public List<Skill> getSkillByUserId(int userId)
        {
            try
            {
                var userSkill = _DbContext.skillSetMappings.Where(s => s.User.id == userId).Select(s => s.Skill).ToList();

                return userSkill;
            }
            catch
            {
                throw;
            }
        }

        public SkillSetMapping getSkillSetById(int skillSetId, int userId)
        {
            try
            {
                var userSkillSet = _DbContext.skillSetMappings.Where(s => s.User.id == userId && s.Id == skillSetId).FirstOrDefault();

                return userSkillSet;
            }

            catch
            {
                throw;
            }

        }

        public Skill getUserSkillBySkill(int userId, int skillId)
        {
            try
            {
                var userSkill = _DbContext.skillSetMappings.Where(s => s.User.id == userId && s.Id == skillId).Select(s => s.Skill).FirstOrDefault();

                return userSkill;
            }

            catch
            {
                throw;
            }

        }

        public void updateSkillSet(SkillSetMapping skillSet)
        {
            try
            {
                _DbContext.skillSetMappings.Update(skillSet);
                _DbContext.SaveChanges();
            }

            catch
            {
                throw;
            }
        }
    }
}

