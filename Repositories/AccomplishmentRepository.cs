using System;
using helloWorld.DBContex;
using helloWorld.Migrations;
using helloWorld.Models;

namespace helloWorld.Repositories
{
	public class AccomplishmentRepository : IAccomplishmentRepository
	{
        private readonly AppDbContex _DbContext;

        public AccomplishmentRepository(AppDbContex DbContext)
		{
            _DbContext = DbContext;

        }

        public void addUserPoc(AccomplishmentModel accomplishmentModel)
        {
            _DbContext.accomplishments.Add(accomplishmentModel);
            _DbContext.SaveChanges();
        }

        public void deleteUserPocById(AccomplishmentModel accomplishmentModel)
        {
            _DbContext.accomplishments.Remove(accomplishmentModel);
        }

        public List<AccomplishmentModel> getUserPocs(int id)
        {
            return _DbContext.accomplishments.Where(s => s.User.id == id).ToList();
        }

        public AccomplishmentModel getUserPocById(int id)
        {
           return _DbContext.accomplishments.Find(id);
        }

        public void updateUserPoc(AccomplishmentModel accomplishmentModel)
        {
            _DbContext.accomplishments.Update(accomplishmentModel);
            _DbContext.SaveChanges();
        }

    }
}

