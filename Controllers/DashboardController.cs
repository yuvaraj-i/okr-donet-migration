using System;
using helloWorld.Data;
using helloWorld.Interfaces;
using helloWorld.Models;
using helloWorld.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace helloWorld.Controllers
{
    [ApiController]
    public class DashboardController: ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(IDashboardService dashboardService, ILogger<DashboardController> logger)
        {
            _dashboardService = dashboardService;
            _logger = logger;
        }

        [HttpGet("get_all_activity")]
        public IActionResult getAllActivity(int page)
        {
            try
            {

                var genericResponse = new ResponseModel<List<ActivityLog>>();

                genericResponse.message = _dashboardService.getAllActivity(page);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }

    }
}

