using System;
using helloWorld.DBContex;
using helloWorld.Models;

namespace helloWorld.Repositories
{
    public class ObjectiveReposistory : IObjectiveReposistory
    {
        private readonly AppDbContex _appDbContext;

        public ObjectiveReposistory(AppDbContex appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public void addSkills(List<Skill> skills)
        {
            //_appDbContext.
        }
    }
}

