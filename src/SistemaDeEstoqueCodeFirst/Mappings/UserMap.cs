using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeEstoqueCodeFirst.Models;

namespace SistemaDeEstoqueCodeFirst.Mappings
{
  public class UserMap : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");

        builder.Property(p => p.Username)
            .HasColumnType("varchar(50)")
            .IsRequired();

        builder.Property(p => p.Email)
            .HasColumnType("varchar(120)")
            .IsRequired();

        builder.Property(p => p.Password)
            .HasColumnType("varchar(200)")
            .IsRequired();
        
        builder.Property(p => p.DateCreated)
            .HasColumnType("datetime");
        
        builder.Property(p => p.LastUpdate)
            .HasColumnType("datetime");

        builder.Property(p => p.RecoveryCode)
            .HasColumnType("varchar(200)");
        
        builder.Property(p => p.Active)
            .HasColumnType("bit");
        
        builder.HasOne(p => p.Role)
            .WithMany(p => p.Users)
            .HasForeignKey(p => p.RoleID)
            .OnDelete(DeleteBehavior.NoAction);
    }
  }
}