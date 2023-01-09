using System;
using helloWorld.Interfaces.Services;
using helloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
	[ApiController]
	public class ObjectivesController : Controller
    {
		private readonly IObjectiveService _objectiveService;

        public ObjectivesController(IObjectiveService objectiveService)
		{
			_objectiveService = objectiveService;

        }

		[HttpPut("add-skill")]
		public IActionResult addSkill(List<Skill> skills)
		{
			_objectiveService.addSkill(skills);

            return Ok(skills);
        }
    }
}

