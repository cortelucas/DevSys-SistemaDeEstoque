using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeEstoqueCodeFirst.Models;

namespace SistemaDeEstoqueCodeFirst.Mappings
{
  public class ProductMap : IEntityTypeConfiguration<Product>
  {
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");

        builder.Property(p => p.Name)
            .HasColumnType("varchar(50)")
            .IsRequired();

        builder.Property(p => p.Description)
            .HasColumnType("text")
            .IsRequired();

        builder.Property(p => p.Quantity)
            .HasColumnType("integer")
            .IsRequired();

        builder.Property(p => p.Image)
            .HasColumnType("text");

        builder.Property(p => p.Price)
            .HasColumnType("numeric(38,2)")
            .IsRequired();

        builder.Property(p => p.DateCreated)
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(p => p.LastUpdate)
            .HasColumnType("datetime")
            .IsRequired();
            
        builder.Property(p => p.Status)
            .HasColumnType("integer")
            .IsRequired();

        builder.HasOne(p => p.Category)
            .WithMany(p => p.Products)
            .HasForeignKey(p => p.CategoryID)
            .OnDelete(DeleteBehavior.NoAction);
    }
  }
}