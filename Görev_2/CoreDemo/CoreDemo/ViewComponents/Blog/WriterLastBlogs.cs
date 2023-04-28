using BusinessLayer.ConCrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
	public class WriterLastBlogs : ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var result = bm.GetBlogListByWriter(2);
			return View(result);
		}
	}
}
