using System;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using helloWorld.DBContex;
using helloWorld.Models;
using helloWorld.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace helloWorld.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeService _homeService;

        public HomeController(ILogger<HomeController> logger, AppDbContex appDbContex, IHomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }

        [HttpPost("signup")]
        public ActionResult addUser(UserModel user)
        {
            _logger.LogError("Processed {@user} in {Elapsed:000} ms.", user);
            try { 
                var genericResponse = new ResponseModel<string>();
                _homeService.createUser(user);
                genericResponse.message = "Success";

                return Ok(genericResponse);
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("login")]
        public ActionResult login(UserRequest request)
        {
            _logger.LogInformation("Processed {@user} in {Elapsed:000} ms.", request);
            try
            {
                var genericResponse = new ResponseModel<string>();
                genericResponse.message = _homeService.verifyUser(request);


                return Ok(genericResponse);
            }

            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

}

