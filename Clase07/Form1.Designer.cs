
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.btnActualizar01 = new System.Windows.Forms.Button();
            this.btnEliminar03 = new System.Windows.Forms.Button();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.cbColumna = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar03 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.txtUsuario_id.Location = new System.Drawing.Point(713, 128);
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
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 41);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(449, 397);
            this.dgvUsuarios.TabIndex = 5;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(467, 68);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(95, 24);
            this.txtID.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(464, 47);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(22, 18);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(467, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 24);
            this.txtNombre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(467, 164);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(221, 24);
            this.txtApellidos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(467, 212);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(221, 24);
            this.txtCorreo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(464, 310);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(224, 24);
            this.txtIP.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Género";
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGenero.Location = new System.Drawing.Point(467, 260);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(221, 26);
            this.cbGenero.TabIndex = 17;
            // 
            // btnActualizar01
            // 
            this.btnActualizar01.Enabled = false;
            this.btnActualizar01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar01.Location = new System.Drawing.Point(464, 340);
            this.btnActualizar01.Name = "btnActualizar01";
            this.btnActualizar01.Size = new System.Drawing.Size(84, 32);
            this.btnActualizar01.TabIndex = 18;
            this.btnActualizar01.Text = "Actualizar";
            this.btnActualizar01.UseVisualStyleBackColor = true;
            this.btnActualizar01.Click += new System.EventHandler(this.btnActualizar01_Click);
            // 
            // btnEliminar03
            // 
            this.btnEliminar03.Enabled = false;
            this.btnEliminar03.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar03.Location = new System.Drawing.Point(604, 340);
            this.btnEliminar03.Name = "btnEliminar03";
            this.btnEliminar03.Size = new System.Drawing.Size(84, 32);
            this.btnEliminar03.TabIndex = 19;
            this.btnEliminar03.Text = "Eliminar";
            this.btnEliminar03.UseVisualStyleBackColor = true;
            this.btnEliminar03.Click += new System.EventHandler(this.btnEliminar03_Click);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriterio.Location = new System.Drawing.Point(12, 10);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(171, 24);
            this.txtCriterio.TabIndex = 20;
            // 
            // cbColumna
            // 
            this.cbColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColumna.FormattingEnabled = true;
            this.cbColumna.Items.AddRange(new object[] {
            "usuario_id",
            "nombre",
            "apellidos",
            "correo",
            "genero",
            "ip"});
            this.cbColumna.Location = new System.Drawing.Point(189, 8);
            this.cbColumna.Name = "cbColumna";
            this.cbColumna.Size = new System.Drawing.Size(182, 26);
            this.cbColumna.TabIndex = 21;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(377, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 32);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar03
            // 
            this.btnAgregar03.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar03.Location = new System.Drawing.Point(464, 378);
            this.btnAgregar03.Name = "btnAgregar03";
            this.btnAgregar03.Size = new System.Drawing.Size(224, 32);
            this.btnAgregar03.TabIndex = 23;
            this.btnAgregar03.Text = "Agregar";
            this.btnAgregar03.UseVisualStyleBackColor = true;
            this.btnAgregar03.Click += new System.EventHandler(this.btnAgregar03_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar03);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbColumna);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.btnEliminar03);
            this.Controls.Add(this.btnActualizar01);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar02);
            this.Controls.Add(this.txtUsuario_id);
            this.Controls.Add(this.btnEliminar01);
            this.Controls.Add(this.btnInsertar01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar01;
        private System.Windows.Forms.Button btnEliminar01;
        private System.Windows.Forms.NumericUpDown txtUsuario_id;
        private System.Windows.Forms.Button btnEliminar02;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Button btnActualizar01;
        private System.Windows.Forms.Button btnEliminar03;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.ComboBox cbColumna;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar03;
    }
}

