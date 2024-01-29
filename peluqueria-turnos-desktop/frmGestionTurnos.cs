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
using System.Globalization;

namespace peluqueria_turnos_desktop
{
    public partial class frmGestionTurnos : Form
    {
        private Turno turno = null;
        public frmGestionTurnos()
        {
            InitializeComponent();
        }
        public frmGestionTurnos(Turno turno)
        {
            InitializeComponent();
            this.turno = turno;
            Text = "Modificar turno";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGestionTurnos_Load(object sender, EventArgs e)
        {
            CorteNegocio corteNegocio = new CorteNegocio();
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

            try
            {
                cboCorte.DataSource = corteNegocio.Lista();
                cboCorte.ValueMember = "IdCorte";
                cboCorte.DisplayMember = "TipoCorte";

                cboEmpleado.DataSource = empleadoNegocio.Lista();
                cboEmpleado.ValueMember = "IdEmpleado";
                cboEmpleado.DisplayMember = "Nombre";

                if(turno != null)
                {
                    dtpFecha.Value = turno.Fecha;
                    txtCliente.Text = turno.NombreCliente;
                    cboCorte.SelectedValue = turno.Corte.IdCorte;
                    cboEmpleado.SelectedValue = turno.Empleado.IdEmpleado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();

            try
            {
                if (turno == null)
                    turno = new Turno();

                turno.Fecha = dtpFecha.Value;
                turno.NombreCliente = txtCliente.Text;
                turno.Corte = new Corte() { IdCorte = Convert.ToInt32(cboCorte.SelectedValue) };
                turno.Empleado = new Empleado() { IdEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue) };

                if(turno.IdTurno != 0)
                {
                    negocio.Editar(turno);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.Crear(turno);
                    MessageBox.Show("Creado exitosamente");
                }
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
