using Capa_Datos.Modelos;
using System.Collections.Generic;

namespace Capa_Negocios
{
    public class NMedico
    {
        private readonly DMedico dMedico;

        public NMedico()
        {
            dMedico = new DMedico();
        }

        public List<Medico> ObtenerTodosLosMedicos()
        {
            return dMedico.ObtenerTodosLosMedicos();
        }

        public int GuardarMedico(Medico medico)
        {
            if (medico.MedicoId == 0)
            {
                return dMedico.Agregar(medico);
            }
            else
            {
                return dMedico.Editar(medico);
            }
        }

        public int EliminarMedico(int medicoId)
        {
            return dMedico.Eliminar(medicoId);
        }
    }
}
