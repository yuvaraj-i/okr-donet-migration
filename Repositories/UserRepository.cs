using System;
using System.Linq;
using helloWorld.DBContex;
using helloWorld.Models;

namespace helloWorld.Repositories
{
	public class UserRepository : IUserRepository
    {
        private readonly AppDbContex _DbContext;

        public UserRepository(AppDbContex appDbContex)
		{
            _DbContext = appDbContex;

        }

        public void addUser(User user)
        { 
            _DbContext.users.Add(user);
            _DbContext.SaveChanges();
        }

        public User getUserByEmail(string email)
        {
            return _DbContext.users.Where(s => s.email == email).FirstOrDefault<User>();
        }

        public User getUserById(int id)
        {
            return _DbContext.users.Find(id);
        }
    }
}

