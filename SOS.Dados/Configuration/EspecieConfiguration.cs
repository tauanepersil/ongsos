using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SOS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dados.Configuration
{
    public class EspecieConfiguration : IEntityTypeConfiguration<Especie>
 
        {
            public void Configure(EntityTypeBuilder<Especie> builder)
            {
                builder.ToTable("Especie");
                builder.HasKey(f => f.EspecieID);

            builder
                .Property(f => f.EspecieID)
                .UseIdentityColumn()
                .HasColumnName("EspecieID")
                .HasColumnType("int");

            builder
               .Property(f => f.Descricao)
               .HasColumnName("Descricao")
               .HasColumnType("varchar(50)");


        }
        }
  }