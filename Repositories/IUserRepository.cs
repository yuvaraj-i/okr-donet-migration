using System;
using helloWorld.Models;

namespace helloWorld.Repositories
{
	public interface IUserRepository
	{
		public User getUserByEmail(string email);
        public void addUser(User user);
    }
}

