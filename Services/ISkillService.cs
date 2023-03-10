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
        void addUserPoc(AccomplishmentRequest accomplishmentRequest, int userId);
        void editUserPoc(EditAccomplishmentRequest accomplishmentRequest, int userId);
        void deleteUserPoc(int id, int userId);
        List<AccomplishmentModel> getUserPoc(int userId);
    }
}

