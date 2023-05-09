using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreDemo.Controllers
{
	
//Authentication="kimlik doğrulaması"
//Authorization="kimlik yetkikendirme"

	[AllowAnonymous] // heryerden erişime açmak için kullanılır
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(Writer p) // assenkron türünde
		{
			Context c = new Context();
			var datavalue = c.Writerrs.FirstOrDefault(x => x.Writer_Mail == p.Writer_Mail && x.Writer_Password == p.Writer_Password);
			if (datavalue != null)
			{
				var claims = new List<Claim> //Claimler; rollerin dışında kullanıcı hakkında bilgi tutmamızı ve bu bilgilere göre yetkilendirme yapmamızı sağlayan yapılardır.
				{
					new Claim(ClaimTypes.Name , p.Writer_Mail)
				};
				var useridentity = new ClaimsIdentity(claims, "a");//Eğer string parametre girilmezse  kimlik doğrulama olmadan bir oturum başlatılıyor. Bu sebepten hala sistemde hiçbir sayfayı göremez halde oluyoruz. 
                ClaimsPrincipal princpal = new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(princpal);
				return RedirectToAction("Index", "Writer");
			}
			else
			{
				return View();
			}
		}



		//[HttpPost]  normal kullanıcı sorgulaması
		//public IActionResult Index(Writer w)
		//{
		//	Context c = new Context();
		//	var datavalues = c.Writerrs.FirstOrDefault(x => x.Writer_Mail == w.Writer_Mail && x.Writer_Password == w.Writer_Password);
		//	if (datavalues != null)
		//	{
		//		HttpContext.Session.SetString("User_Name", w.Writer_Mail);
		//		return RedirectToAction("Index", "Writer");
		//	}
		//	else
		//	{
		//		return View();
		//	}
		//}
	}
}
