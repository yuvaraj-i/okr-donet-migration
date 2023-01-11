using System;
using helloWorld.Models;
using helloWorld.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
	[ApiController]
	[Route("skill")]
	public class SkillController : ControllerBase
	{
		private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
		{
			_skillService = skillService;
		}

		[HttpGet, Authorize]
		public IActionResult getUserSkills()
		{
			try
			{
				var userId = Int32.Parse(User?.Identity?.Name);
				var skills = _skillService.getUserSkills(userId);

                var genericResponse = new ResponseModel<List<Skill>>();
				genericResponse.message = skills;

				return Ok(userId);
            }

			catch(Exception e)
			{
				return BadRequest(e.Message);
			}

        }



		[HttpPost("add_skill")]
		public IActionResult addUserSkills(List<Skill> skills)
		{
			try
			{
                var userId = Int32.Parse(User?.Identity?.Name);

                var genericResponse = new ResponseModel<string>();
                _skillService.addSkill(skills, userId);
                genericResponse.message = "success";

                return Ok(genericResponse);

            }
			catch(Exception e)
			{
                return BadRequest(e.Message);
            }

		}
	}
}

