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
        private readonly ILogger<HomeService> _logger;

        public HomeService(IJwtTokenUtils jwtTokenUtils, IUserRepository userRepository, ILogger<HomeService> logger)
		{
            _jwtTokenUtils = jwtTokenUtils;
            _userRepository = userRepository;
            _logger = logger;

        }

        public string verifyUser(UserRequest userRequest)
        {
            _logger.LogInformation("HomeService verifyUser");
            User user = _userRepository.getUserByEmail(userRequest.email);

            if (user == null)
            {
                _logger.LogError("{@userRequest} not found", userRequest);
                throw new Exception("User with given email not found");
            }

            if (user.email != userRequest.email)
            {
                _logger.LogError("{@userRequest} given email not found", userRequest);
                throw new Exception("invaild credentials");
            }

            return _jwtTokenUtils.createToken(user);

        }

        public void createUser(UserModel userRequest)
        {
            User user = _userRepository.getUserByEmail(userRequest.email);

            if (user != null)
            {
                _logger.LogError("{@userRequest} given not found", userRequest);
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

