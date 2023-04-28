using BusinessLayer.ConCrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment comment)
		{
			comment.Comment_Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.Comment_Status = true;
			comment.Blog_ID = 4;
			cm.CommentAdd(comment);
			return PartialView();
		}
		public PartialViewResult PartialCommentListByBlog(int id)
		{
			var model = cm.GetAllComment(id);
			return PartialView(model);
		}
	}
}
