using Microsoft.EntityFrameworkCore;
using dale.sale.api.Models;

namespace dale.sale.api.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venta>()
            .HasOne(p => p.Cliente)
            .WithMany(l => l.ClienteVentas)
            .HasForeignKey(p => p.ClienteId)
            .HasPrincipalKey(l => l.Id)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("VENTA_CLIENTE_FK");

             modelBuilder.Entity<Venta>()
            .HasOne(p => p.Producto)
            .WithMany(l => l.ProductoVentas)
            .HasForeignKey(p => p.ProductoId)
            .HasPrincipalKey(l => l.Id)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("VENTA_PRODUCTO_FK");      
        }
    }
}