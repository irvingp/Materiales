using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Materiales.Models
{
    public class MaterialesContext : DbContext
    {
        public MaterialesContext()
        {
        }

        public MaterialesContext(DbContextOptions<MaterialesContext> options)
          : base(options)
        {
        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<Materiales> Materiales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("Categoria").HasKey(p=>p.IdCategoria);
            modelBuilder.Entity<Proveedor>().ToTable("Proveedor").HasKey(p => p.IdProveedor);
            modelBuilder.Entity<UnidadMedida>().ToTable("UnidadMedida").HasKey(p => p.IdUnidadMedida);
            modelBuilder.Entity<Materiales>().ToTable("Materiales").HasKey(p => p.IdMaterial);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
