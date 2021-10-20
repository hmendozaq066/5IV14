using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase05.Clases;

namespace Clase05
{
    public partial class FPrincipal : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public FPrincipal()
        {
            InitializeComponent();
        }

        //El evento load se ejecuta cuando se carga el formulario, antes de mostrarse
        //Solo se ejecuta una sola vez
        private void FPrincipal_Load(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuarios = usuario.CargarUsuarios();
            dgvUsuarios.DataSource = usuarios;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var fRegistro = new FRegistro();
            fRegistro.ShowDialog();
        }

        private void btnRecargarUsuarios_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuarios = usuario.CargarUsuarios();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios;
        }

        private void FPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Deseas salir?", "CLASE05", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //e.Cancel = false;
                this.FormClosing -= FPrincipal_FormClosing;
                Application.Exit();
            }
        }
    }
}
