using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public class AbrirEnMenu
    {
        private Form formActual;
        public void Abrir(Form formHijo, Panel panelContenedor, bool permiso)
        {
            if (permiso == true)
            {
                Cerrar();
                formActual = formHijo;

                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;

                panelContenedor.Controls.Add(formHijo);
                panelContenedor.Tag = formHijo;


                formHijo.Show();
            }
            else
            {
                MessageBox.Show("Sin Permisos", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void Cerrar()
        {
            if (formActual != null)
            {
                formActual.Close();
            }
        }
    }
}
