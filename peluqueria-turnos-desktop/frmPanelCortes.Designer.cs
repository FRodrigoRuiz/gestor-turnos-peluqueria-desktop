namespace peluqueria_turnos_desktop
{
    partial class frmPanelCortes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnElliminarServicio = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Location = new System.Drawing.Point(151, 217);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnElliminarServicio
            // 
            this.btnElliminarServicio.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnElliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElliminarServicio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnElliminarServicio.Location = new System.Drawing.Point(255, 217);
            this.btnElliminarServicio.Name = "btnElliminarServicio";
            this.btnElliminarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnElliminarServicio.TabIndex = 7;
            this.btnElliminarServicio.Text = "Eliminar";
            this.btnElliminarServicio.UseVisualStyleBackColor = false;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarServicio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarServicio.Location = new System.Drawing.Point(38, 217);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarServicio.TabIndex = 6;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            // 
            // dgvServicios
            // 
            this.dgvServicios.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvServicios.Location = new System.Drawing.Point(38, 31);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(292, 150);
            this.dgvServicios.TabIndex = 5;
            // 
            // frmPanelCortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 259);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnElliminarServicio);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.dgvServicios);
            this.Name = "frmPanelCortes";
            this.Text = "frmPanelCortes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnElliminarServicio;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.DataGridView dgvServicios;
    }
}