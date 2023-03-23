using Microsoft.EntityFrameworkCore;

namespace StreetApi.Models
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "StreetDb");
        }
        public DbSet<StreetItem> StreetItems { get; set; }
    }
}
