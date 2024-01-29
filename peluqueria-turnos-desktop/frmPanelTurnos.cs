using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace peluqueria_turnos_desktop
{
    public partial class frmPanelTurnos : Form
    {
        List<Turno> listaTurno;
        public frmPanelTurnos()
        {
            InitializeComponent();
        }

        private void frmPanelTurnos_Load(object sender, EventArgs e)
        {
            Cargar();
            OcultarColumnas();
        }

        private void Cargar()
        {
            TurnoNegocio negocio = new TurnoNegocio();

            try
            {
                listaTurno = negocio.Lista();
                dgvTurnos.DataSource = listaTurno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void OcultarColumnas()
        {
            dgvTurnos.Columns["IdTurno"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionTurnos nuevo = new frmGestionTurnos();
            nuevo.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Turno seleccionado;
            seleccionado = (Turno)dgvTurnos.CurrentRow.DataBoundItem;

            frmGestionTurnos modificar = new frmGestionTurnos(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            Turno seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar este articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Turno)dgvTurnos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.IdTurno);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvTurnos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvTurnos.CurrentRow != null)
            {
                Turno seleccionado = (Turno)dgvTurnos.CurrentRow.DataBoundItem;
            }
        }
    }
}
