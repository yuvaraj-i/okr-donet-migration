using System;
using helloWorld.Datas;
using helloWorld.DBContex;
using helloWorld.Models;
using helloWorld.Repositories;

namespace helloWorld.Services
{
	public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        private readonly IUserRepository _userRepository;
        private readonly ISkillSetMappingRepository _skillSetMappingRepository;

        public SkillService(ISkillRepository skillRepository, IUserRepository userRepository, ISkillSetMappingRepository skillsetMappingRepository)
		{
            _skillRepository = skillRepository;
            _userRepository = userRepository;
            _skillSetMappingRepository = skillsetMappingRepository;
        }

        public void addSkill(List<SkillRequestModel> skills, int userId)
        {
            foreach (SkillRequestModel s in skills)
            {
                var currentSkill = _skillRepository.getSkill(s.skillDescription);

                var userSkill = new Skill();
                userSkill.skillDescription = s.skillDescription;
                
                if (currentSkill == null)
                {
                    _skillRepository.addSkill(userSkill);
                }

                var skill = _skillRepository.getSkill(s.skillDescription);
                var user = _userRepository.getUserById(userId);

                var skillSet = new SkillSetMapping();
                skillSet.Skill = userSkill;
                skillSet.User = user;
                skillSet.rating = s.rating;

                _skillSetMappingRepository.addSkillSet(skillSet);
            }
        }

        public List<Skill> getUserSkills(int userId)
        {
           return _skillSetMappingRepository.getSkillByUserId(userId);
        }

        public void editUserSkill(EditSkillRequestModel editSkillRequestModel, int userId)
        {
            var skill = _skillSetMappingRepository.getUserSkillBySkill(editSkillRequestModel.skillSetId, userId);

            if(skill == null)
            {
                throw new Exception($"given skill {editSkillRequestModel.skillId} not found for this {userId}");
            }

            var skillSet = _skillSetMappingRepository.getSkillSetById(userId, editSkillRequestModel.skillId);

            skillSet.rating = editSkillRequestModel.rating;

            _skillSetMappingRepository.updateSkillSet(skillSet);
        }

        public void deleteUserSkill(int skillId, int userId)
        {
            var skillSet = _skillSetMappingRepository.getSkillSetById(userId, skillId);

            if(skillSet == null)
            {
                throw new Exception("given skill not found for this user");
            }

            if(skillSet.isDeleted)
            {
                throw new Exception("given skill is already deleted");
            }


            skillSet.isDeleted = true;

            _skillSetMappingRepository.updateSkillSet(skillSet);
        }
    }
}

