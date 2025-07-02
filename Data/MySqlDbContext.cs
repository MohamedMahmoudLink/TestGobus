using Microsoft.EntityFrameworkCore;
using StationTest.Models;

public class MySqlDbContext : DbContext
{
    public MySqlDbContext(DbContextOptions<MySqlDbContext> options)
        : base(options) { }

    public DbSet<areas> areas { get; set; }

        public DbSet<Passenger> Passenger { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<areas>(entity =>
        {
            entity.ToTable("areas", "gomini");
            entity.HasKey(e => e.IDArea); 
        });

            modelBuilder.Entity<Passenger>(entity =>
    {
        entity.ToTable("passengers", "gomini");
        entity.HasKey(e => e.IDPassenger);
    });


    }

}
