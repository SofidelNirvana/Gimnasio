using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gimnasio.Models
{
    [Table("Socios")]
    public class Socio
    {
        [Key]
        public int IdSocio { get; set; }

        [Required, StringLength(100)]
        public string Nombres { get; set; }

        [Required, StringLength(100)]
        public string Apellidos { get; set; }

        [Required, StringLength(20)]
        public string DNI { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }
    }
}