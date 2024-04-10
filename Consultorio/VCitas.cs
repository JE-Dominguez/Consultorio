using Capa_Datos.Modelos;
using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class VCitas : Form
    {
        private NCita nCita;
        private NMedico nMedico;
        private NPaciente nPaciente;
        public VCitas()
        {
            InitializeComponent();
            nCita = new NCita();
            nMedico = new NMedico();
            nPaciente = new NPaciente();
        }
        private void Limpiar()
        {
            TxtID.Text = "";
            CmbIdMedico.SelectedValue = -1;
            CmbIdPaciente.SelectedValue = -1;
            ChkActivo.Checked = false;
            DtpFechaCita.Value = DateTime.Now;
            errorProvider1.Clear();
        }
        private void Guardar()
        {
            string CitaId = TxtID.Text;
            if (CmbIdMedico.SelectedValue == null)
            {
                errorProvider1.SetError(CmbIdMedico, "Debe ingresar el nombre del Medico");
                return;
            }
            if (CmbIdPaciente.SelectedValue == null)
            {
                errorProvider1.SetError(CmbIdPaciente, "Debe ingresar el nombre del Paciente");
                return;
            }
            if (string.IsNullOrEmpty(CitaId) || string.IsNullOrWhiteSpace(CitaId))
            {
                CitaId = "0";
            }

            string PacieteId = CmbIdPaciente.SelectedValue.ToString();
            string MedicoId = CmbIdMedico.SelectedValue.ToString();

            var cita = new Cita();
            if (int.Parse(CitaId) != 0)
            {
                cita.CitaId = int.Parse(CitaId);
            }
            cita.MedicoId = int.Parse(MedicoId);
            cita.PacienteId = int.Parse(PacieteId);
            cita.FechaCita = DtpFechaCita.Value;
            cita.Estado = ChkActivo.Checked;

            nCita.GuardarCita(cita);
            Cargar();
            Limpiar();
        }
        private void Cargar()
        {
            var citas = nCita.ObtenerTodasLasCitas().ToList()
                                     .Select(prd => new { prd.CitaId, Paciente = prd.Paciente.Nombres + " " + prd.Paciente.Apellidos, Medico = prd.Medico.Nombres + " " + prd.Medico.Apellidos, prd.FechaCita, prd.Estado })
                                     .ToList();

            DgvDatos.DataSource = citas.ToList();
        }
        private void Editar()
        {
            if (DgvDatos.SelectedCells.Count > 0)
            {
                int rowIndex = DgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DgvDatos.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    if (DgvDatos.Rows[rowIndex].Cells["CitaId"].Value is int id)
                    {
                        ConsultarPorId(id);
                    }
                }
            }
        }
        private void ConsultarPorId(int idcita)
        {
            var cita = nCita.ObtenerTodasLasCitas().FirstOrDefault(c => c.CitaId == idcita);
            if (cita != null)
            {
                TxtID.Text = cita.CitaId.ToString();
                CmbIdMedico.SelectedValue = cita.MedicoId;
                CmbIdPaciente.SelectedValue = cita.PacienteId;
                DtpFechaCita.Value = cita.FechaCita;
                ChkActivo.Checked = cita.Estado;
            }
        }
        private void Eliminar()
        {
            if (DgvDatos.SelectedCells.Count > 0)
            {
                int rowIndex = DgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DgvDatos.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    if (DgvDatos.Rows[rowIndex].Cells["CitaId"].Value is int id)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este cita?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nCita.EliminarCita(id);
                            Cargar();
                            Limpiar();
                        }
                    }
                }
            }
        }
        private void Combo()
        {
            try
            {
                var Medicos = nMedico.ObtenerTodosLosMedicos().Select(m => new { m.MedicoId, Nombre = m.Nombres + " " + m.Apellidos }).ToList();
                var Pacientes = nPaciente.ObtenerTodosLosPacientes().Select(m => new { m.PacienteId, Nombre = m.Nombres + " " + m.Apellidos }).ToList();

                if (Medicos != null && Medicos.Any() && Pacientes != null && Pacientes.Any())
                {
                    CmbIdMedico.DataSource = Medicos;
                    CmbIdMedico.DisplayMember = "Nombre";
                    CmbIdMedico.ValueMember = "MedicoId";

                    CmbIdPaciente.DataSource = Pacientes;
                    CmbIdPaciente.DisplayMember = "Nombre";
                    CmbIdPaciente.ValueMember = "PacienteId";
                }
                else
                {
                    MessageBox.Show("No hay Medicos o pacientes disponibles. Debe agregar medicos y pacientes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al cargar los Medicos o pacientes: {ex.Message}");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Otros()
        {
            CmbIdMedico.SelectedValue = -1;
            CmbIdPaciente.SelectedValue = -1;
            DtpFechaCita.Value = DateTime.Now;
        }

        private void VCitas_Load(object sender, EventArgs e)
        {
            Cargar();
            Combo();
            Otros();
        }
    }
}
