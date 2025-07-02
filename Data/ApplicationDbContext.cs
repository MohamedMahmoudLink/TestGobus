
using Microsoft.EntityFrameworkCore;
using StationTest.Models;

namespace StationTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
                        public DbSet<Station> Station { get; set; }

    }

}


