using BusinessLayer.ConCrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Categories
{
	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());

		public IViewComponentResult Invoke()
		{
			var result = cm.GetAllCategories();
				return View(result);
		}
	}
}
