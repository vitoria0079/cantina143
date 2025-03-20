using Microsoft.EntityFrameworkCore;

namespace cantina143.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Alimentos> Alimentos { get; set; } //amo minha vida dms
    }
}
