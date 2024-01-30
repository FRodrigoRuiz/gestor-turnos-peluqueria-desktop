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
    public partial class frmPanelEmpleados : Form
    {
        List<Empleado> listaEmpleados;
        public frmPanelEmpleados()
        {
            InitializeComponent();
        }

        private void frmPanelEmpleados_Load(object sender, EventArgs e)
        {
            Cargar();
            OcultarColumnas();
        }

        private void Cargar()
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            try
            {
                listaEmpleados = negocio.Lista();
                dgvEmpleados.DataSource = listaEmpleados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionEmpleados nuevo = new frmGestionEmpleados();
            nuevo.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            Empleado seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.IdEmpleado);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado seleccionado;
            seleccionado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;

            frmGestionEmpleados modificar = new frmGestionEmpleados(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void OcultarColumnas()
        {
            dgvEmpleados.Columns["IdEmpleado"].Visible = false;
        }
    }
}
