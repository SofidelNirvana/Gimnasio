using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gimnasio.Models
{
    [Table("Pagos")]
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }

        public int IdSocio { get; set; }
        public int IdMembresia { get; set; }

        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        [StringLength(20)]
        public string Estado { get; set; }

        // Propiedades de navegación
        [ForeignKey("IdSocio")]
        public virtual Socio Socio { get; set; }

        [ForeignKey("IdMembresia")]
        public virtual Membresia Membresia { get; set; }
    }
}