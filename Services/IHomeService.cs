using System;
using helloWorld.Models;

namespace helloWorld.Services
{
	public interface IHomeService {

		public string verifyUser(UserRequest userRequest);
        public void createUser(UserModel userRequest);

    }

}

