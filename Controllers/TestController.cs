using System;
using System.Net;
using helloWorld.Data;
using helloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers;

[ApiController]
public class TestController : ControllerBase
{
	private readonly okr_dbContext _DbContext;
    private readonly ILogger<TestController> _logger;

    public TestController(okr_dbContext okr_DbContext, ILogger<TestController> logger)
	{
		_DbContext = okr_DbContext;
        _logger = logger;

    }

	[HttpGet("users")]
	public ActionResult<ResponseModel<List<Data.User>>> getUsers()
	{
		var genericResponse = new ResponseModel<List<Data.User>>();
		genericResponse.message = _DbContext.Users.ToList();


        return BadRequest(genericResponse);
    }

	[HttpGet("user/{id}")]
	public ActionResult<ResponseModel<Data.User>> pathURL(int id)
	{

        var genericResponse = new ResponseModel<Data.User>();
        genericResponse.message = _DbContext.Users.Find(id);


        return Ok(genericResponse);
    }

    [HttpGet("find")]
    public ActionResult<ResponseModel<string>>queryURL(string department)
	{
        var genericResponse = new ResponseModel<string>();
        genericResponse.message = department;


        return Ok(genericResponse);
    }

    [HttpPost("update")]
    public IActionResult update(Data.User user)
    {
        try
        {
            _DbContext.Users.Update(user);
        }
        catch
        {
            return BadRequest();
        }
        return Ok();
    }

    [HttpPost("user")]
    public IActionResult createUser(Data.User user)
    {
        _logger.LogDebug("Entered to User");

        _DbContext.Users.Add(user);
        return Ok();
    }

}

