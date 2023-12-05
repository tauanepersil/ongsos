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
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>

    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(f => f.EnderecoID);

            builder
                .Property(f => f.CEP)
                .HasColumnName("CEP")
                .HasColumnType("varchar(10)");

            builder
             .Property(f => f.Cidade)
             .HasColumnName("Cidade")
             .HasColumnType("varchar(50)");

            builder
             .Property(f => f.Estado)
             .HasColumnName("Estado")
             .HasColumnType("varchar(50)");


            builder
             .Property(f => f.Logradouro)
             .HasColumnName("Logradouro")
             .HasColumnType("varchar(100)");


            builder
             .Property(f => f.Bairro)
             .HasColumnName("Bairro")
             .HasColumnType("varchar(50)");


            builder
             .Property(f => f.Numero)
             .HasColumnName("Numero")
             .HasColumnType("int");
        }
    }
}