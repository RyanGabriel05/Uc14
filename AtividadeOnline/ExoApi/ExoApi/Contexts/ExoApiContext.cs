using ExoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoApi.Contexts
{
    public class ExoApiContext : DbContext
    {
        public ExoApiContext()
        {
        }
        public ExoApiContext( DbContextOptions<ExoApiContext> opt ) : base( opt )
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            if(!optBuilder.IsConfigured)
            {
                optBuilder.UseSqlServer("Data Source = DESKTOP-67BNS8D; initial catalog = ExoApidb; Integrated Security = true ");
            }
        }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
