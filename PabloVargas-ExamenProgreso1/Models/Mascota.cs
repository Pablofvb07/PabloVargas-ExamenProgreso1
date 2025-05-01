using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PabloVargas_ExamenProgreso1.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Raza { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Tamaño { get; set; }
        public Boolean TieneVacunas { get; set; }
        public int IdPropietario { get; set; }
        [ForeignKey("IdPropietario")]
        public Propietario? Propietario { get; set; }
    }
}
