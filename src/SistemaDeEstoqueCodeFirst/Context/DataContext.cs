using Microsoft.EntityFrameworkCore;
using SistemaDeEstoqueCodeFirst.Mappings;
using SistemaDeEstoqueCodeFirst.Models;

namespace SistemaDeEstoqueCodeFirst.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }    
    }
}