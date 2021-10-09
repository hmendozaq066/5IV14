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
    public partial class FRegistro : Form
    {
        public FRegistro()
        {
            InitializeComponent();
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMostrarContrasena.Checked == true)
            {
                txtContrasena.PasswordChar = '\0';
                txtRepetirContrasena.Enabled = false;
            }
            else
            {
                txtContrasena.PasswordChar = '*';
                txtRepetirContrasena.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Contenido");
            //MessageBox.Show("Contenido", "Titulo");
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OK);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OKCancel);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.YesNo);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.AbortRetryIgnore);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.RetryCancel);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.YesNoCancel);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //MessageBox.Show("Contenido", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            var resultado = MessageBox.Show("¿Deseas cancelar el registro?", "CLASE05", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                //Cierra el formulario actual
                Close();
            }

        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            if(chkMostrarContrasena.Checked == false && txtContrasena.Text != txtRepetirContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "CLASE05", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var usuario = new Usuario();
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Contrasena = txtContrasena.Text;
                usuario.CorreoElectronico = txtCorreo.Text;
                usuario.Telefono = txtTelefono.Text;
                usuario.FechaNacimiento = dtFechaNacimiento.Value;
                usuario.Genero = cbGenero.Text;
                usuario.Semestre = Convert.ToInt32(nSemestre.Value);

                if(usuario.Validar() == false)
                {
                    var errores = string.Join(Environment.NewLine, usuario.GetErrores());
                    MessageBox.Show("El se registro no se pudo completar por: " + Environment.NewLine + Environment.NewLine + errores, "CLASE05");
                }

            }
        }
    }
}
