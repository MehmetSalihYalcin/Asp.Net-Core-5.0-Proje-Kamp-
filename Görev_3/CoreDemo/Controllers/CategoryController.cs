using BusinessLayer.ConCrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository()); // categormmanager sınıfını kullan ve efcategoryrepository entityfreamwork içerisindekileride kullan

        public IActionResult Index()
        {
            var model = cm.TGetAll();
            return View(model);
        }
    }
}
