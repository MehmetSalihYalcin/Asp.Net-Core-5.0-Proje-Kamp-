using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreDemo.ViewComponents
{
	public class CommentList : ViewComponent // viewcomponent sınıfını kullan
	{
		public IViewComponentResult Invoke() // çağır = invoke
		{
			var model = new List<UsersComment>
			{
				new UsersComment
				{
					 ID = 1,
					  UserName = "Test",
				},
				new UsersComment
				{
					 ID = 2,
					  UserName = "Test2",
				},
				new UsersComment
				{
					 ID = 3,
					  UserName = "Test3",
				}

			};
			return View(model);
		}
	}
}
