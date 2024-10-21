using Microsoft.EntityFrameworkCore;
using Proyecto.Clientes.MVC.Entidades;

namespace Proyecto.Clientes.MVC.Contexto
{
    public class VentasContext:DbContext
    {
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-6OV0P88\\SQLEXPRESS; Initial Catalog = VentasDb; TrustServerCertificate = true; Encrypt = true; Integrated Security = true;");
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}
