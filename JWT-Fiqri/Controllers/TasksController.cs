using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Fiqri.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TasksController : ControllerBase
	{
		[HttpGet]
		public IActionResult Tasks()
		{
			var tasks = new string[] { "Task1", "Taask2", "Task3" };
			return Ok();
		}

		[HttpPost]
		public IActionResult NewTask()
		{
			return Ok();
		}

		[HttpPut]
		public IActionResult PutTask()
		{
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteTask()
		{
			var somethingWentWrong = true;
			if (somethingWentWrong)
			{
				return BadRequest();
			}
			return Ok();
		}
	}
}
