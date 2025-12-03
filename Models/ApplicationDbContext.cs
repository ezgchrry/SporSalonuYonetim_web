using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SporSalonuYonetim_web.Models
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {
        }

        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<Antrenor> Antrenorler { get; set; }
        public DbSet<AntrenorHizmet> AntrenorHizmetleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AntrenorHizmet>()
                .HasKey(ah => new { ah.AntrenorId, ah.HizmetId });

            modelBuilder.Entity<AntrenorHizmet>()
                .HasOne(ah => ah.Antrenor)
                .WithMany(a => a.AntrenorHizmetleri)
                .HasForeignKey(ah => ah.AntrenorId);

            modelBuilder.Entity<AntrenorHizmet>()
                .HasOne(ah => ah.Hizmet)
                .WithMany(h => h.AntrenorHizmetleri)
                .HasForeignKey(ah => ah.HizmetId);
        }
    }
}