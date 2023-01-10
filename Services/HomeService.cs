using System;
using helloWorld.Models;
using helloWorld.Repositories;
using helloWorld.Utils;

namespace helloWorld.Services
{
	public class HomeService : IHomeService
    {
        private readonly IJwtTokenUtils _jwtTokenUtils;
        private readonly IUserRepository _userRepository;

        public HomeService(IJwtTokenUtils jwtTokenUtils, IUserRepository userRepository)
		{
            _jwtTokenUtils = jwtTokenUtils;
            _userRepository = userRepository;

        }

        public string verifyUser(UserRequest userRequest)
        {
            User user = _userRepository.getUserByEmail(userRequest.email);

            if(user == null)
            {
                throw new Exception("User with given email not found");
            }

            if(user.email != userRequest.email)
            {
                throw new Exception("invaild credentials");
            }

            return _jwtTokenUtils.createToken(user);
        }

        public void createUser(UserModel userRequest)
        {
            User user = _userRepository.getUserByEmail(userRequest.email);

            if(user != null)
            {
                throw new Exception("User with given email already exist");
            }

            var userModel = new User();
            userModel.email = userRequest.email;
            userModel.name = userRequest.name;
            userModel.password = userRequest.password;

            _userRepository.addUser(userModel);

        }
    }
}

