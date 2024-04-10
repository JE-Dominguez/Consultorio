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
    public partial class VMenu : Form
    {
        AbrirEnMenu AF;
        public VMenu()
        {
            InitializeComponent();
            AF = new AbrirEnMenu();
        }

        private void BtnMedicos_Click(object sender, EventArgs e)
        {
            AF.Abrir(new VMedicos(), PnlContenedor, true);
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            AF.Abrir(new VPacientes(), PnlContenedor, true);
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            AF.Abrir(new VCitas(), PnlContenedor, true);
        }

        private void VMenu_Load(object sender, EventArgs e)
        {
            AF.Abrir(new VInicio(), PnlContenedor, true);
        }

        private void PtbLogo_Click(object sender, EventArgs e)
        {
            AF.Abrir(new VInicio(), PnlContenedor, true);
        }
    }
}
