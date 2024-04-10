using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Modelos
{
    public class Cita
    {
        [Key]
        public int CitaId { get; set; }

        [Required]
        public int MedicoId { get; set; }

        [Required]
        public int PacienteId { get; set; }

        [Required]
        public DateTime FechaCita { get; set; }

        [Required]
        public bool Estado { get; set; }

        [ForeignKey("MedicoId")]
        public virtual Medico Medico { get; set; }

        [ForeignKey("PacienteId")]
        public virtual Paciente Paciente { get; set; }
    }
}
