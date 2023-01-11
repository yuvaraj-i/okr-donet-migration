using System;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using helloWorld.Models;

namespace helloWorld.Utils
{
	public class JwtTokenUtils : IJwtTokenUtils
    {
		public JwtTokenUtils()
		{
		}

        public string createToken(User user)
        {
            List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email,user.email),
                    new Claim(ClaimTypes.Name,user.id.ToString())
                };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("my favourite token is here thank you"));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: cred
                );

            var Jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return Jwt;
        }
    }
}

