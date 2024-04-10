using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Datos.Core;

namespace Capa_Datos.Modelos
{
    public class DPaciente
    {
        private readonly UnitOfWork _unitOfWork;

        public DPaciente()
        {
            _unitOfWork = new UnitOfWork();
        }

        public List<Paciente> ObtenerTodosLosPacientes()
        {
            return _unitOfWork.Repository<Paciente>().Consulta().ToList();
        }

        public int Agregar(Paciente paciente)
        {
            paciente.FechaIngreso = DateTime.Now;
            _unitOfWork.Repository<Paciente>().Agregar(paciente);
            return _unitOfWork.Guardar();
        }

        public int Editar(Paciente paciente)
        {
            var pacienteInDb = _unitOfWork.Repository<Paciente>().Consulta().FirstOrDefault(p => p.PacienteId == paciente.PacienteId);

            if (pacienteInDb != null)
            {
                pacienteInDb.Nombres = paciente.Nombres;
                pacienteInDb.Apellidos = paciente.Apellidos;
                pacienteInDb.Estado = paciente.Estado;
                _unitOfWork.Repository<Paciente>().Editar(pacienteInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

        public int Eliminar(int pacienteId)
        {
            var pacienteInDb = _unitOfWork.Repository<Paciente>().Consulta().FirstOrDefault(p => p.PacienteId == pacienteId);

            if (pacienteInDb != null)
            {
                _unitOfWork.Repository<Paciente>().Eliminar(pacienteInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
