using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult DefaultError(int id)
		{
			return View();
		}
	}
}
