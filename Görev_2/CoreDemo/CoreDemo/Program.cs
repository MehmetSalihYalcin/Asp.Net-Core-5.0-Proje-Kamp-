var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/DefaultError","?code{0}"); // durum kodlarý sayfasýný kullan , sitede olmayan sayfalara gidilmesi durumunda kullanýcýlara gösterilecek alandan bahsediyor içerisindeki olaylar hata sayfasýný n yerini söylüyor ve boþ dönmesi durumunda ? ve code olarakta sayfayý iþaret ediyor

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Blog}/{action=Index}/{id?}");

app.Run();
