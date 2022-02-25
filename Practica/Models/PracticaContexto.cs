using Microsoft.EntityFrameworkCore;

namespace Practica.Models
{
    public class PracticaContexto : DbContext
    {
        // public PracticaContexto() : base("PracticaMigracion") { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2EP7PFL;Database=PracticaMigracion;Trusted_Connection=True;");
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugadores> Jugadores { get; set; }
        public DbSet<TablaDeEstado> Estado { get; set; }

    }
}
