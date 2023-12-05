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
    public class TutorConfiguration : IEntityTypeConfiguration<Tutor>

    {
        public void Configure(EntityTypeBuilder<Tutor> builder)
        {
            builder.ToTable("Tutor");
            builder.HasKey(f => f.TutorID);

            builder
                .Property(f => f.TutorID)
                .UseIdentityColumn()
                .HasColumnName("TutorID")
                .HasColumnType("int");

            builder
               .Property(f => f.CPF)
               .HasColumnName("CPF")
               .HasColumnType("char(11)");

            builder
               .Property(f => f.NomeCompleto)
               .HasColumnName("NomeCompleto")
               .HasColumnType("varchar(200)");

            builder
                .Property(f => f.EnderecoID)
                .HasColumnName("EnderecoID")
                .HasColumnType("int");

            builder
               .Property(f => f.TelefoneCelular)
               .HasColumnName("TelefoneCelular")
               .HasColumnType("varchar(20)");

            builder
              .Property(f => f.TelefoneFixo)
              .HasColumnName("TelefoneFixo")
              .HasColumnType("varchar(20)");


        }
    }
}