
namespace Clase07
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertar01 = new System.Windows.Forms.Button();
            this.btnEliminar01 = new System.Windows.Forms.Button();
            this.txtUsuario_id = new System.Windows.Forms.NumericUpDown();
            this.btnEliminar02 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario_id)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar01
            // 
            this.btnInsertar01.Location = new System.Drawing.Point(713, 12);
            this.btnInsertar01.Name = "btnInsertar01";
            this.btnInsertar01.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar01.TabIndex = 0;
            this.btnInsertar01.Text = "Insertar";
            this.btnInsertar01.UseVisualStyleBackColor = true;
            this.btnInsertar01.Click += new System.EventHandler(this.btnInsertar01_Click);
            // 
            // btnEliminar01
            // 
            this.btnEliminar01.Location = new System.Drawing.Point(713, 41);
            this.btnEliminar01.Name = "btnEliminar01";
            this.btnEliminar01.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar01.TabIndex = 1;
            this.btnEliminar01.Text = "Eliminar";
            this.btnEliminar01.UseVisualStyleBackColor = true;
            this.btnEliminar01.Click += new System.EventHandler(this.btnEliminar01_Click);
            // 
            // txtUsuario_id
            // 
            this.txtUsuario_id.Location = new System.Drawing.Point(12, 12);
            this.txtUsuario_id.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtUsuario_id.Name = "txtUsuario_id";
            this.txtUsuario_id.Size = new System.Drawing.Size(75, 20);
            this.txtUsuario_id.TabIndex = 2;
            // 
            // btnEliminar02
            // 
            this.btnEliminar02.Location = new System.Drawing.Point(713, 70);
            this.btnEliminar02.Name = "btnEliminar02";
            this.btnEliminar02.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar02.TabIndex = 3;
            this.btnEliminar02.Text = "&Eliminar";
            this.btnEliminar02.UseVisualStyleBackColor = true;
            this.btnEliminar02.Click += new System.EventHandler(this.btnEliminar02_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(713, 99);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar02);
            this.Controls.Add(this.txtUsuario_id);
            this.Controls.Add(this.btnEliminar01);
            this.Controls.Add(this.btnInsertar01);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario_id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar01;
        private System.Windows.Forms.Button btnEliminar01;
        private System.Windows.Forms.NumericUpDown txtUsuario_id;
        private System.Windows.Forms.Button btnEliminar02;
        private System.Windows.Forms.Button btnActualizar;
    }
}

