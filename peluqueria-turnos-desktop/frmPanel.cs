using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peluqueria_turnos_desktop
{
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            frmPanelTurnos turnos = new frmPanelTurnos();
            turnos.ShowDialog();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            frmPanelCortes cortes = new frmPanelCortes();
            cortes.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmPanelEmpleados empleados = new frmPanelEmpleados();
            empleados.ShowDialog();
        }
    }
}
