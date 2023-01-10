using System;
using helloWorld.Models;
using helloWorld.Services;
using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
	[ApiController]
	public class SkillController : ControllerBase
	{
		private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
		{
			_skillService = skillService;
		}

		[HttpGet("skills")]
		public IActionResult getUserSkills()
		{
			try
			{
				var skills = _skillService.getUserSkills(1);

                var genericResponse = new ResponseModel<List<Skill>>();
				genericResponse.message = skills;

				return Ok(genericResponse);
            }

			catch(Exception e)
			{
				return BadRequest();
			}

        }
	}
}

