using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gimnasio.Models
{
    [Table("Membresias")]
    public class Membresia
    {
        [Key]
        public int IdMembresia { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; }

        public int DuracionDias { get; set; }
        public decimal Precio { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }
    }
}