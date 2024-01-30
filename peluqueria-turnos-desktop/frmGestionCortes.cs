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
    public partial class frmGestionCortes : Form
    {
        private Corte corte = null;
        public frmGestionCortes()
        {
            InitializeComponent();
        }

        public frmGestionCortes(Corte corte)
        {
            InitializeComponent();
            this.corte = corte;
            Text = "Modificar corte";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CorteNegocio negocio = new CorteNegocio();

            try
            {
                if (corte == null)
                    corte = new Corte();

                corte.TipoCorte = txtCortes.Text;

                if(corte.IdCorte != 0)
                {
                    negocio.Editar(corte);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.Crear(corte);
                    MessageBox.Show("Agregado Exitosamente");
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

        private void frmGestionCortes_Load(object sender, EventArgs e)
        {
            try
            {
                if(corte != null)
                {
                    txtCortes.Text = corte.TipoCorte;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
