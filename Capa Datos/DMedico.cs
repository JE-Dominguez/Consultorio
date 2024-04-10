using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Datos.Core;

namespace Capa_Datos.Modelos
{
    public class DMedico
    {
        private readonly UnitOfWork _unitOfWork;

        public DMedico()
        {
            _unitOfWork = new UnitOfWork();
        }

        public List<Medico> ObtenerTodosLosMedicos()
        {
            return _unitOfWork.Repository<Medico>().Consulta().ToList();
        }

        public int Agregar(Medico medico)
        {
            medico.FechaIngreso = DateTime.Now;
            _unitOfWork.Repository<Medico>().Agregar(medico);
            return _unitOfWork.Guardar();
        }

        public int Editar(Medico medico)
        {
            var medicoInDb = _unitOfWork.Repository<Medico>().Consulta().FirstOrDefault(m => m.MedicoId == medico.MedicoId);

            if (medicoInDb != null)
            {
                medicoInDb.Nombres = medico.Nombres;
                medicoInDb.Apellidos = medico.Apellidos;
                medicoInDb.Estado = medico.Estado;
                _unitOfWork.Repository<Medico>().Editar(medicoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

        public int Eliminar(int medicoId)
        {
            var medicoInDb = _unitOfWork.Repository<Medico>().Consulta().FirstOrDefault(m => m.MedicoId == medicoId);

            if (medicoInDb != null)
            {
                _unitOfWork.Repository<Medico>().Eliminar(medicoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
