using BusinessLayer.ConCrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());

		public IActionResult Index()
		{
			var model = bm.GetListWithCategory();
			return View(model);
		}
		public IActionResult BlogReadAll(int id)
		{
			ViewBag.id = id;
			var model = bm.GetByIDBlog(id);
			return View(model);
		}
	}
}