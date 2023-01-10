using System;
using helloWorld.Models;

namespace helloWorld.Utils
{
	public interface IJwtTokenUtils
	{
		public string createToken(User user);
	}

}

