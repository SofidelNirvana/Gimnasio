using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gimnasio.Models
{
    [Table("Clases")]
    public class Clase
    {
        [Key]
        public int IdClase { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; }

        [Required, StringLength(50)]
        public string Horario { get; set; }

        [Required, StringLength(100)]
        public string Instructor { get; set; }

        public int CupoMaximo { get; set; }
        public bool Estado { get; set; }
    }
}