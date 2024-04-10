using Capa_Datos.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Capa_Negocios
{
    public class NCita
    {
        DCita dCita;

        public NCita()
        {
            dCita = new DCita();
        }

        public List<Cita> ObtenerTodasLasCitas()
        {
            return dCita.ObtenerTodasLasCitas();
        }
        public List<object> ObtenerTodasLasCitasGrid()
        {
            var Citas = dCita.ObtenerTodasLasCitas().ToList()
                                     .Select(prd => new { prd.CitaId, Paciente = prd.Paciente.Nombres + " " + prd.Paciente.Apellidos, Medico = prd.Medico.Nombres + " " + prd.Medico.Apellidos, prd.FechaCita, prd.Estado })
                                     .ToList<object>();
            return Citas;
        }

        public int GuardarCita(Cita cita)
        {
            if (cita.CitaId == 0)
            {
                return dCita.Agregar(cita);
            }
            else
            {
                return dCita.Editar(cita);
            }
        }

        public int EliminarCita(int citaId)
        {
            return dCita.Eliminar(citaId);
        }
    }
}
