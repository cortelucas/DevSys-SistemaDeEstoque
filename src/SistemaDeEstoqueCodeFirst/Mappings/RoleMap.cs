using Microsoft.EntityFrameworkCore;
using SistemaDeEstoqueCodeFirst.Models;

namespace SistemaDeEstoqueCodeFirst.Mappings
{
  public class RoleMap : IEntityTypeConfiguration<Role>
  {
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Role");

        builder.Property(p => p.Name)
            .HasColumnType("varchar(50")
            .IsRequired();
    }
  }
}