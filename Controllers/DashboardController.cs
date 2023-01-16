using System;
using helloWorld.Models;
using helloWorld.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace helloWorld.Controllers
{
    /**
     * multi line comment
     **/ 
    [ApiController]
    [Authorize]
    public class DashboardController: ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(IDashboardService dashboardService, ILogger<DashboardController> logger)
        {
            _dashboardService = dashboardService;
            _logger = logger;
        }

        [HttpGet("activities")]
        public IActionResult getAllActivity()
        {
            _logger.LogInformation("Processed in ms.");

            try
            {
                var userId = Int32.Parse(User?.Identity?.Name);
                var genericResponse = new ResponseModel<List<ActivityLog>>();

                genericResponse.message = _dashboardService.getAllActivity(userId);
                return Ok(genericResponse);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("activity")]
        public IActionResult getAllActivity(int page)
        {
            _logger.LogInformation("Processed {@page} in {Elapsed:000} ms.", page);

            try
            {
                var genericResponse = new ResponseModel<List<ActivityLog>>();

                genericResponse.message = _dashboardService.getAllActivity(page);
                return Ok(genericResponse);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}

