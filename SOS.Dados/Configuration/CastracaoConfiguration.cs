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
    public class CastracaoConfiguration : IEntityTypeConfiguration<Castracao>

    {
        public void Configure(EntityTypeBuilder<Castracao> builder)
        {
            builder.ToTable("Castracao");
            builder.HasKey(f => f.CastracaoID);

            builder
                .Property(f => f.CastracaoID)
                .UseIdentityColumn()
                .HasColumnName("CastracaoID")
                .HasColumnType("int");

            builder
             .Property(f => f.AnimalID)
             .HasColumnName("AnimalID")
             .HasColumnType("int");

            builder
             .Property(f => f.VeterinarioID)
             .HasColumnName("VeterinarioID")
             .HasColumnType("int");


            builder
             .Property(f => f.DataProcedimento)
             .HasColumnName("DataProcedimento")
             .HasColumnType("date");
        }
    }

}