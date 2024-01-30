using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace peluqueria_turnos_desktop
{
    public partial class frmGestionEmpleados : Form
    {
        private Empleado empleado = null;
        public frmGestionEmpleados()
        {
            InitializeComponent();
        }

        public frmGestionEmpleados(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            Text = "Modificar empleado";
        }

        private void frmGestionEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                if (empleado != null)
                    txtNombreEmpleado.Text = empleado.Nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();

            try
            {
                if (empleado == null)
                    empleado = new Empleado();

                empleado.Nombre = txtNombreEmpleado.Text;

                if(empleado.IdEmpleado != 0)
                {
                    negocio.Editar(empleado);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.Crear(empleado);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
