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
app.UseStatusCodePagesWithReExecute("/ErrorPage/DefaultError","?code{0}"); // durum kodlar� sayfas�n� kullan , sitede olmayan sayfalara gidilmesi durumunda kullan�c�lara g�sterilecek alandan bahsediyor i�erisindeki olaylar hata sayfas�n� n yerini s�yl�yor ve bo� d�nmesi durumunda ? ve code olarakta sayfay� i�aret ediyor

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Blog}/{action=Index}/{id?}");

app.Run();
