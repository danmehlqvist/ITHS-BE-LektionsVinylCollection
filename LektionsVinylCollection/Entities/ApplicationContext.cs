using Microsoft.EntityFrameworkCore;

namespace LektionsVinylCollection.Entities
{
    // dotnet ef migrations add XXXXXXX
    // dotnet ef database update​


    public class ApplicationContext : DbContext
    {
        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Artist> Artists { get; set; }

        // Orginalet:
        //private string _connectionString = "server=localhost; database=vinylCollection; user=dan; password= dan1234​.;";
        private string _connectionString = "server=localhost; database=vinylCollection; user=dan; password=dan1234.";
        //private string _connectionString2 = "server=localhost;database=vinylCollection;uid=dan;pwd=dan1234.;";


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                _connectionString,
                ServerVersion.AutoDetect(_connectionString));
        }
    }
}
