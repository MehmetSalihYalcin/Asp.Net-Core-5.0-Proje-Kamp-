using BusinessLayer.ConCrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());

		public IViewComponentResult Invoke(int id)
		{
			var result = cm.GetAllComment(id);

			if (result.Count()  != 0)
			{
				ViewBag.myid = 1;
			}
			else
			{
				ViewBag.myid = 0;
			}
			return View(result);
		}
	}
}
