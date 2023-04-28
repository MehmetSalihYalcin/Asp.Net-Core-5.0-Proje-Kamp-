using BusinessLayer.ConCrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrate;
using FluentValidation.Results;
using FluentValidation.TestHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.Identity.Client.Utils.Windows;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		CityManager cm = new CityManager(new EfCityRepository());

		[HttpGet]
		public IActionResult Index()
		{
			List<SelectListItem> valueCity = (from x in cm.GetAllCitys()
												  select new SelectListItem
												  {
													  Text = x.City_Name,
													  Value = x.City_ID.ToString()
												  }
												 ).ToList();
			ViewBag.CityList = valueCity;
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult result = wv.Validate(writer);
			if (writer.City_ID == 0)
			{
				ViewBag.wrong = "Şehir ALanı Boş Geçilemez";
			}
			if (result.IsValid)
			{
				writer.Writer_About = "Deneme";
				writer.Writer_Status = true;
				wm.WriterAdd(writer);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				List<SelectListItem> valueCity = (from x in cm.GetAllCitys()
												  select new SelectListItem
												  {
													  Text = x.City_Name,
													  Value = x.City_ID.ToString()
												  }
												 ).ToList();
				ViewBag.CityList = valueCity;

				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}
		}
	}
}
