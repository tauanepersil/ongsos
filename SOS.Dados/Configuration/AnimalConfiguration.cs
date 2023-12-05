using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dados.Configuration
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>

    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animal");
            builder.HasKey(f => f.AnimalID);

            builder
                .Property(f => f.AnimalID)
                .UseIdentityColumn()
                .HasColumnName("AnimalID")
                .HasColumnType("int");

            builder
                .Property(f => f.TutorID)
                .HasColumnName("TutorID")
                .HasColumnType("int");

            builder
               .Property(f => f.Nome)
               .HasColumnName("Nome")
               .HasColumnType("varchar(50)");

            builder
              .Property(f => f.Nascimento)
              .HasColumnName("Nascimento")
              .HasColumnType("date");

            builder
              .Property(f => f.Peso)
              .HasColumnName("Peso")
              .HasColumnType("decimal")
              .HasPrecision(18,3);

            builder
             .Property(f => f.EspecieID)
             .HasColumnName("EspecieID")
             .HasColumnType("int");
        }
    }
}
