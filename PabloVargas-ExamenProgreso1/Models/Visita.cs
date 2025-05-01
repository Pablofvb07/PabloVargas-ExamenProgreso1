using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace PabloVargas_ExamenProgreso1.Models
{
    public class Visita
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaVisita { get; set; }
       [Required(ErrorMessage = "Este campo es obligatorio")]

        public string Motivo{get;set;}

        public decimal Tarifa{ get; set; }
        public Boolean RequiereMedicación { get; set; }
    }
}
