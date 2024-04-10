using Capa_Datos.Modelos;
using System.Collections.Generic;

namespace Capa_Negocios
{
    public class NPaciente
    {
        private readonly DPaciente dPaciente;

        public NPaciente()
        {
            dPaciente = new DPaciente();
        }

        public List<Paciente> ObtenerTodosLosPacientes()
        {
            return dPaciente.ObtenerTodosLosPacientes();
        }

        public int GuardarPaciente(Paciente paciente)
        {
            if (paciente.PacienteId == 0)
            {
                return dPaciente.Agregar(paciente);
            }
            else
            {
                return dPaciente.Editar(paciente);
            }
        }

        public int EliminarPaciente(int pacienteId)
        {
            return dPaciente.Eliminar(pacienteId);
        }
    }
}
