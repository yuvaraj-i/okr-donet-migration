using System;
using helloWorld.Datas;
using helloWorld.Models;
using Microsoft.EntityFrameworkCore;

namespace helloWorld.Repositories
{
	public interface ISkillSetMappingRepository
	{
        public void addSkillSet(SkillSetMapping skillSet);
        public List<Skill> getSkillByUserId(int userId);
        public Skill getUserSkillBySkill(int userId, int skillId);
        public SkillSetMapping getSkillById(int skillSetId);
        public SkillSetMapping getSkillSetById(int skillSetId, int userId);
        void updateSkillSet(SkillSetMapping skillSet);
    }
}

