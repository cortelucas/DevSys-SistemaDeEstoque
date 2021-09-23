using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeEstoqueCodeFirst.Models;

namespace SistemaDeEstoqueCodeFirst.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categoria");

            builder.Property(p => p.Name)
                .HasColumnType("varchar(50)")
                .IsRequired();
            
            builder.Property(p => p.Description)
                .HasColumnType("text");
        }
  }
}