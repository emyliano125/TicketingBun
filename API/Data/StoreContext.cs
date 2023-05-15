using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : IdentityDbContext<User>
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet <Serviciu> Servicii { get; set; }
        public DbSet <Solicitare> Solicitari { get; set; }
        public DbSet <Status> Statusuri { get; set; }
        public DbSet <Unitate> Unitati { get; set; }
         protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole{Name="Member",NormalizedName="MEMBER"},
                new IdentityRole{Name="Admin",NormalizedName="ADMIN"}
            );
        }

    }
}