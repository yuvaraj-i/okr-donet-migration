using System;
using helloWorld.Interfaces.Reposistory;
using helloWorld.Interfaces.Services;
using helloWorld.Models;

namespace helloWorld.Services
{
	public class ObjectiveService : IObjectiveService
    {
        private readonly IObjectiveReposistory _objectiveReposistory;

        public ObjectiveService(IObjectiveReposistory objectiveReposistory)
		{
            _objectiveReposistory = objectiveReposistory;

        }

        public void addSkill(List<Skill> skills)
        {
            _objectiveReposistory.addSkills(skills);
        }
    }
}

