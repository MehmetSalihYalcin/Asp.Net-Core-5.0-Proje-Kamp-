using BusinessLayer.ConCrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrate;
using FluentValidation.Results;
using FluentValidation.TestHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.Identity.Client.Utils.Windows;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
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
		public IActionResult BlogListByWriter()
		{
			var values = bm.GetAllCategoryByWriter(2);
			return View(values);
		}
		[HttpGet]
		public IActionResult BlogAdd()
		{
			GetCategoryList();

            return View();
		}
        [HttpPost]
        public IActionResult BlogAdd(Blog b)
        {
            BlogValidator bv = new BlogValidator();
			ValidationResult result = bv.Validate(b);
            if (result.IsValid)
            {
				b.Blog_CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				b.Blog_Status = true;
				b.Writer_ID = 2;
				bm.TAdd(b);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
				GetCategoryList();
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

		public IActionResult DeleteBlog(int id)
		{
			var deletevalue = bm.TGetById(id);
			bm.TDelete(deletevalue);
			return RedirectToAction("BlogListByWriter");
		}
		[HttpGet]
		public IActionResult UpdateBlog(int id)
		{
            GetCategoryList();

            var request = bm.TGetById(id);
			return View(request);
		}
        [HttpPost]
        public IActionResult UpdateBlog(Blog b)
        {
			b.Blog_Status = true;
			b.Blog_CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			b.Writer_ID = 2;
			bm.TUpdate(b);
			return RedirectToAction("BlogListByWriter");
        }

        public void GetCategoryList()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryvalues = (from x in cm.TGetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Category_Name,
                                                       Value = x.Category_ID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
        }
    }
}