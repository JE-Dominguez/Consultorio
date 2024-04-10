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
    public partial class VMedicos : Form
    {
        private NMedico nMedico;
        public VMedicos()
        {
            InitializeComponent();
            nMedico = new NMedico();
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
            string MedicoId = TxtID.Text;
            string nombres = TxtNombres.Text;
            string apellidos = TxtApellidos.Text; ;

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrWhiteSpace(nombres))
            {
                errorProvider1.SetError(TxtNombres, "Debe ingresar el nombre del medico");
                return;
            }
            if (string.IsNullOrEmpty(MedicoId) || string.IsNullOrWhiteSpace(MedicoId))
            {
                MedicoId = "0";
            }

            var medico = new Medico();
            if (int.Parse(MedicoId) != 0)
            {
                medico.MedicoId = int.Parse(MedicoId);
            }
            medico.Nombres = nombres;
            medico.Apellidos = apellidos;
            medico.Estado = ChkActivo.Checked;

            nMedico.GuardarMedico(medico);
            Cargar();
            Limpiar();
        }
        private void Cargar()
        {
            DgvDatos.DataSource = nMedico.ObtenerTodosLosMedicos();
        }
        private void Editar()
        {
            if (DgvDatos.SelectedCells.Count > 0)
            {
                int rowIndex = DgvDatos.SelectedCells[0].RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = DgvDatos.Rows[rowIndex].Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (checkBoxCell?.Value is true)
                {
                    if (DgvDatos.Rows[rowIndex].Cells["MedicoId"].Value is int id)
                    {
                        ConsultarPorId(id);
                    }
                }
            }
        }
        private void ConsultarPorId(int idmedico)
        {
            var medico = nMedico.ObtenerTodosLosMedicos().FirstOrDefault(c => c.MedicoId == idmedico);
            if (medico != null)
            {
                TxtID.Text = medico.MedicoId.ToString();
                TxtNombres.Text = medico.Nombres;
                TxtApellidos.Text = medico.Apellidos;
                ChkActivo.Checked = medico.Estado;
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
                    if (DgvDatos.Rows[rowIndex].Cells["MedicoId"].Value is int id)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este Medico?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nMedico.EliminarMedico(id);
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

        private void VMedicos_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
