using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Datos.Core;

namespace Capa_Datos.Modelos
{
    public class DCita
    {
        private readonly UnitOfWork _unitOfWork;

        public DCita()
        {
            _unitOfWork = new UnitOfWork();
        }

        public List<Cita> ObtenerTodasLasCitas()
        {
            return _unitOfWork.Repository<Cita>().Consulta().ToList();
        }

        public int Agregar(Cita cita)
        {
            _unitOfWork.Repository<Cita>().Agregar(cita);
            return _unitOfWork.Guardar();
        }

        public int Editar(Cita cita)
        {
            var citaInDb = _unitOfWork.Repository<Cita>().Consulta().FirstOrDefault(c => c.CitaId == cita.CitaId);

            if (citaInDb != null)
            {
                citaInDb.MedicoId = cita.MedicoId;
                citaInDb.PacienteId = cita.PacienteId;
                citaInDb.FechaCita = cita.FechaCita;
                citaInDb.Estado = cita.Estado;
                _unitOfWork.Repository<Cita>().Editar(citaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

        public int Eliminar(int citaId)
        {
            var citaInDb = _unitOfWork.Repository<Cita>().Consulta().FirstOrDefault(c => c.CitaId == citaId);

            if (citaInDb != null)
            {
                _unitOfWork.Repository<Cita>().Eliminar(citaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
