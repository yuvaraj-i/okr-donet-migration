using System;
using helloWorld.Models;

namespace helloWorld.Services
{
	public interface ISkillService
	{
        public void addSkill(List<SkillRequestModel> skills, int userId);
        public List<Skill> getUserSkills(int userId);
        public void editUserSkill(EditSkillRequestModel editSkillRequestModel, int userId);
        void deleteUserSkill(int skillId, int userId);
    }
}

