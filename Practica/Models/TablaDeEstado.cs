using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica.Models
{   
    [Table("TablaDeEstado")]
    public class TablaDeEstado
    {

        [Key]
        public int ID { get; set; }

        [Required]
        public string? NombreEstado { get; set; }

        [Required]
        public DateTime? FechaDeCreacion { get; set; }

    }
}
