var builder = WebApplication.CreateBuilder(args);


/*
 * AddControllersWithViews metodu, bu projenin bir MVC uygulamas� olmas�n� sa�lar. Burada ControllersWithViews servisini IOC(servis havuzu) i�ine koymu� oluruz. Uygulama ihtiya� duydu�u her anda bu havuzdan bu bilgiyi edinebilir.
 * PEK� YA MVC Nedir? 
 * Model: Projemizdeki veri, veri taban� gibi i�leri y�r�tt���m�z b�l�m.
 * View: Projemizdeki aray�z� temsil eden b�l�m.
 * Controller: Gelen t�m istekleri kar��layan yani projemizin as�l backend kodlar�n�n yer alaca�� b�l�m. 
 * 
 */
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//https://localhost:5069/Product/AddProduct
//https://localhost:5069/
//https://localhost:5069/Home/Index

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
