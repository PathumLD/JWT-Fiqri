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
	}
}
