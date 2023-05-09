using BusinessLayer.ConCrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact c)
		{
			c.Contact_Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			c.Contact_Status = true;
			cm.ContactAdd(c);
			return RedirectToAction("Index","Blog");
		}
	}
}
