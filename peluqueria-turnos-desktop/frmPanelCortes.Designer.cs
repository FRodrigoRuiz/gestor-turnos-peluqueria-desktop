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
            this.btnModificarCorte = new System.Windows.Forms.Button();
            this.btnEliminarCorte = new System.Windows.Forms.Button();
            this.btnAgregarCorte = new System.Windows.Forms.Button();
            this.dgvCortes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarCorte
            // 
            this.btnModificarCorte.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnModificarCorte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarCorte.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModificarCorte.Location = new System.Drawing.Point(151, 217);
            this.btnModificarCorte.Name = "btnModificarCorte";
            this.btnModificarCorte.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCorte.TabIndex = 8;
            this.btnModificarCorte.Text = "Modificar";
            this.btnModificarCorte.UseVisualStyleBackColor = false;
            this.btnModificarCorte.Click += new System.EventHandler(this.btnModificarCorte_Click);
            // 
            // btnEliminarCorte
            // 
            this.btnEliminarCorte.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnEliminarCorte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCorte.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarCorte.Location = new System.Drawing.Point(255, 217);
            this.btnEliminarCorte.Name = "btnEliminarCorte";
            this.btnEliminarCorte.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCorte.TabIndex = 7;
            this.btnEliminarCorte.Text = "Eliminar";
            this.btnEliminarCorte.UseVisualStyleBackColor = false;
            this.btnEliminarCorte.Click += new System.EventHandler(this.btnEliminarCorte_Click);
            // 
            // btnAgregarCorte
            // 
            this.btnAgregarCorte.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregarCorte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCorte.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarCorte.Location = new System.Drawing.Point(38, 217);
            this.btnAgregarCorte.Name = "btnAgregarCorte";
            this.btnAgregarCorte.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCorte.TabIndex = 6;
            this.btnAgregarCorte.Text = "Agregar";
            this.btnAgregarCorte.UseVisualStyleBackColor = false;
            this.btnAgregarCorte.Click += new System.EventHandler(this.btnAgregarCorte_Click);
            // 
            // dgvCortes
            // 
            this.dgvCortes.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvCortes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCortes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCortes.Location = new System.Drawing.Point(38, 31);
            this.dgvCortes.Name = "dgvCortes";
            this.dgvCortes.Size = new System.Drawing.Size(292, 150);
            this.dgvCortes.TabIndex = 5;
            // 
            // frmPanelCortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 259);
            this.Controls.Add(this.btnModificarCorte);
            this.Controls.Add(this.btnEliminarCorte);
            this.Controls.Add(this.btnAgregarCorte);
            this.Controls.Add(this.dgvCortes);
            this.Name = "frmPanelCortes";
            this.Text = "frmPanelCortes";
            this.Load += new System.EventHandler(this.frmPanelCortes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarCorte;
        private System.Windows.Forms.Button btnEliminarCorte;
        private System.Windows.Forms.Button btnAgregarCorte;
        private System.Windows.Forms.DataGridView dgvCortes;
    }
}