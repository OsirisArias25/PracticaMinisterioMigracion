using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica.Models
{   
    [Table("Jugadores")]
    public class Jugadores
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Apellido { get; set; }

        [Required]
        public DateTime? FechaNacimiento { get; set; }

        [Required]
        public string? Pasaporte { get; set; }

        [Required]
        public string? Direccion { get; set; }
        public bool Sexo { get; set; }

        public List<TablaDeEstado>? id_Estado { get; set; } // (Activo, Cancelado, Agente Libre)

        public Equipo? Id_Equipo { get; set; }

    }
}
