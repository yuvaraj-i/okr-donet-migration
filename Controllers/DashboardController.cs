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

    }
}

