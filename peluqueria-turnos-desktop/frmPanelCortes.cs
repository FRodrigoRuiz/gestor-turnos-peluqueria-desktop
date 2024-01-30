using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace peluqueria_turnos_desktop
{
    public partial class frmPanelCortes : Form
    {
        List<Corte> listaCortes;
        public frmPanelCortes()
        {
            InitializeComponent();
        }

        private void frmPanelCortes_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            CorteNegocio negocio = new CorteNegocio();
            try
            {
                listaCortes = negocio.Lista();
                dgvCortes.DataSource = listaCortes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregarCorte_Click(object sender, EventArgs e)
        {
            frmGestionCortes nuevo = new frmGestionCortes();
            nuevo.ShowDialog();
            Cargar();
        }

        private void btnEliminarCorte_Click(object sender, EventArgs e)
        {
            CorteNegocio negocio = new CorteNegocio();
            Corte seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Corte)dgvCortes.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.IdCorte);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnModificarCorte_Click(object sender, EventArgs e)
        {
            Corte seleccionado;
            seleccionado = (Corte)dgvCortes.CurrentRow.DataBoundItem;

            frmGestionCortes modificar = new frmGestionCortes(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void OcultarColumnas()
        {
            dgvCortes.Columns["IdCorte"].Visible = false;
        }
    }
}
