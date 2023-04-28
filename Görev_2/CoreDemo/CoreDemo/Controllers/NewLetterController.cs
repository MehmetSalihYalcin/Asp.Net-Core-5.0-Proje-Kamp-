using BusinessLayer.ConCrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class NewLetterController : Controller
	{
		NewLetterManager nm = new NewLetterManager(new EfNewLetterRepository());
		[HttpGet]
		public PartialViewResult SubScribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SubScribeMail(NewsLetter p)
		{
			p.Mail_Status = true;
			nm.NewLetterAdd(p);
			return PartialView();
		}
	}
}
