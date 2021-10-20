
namespace Clase05
{
    partial class FPrincipal
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnRecargarUsuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 147);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(923, 335);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(788, 12);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(147, 36);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "&Agregar usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnRecargarUsuarios
            // 
            this.btnRecargarUsuarios.Location = new System.Drawing.Point(635, 12);
            this.btnRecargarUsuarios.Name = "btnRecargarUsuarios";
            this.btnRecargarUsuarios.Size = new System.Drawing.Size(147, 36);
            this.btnRecargarUsuarios.TabIndex = 2;
            this.btnRecargarUsuarios.Text = "Recargar usuarios";
            this.btnRecargarUsuarios.UseVisualStyleBackColor = true;
            this.btnRecargarUsuarios.Click += new System.EventHandler(this.btnRecargarUsuarios_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 558);
            this.Controls.Add(this.btnRecargarUsuarios);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FPrincipal";
            this.Text = "FPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnRecargarUsuarios;
    }
}