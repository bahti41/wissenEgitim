using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Concrete.Contexts;

namespace MiniShop.UI.Extensions
{
    public static class HostServiceExtension
    {
        public static IHost UpdateDataBase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using(var miniShopDbContext = scope.ServiceProvider.GetRequiredService<MiniShopDbContext>())
                {
                    try
                    {
                        var pendingMigrations = miniShopDbContext.Database.GetPendingMigrations().Count();
                        if(pendingMigrations > 0) miniShopDbContext.Database.Migrate();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                }
            }
            return host;
        }
    }
}
