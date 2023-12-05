using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SOS.Dados.Configuration;
using SOS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dados

{
    public class Contexto : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Castracao> Castracao { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Especie> Especie { get; set; }
        public DbSet<Tutor> Tutor { get; set; }
        public DbSet<Veterinario> Veterinario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = BANDEIRA,1434; 
                                    Database = BD040149; 
                                    User ID = RA040149; 
                                    Password = 040149;
                                    TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new CastracaoConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new EspecieConfiguration());
            modelBuilder.ApplyConfiguration(new TutorConfiguration());
            modelBuilder.ApplyConfiguration(new VeterinarioConfiguration());
        }

    }
}