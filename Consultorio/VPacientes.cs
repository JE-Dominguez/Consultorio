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
    public partial class VPacientes : Form
    {
        private NPaciente nPaciente;
        public VPacientes()
        {
            InitializeComponent();
            nPaciente = new NPaciente();
        }
        private void Limpiar()
        {
            TxtID.Text = "";
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            ChkActivo.Checked = false;
            errorProvider1.Clear();
        }
        private void Guardar()
        {
            string PacienteId = TxtID.Text;
            string nombres = TxtNombres.Text;
            string apellidos = TxtApellidos.Text; ;

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrWhiteSpace(nombres))
            {
                errorProvider1.SetError(TxtNombres, "Debe ingresar el nombre del paciente");
                return;
            }
            if (string.IsNullOrEmpty(PacienteId) || string.IsNullOrWhiteSpace(PacienteId))
            {
                PacienteId = "0";
            }

            var paciente = new Paciente();
            if (int.Parse(PacienteId) != 0)
            {
                paciente.PacienteId = int.Parse(PacienteId);
            }
            paciente.Nombres = nombres;
            paciente.Apellidos = apellidos;
            paciente.Estado = ChkActivo.Checked;

            nPaciente.GuardarPaciente(paciente);
            Cargar();
            Limpiar();
        }
        private void Cargar()
        {
            DgvDatos.DataSource = nPaciente.ObtenerTodosLosPacientes();
        }
        private void Editar()
        {
            if (DgvDatos.SelectedCells.Count > 0)
            {
                int rowIndex = DgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DgvDatos.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    if (DgvDatos.Rows[rowIndex].Cells["PacienteId"].Value is int id)
                    {
                        ConsultarPorId(id);
                    }
                }
            }
        }
        private void ConsultarPorId(int idpaciente)
        {
            var paciente = nPaciente.ObtenerTodosLosPacientes().FirstOrDefault(c => c.PacienteId == idpaciente);
            if (paciente != null)
            {
                TxtID.Text = paciente.PacienteId.ToString();
                TxtNombres.Text = paciente.Nombres;
                TxtApellidos.Text = paciente.Apellidos;
                ChkActivo.Checked = paciente.Estado;
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
                    if (DgvDatos.Rows[rowIndex].Cells["PacienteId"].Value is int id)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este Paciente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nPaciente.EliminarPaciente(id);
                            Cargar();
                            Limpiar();
                        }
                    }
                }
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

        private void VPacientes_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
