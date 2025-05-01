using System.ComponentModel.DataAnnotations;

namespace PabloVargas_ExamenProgreso1.Models
{
    public class Propietario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal CodigoSeguridad { get; set; }
        public Boolean EstaAfiliado { get; set; }
        [DataType(DataType.Date)]
        public DateOnly FechaNacimiento { get; set; }

    }
}
