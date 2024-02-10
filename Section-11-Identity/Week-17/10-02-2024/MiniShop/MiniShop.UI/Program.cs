using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.Helpers.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MiniShopDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<MiniShopDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region Parola Ayarlar�
    options.Password.RequiredLength = 6; //parola en azz 6 karakter olur
    options.Password.RequireDigit = true; //Parola int vete strring
    options.Password.RequireNonAlphanumeric = true;//parola t�m karakterler
    options.Password.RequireUppercase = true; ; // parola b�y�k harf icermeli
    options.Password.RequireLowercase = true; // parola kucuk harc gecerli
    /*options.Password.RequiredUniqueChars*/  // tekrar etmemsi istenen karakterler
    #endregion

    #region Hesap Kilitleme ayarlar�
    options.Lockout.MaxFailedAccessAttempts = 5; // �st �ste hatal� giri� deneme s�n�r�
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15);// kilitlenmi� bir hesaba yeniden giri� yapabilmmek icin giri� s�resi
    /*options.Lockout.AllowedForNewUsers = true;*/ // Yeniden kay�t olma imkan� ver

    #endregion

    options.User.RequireUniqueEmail = true;//Her email sadece bir kez kay�t olabilir
    options.SignIn.RequireConfirmedEmail = false;//
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/login";
    options.LogoutPath = "/";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromSeconds(45);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        Name = "MiniShop.Security.Cookie",
        HttpOnly = true,
        SameSite=SameSiteMode.Strict
    };
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped<IImageHelper, ImageHelper>();

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

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
