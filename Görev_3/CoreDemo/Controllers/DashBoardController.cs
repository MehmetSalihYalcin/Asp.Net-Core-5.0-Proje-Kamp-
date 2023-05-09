using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
