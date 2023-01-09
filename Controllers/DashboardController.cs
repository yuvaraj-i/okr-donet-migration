using System;
using helloWorld.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace helloWorld.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController: ControllerBase
    {
        private readonly okr_dbContext _DbContext;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(okr_dbContext okr_DbContext, ILogger<DashboardController> logger)
        {
            _DbContext = okr_DbContext;
            _logger = logger;
        }

        //      [HttpGet("get/{id}")]
        //      public IActionResult getUsers(int id)
        //      {
        //          var user = _DbContext.Users.Find(id);
        //          return Ok(user);
        //      }

        //      [HttpPost("update")]
        //      public IActionResult update(User user)
        //      {
        //          try
        //          {
        //              _DbContext.Users.Update(user);
        //          }
        //          catch
        //          {
        //              return BadRequest();
        //          }
        //          return Ok();
        //      }

        //      [HttpPost("user")]
        //      public IActionResult createUser(User user)
        //      {
        //          _logger.LogDebug("Entered to User");

        //          _DbContext.Users.Add(user);
        //          return Ok();
        //      }
    }
}

