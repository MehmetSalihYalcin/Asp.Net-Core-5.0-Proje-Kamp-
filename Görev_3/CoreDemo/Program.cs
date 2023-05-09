using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc(config => // proje bazýnda bütün sayfalarý güvenlik amacýyla sadece otantication olduktan sonra açar diyer þekilde baðlantýya izin vermez
{
	var policy = new AuthorizationPolicyBuilder()
		.RequireAuthenticatedUser()
		.Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddSession(); // session iþlemlerini ekle
builder.Services.AddMvc(); // mvc ekle
builder.Services.AddAuthentication( // otantication iþlemi ekleme
	CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(x=>
	{
		x.LoginPath = "/Login/Index"; // izin verilmeyen sayfalara eriþim olmasý halinde bu dizine beni yönlendir
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
app.UseSession(); // session iþlemlerini kullan
app.UseAuthentication(); // autentication kullan
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Blog}/{action=Index}/{id?}");

app.Run();
