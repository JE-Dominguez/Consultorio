using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Modelos
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }

        [Required]
        [StringLength(120)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(120)]
        public string Apellidos { get; set; }

        [Required]
        public DateTime FechaIngreso { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}
