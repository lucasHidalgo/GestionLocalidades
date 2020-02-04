using GestionLocalidades.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionLocalidades.Data.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Provincias> Provincias { get; set; }
        public DbSet<Localidades> Localidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provincias>()
                .HasOne(a => a.Pais)
                .WithMany(x => x.Provincias)
                .HasForeignKey(x => x.PaisId);

            modelBuilder.Entity<Localidades>()
                .HasOne(x => x.Provincias)
                .WithMany(x => x.Localidades)
                .HasForeignKey(x=>x.ProvinciaId);
        }
    }
}
