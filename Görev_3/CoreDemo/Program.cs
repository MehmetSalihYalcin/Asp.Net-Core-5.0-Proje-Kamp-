using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc(config => // proje baz�nda b�t�n sayfalar� g�venlik amac�yla sadece otantication olduktan sonra a�ar diyer �ekilde ba�lant�ya izin vermez
{
	var policy = new AuthorizationPolicyBuilder()
		.RequireAuthenticatedUser()
		.Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddSession(); // session i�lemlerini ekle
builder.Services.AddMvc(); // mvc ekle
builder.Services.AddAuthentication( // otantication i�lemi ekleme
	CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(x=>
	{
		x.LoginPath = "/Login/Index"; // izin verilmeyen sayfalara eri�im olmas� halinde bu dizine beni y�nlendir
	});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/DefaultError", "?code={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession(); // session i�lemlerini kullan
app.UseAuthentication(); // autentication kullan
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Blog}/{action=Index}/{id?}");

app.Run();
