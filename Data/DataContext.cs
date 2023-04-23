global using Microsoft.EntityFrameworkCore;
using cardholders.Models;

namespace cardholders.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:cardholdersserver.database.windows.net,1433;Initial Catalog=cardholdersdb;Persist Security Info=False;User ID=testdcuser;Password=Testshan1@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<Cardholder> Cardholders { get; set; }
    }
}
