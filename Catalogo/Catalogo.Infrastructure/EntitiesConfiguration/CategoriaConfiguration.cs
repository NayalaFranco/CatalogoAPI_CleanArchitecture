using Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalogo.Infrastructure.EntitiesConfiguration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // Usa fluenteAPI para configurar as propriedades
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.ImagemUrl).HasMaxLength(100).IsRequired();

            // Esse trexo serve para popular a tabela categoria
            builder.HasData(
              new Categoria(1, "Material Escolar", "material.jpg"),
              new Categoria(2, "Eletrônicos", "eletronicos.jpg"),
              new Categoria(3, "Acessórios", "acessorios.jpg")
            );
        }
    }
}
