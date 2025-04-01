using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DemoServer
{
    public class DesignTimeContext : IDesignTimeDbContextFactory<CatalogDbContext>
    {
        public CatalogDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CatalogDbContext>();
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;User ID=sa;Password=Mein_G3heimes_Kennwort!;TrustServerCertificate=true;Database=library");

            return new CatalogDbContext(optionsBuilder.Options);
        }
    }
}
