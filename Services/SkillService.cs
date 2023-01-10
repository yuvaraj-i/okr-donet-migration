using System;
using helloWorld.Models;
using helloWorld.Repositories;

namespace helloWorld.Services
{
	public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;

        public SkillService(ISkillRepository skillRepository)
		{
            _skillRepository = skillRepository;

        }

        public void addSkill(List<Skill> skills, int userId)
        {
            
        }

        public List<Skill> getUserSkills(int userId)
        {
           return _skillRepository.getSkillByUserId(userId);
        }
    }
}

