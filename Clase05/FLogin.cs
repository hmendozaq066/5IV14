using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Hide();//Oculta el formulario actual
            var fPrincipal = new FPrincipal();
            fPrincipal.StartPosition = FormStartPosition.CenterScreen;  //Aquí cambiamos propiedades en tiempo de ejecución
                                                                        //En este caso cambiamos la posición inicial del formulario
            fPrincipal.Show(); //Show muestra el formulario indicado
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var fRegistro = new FRegistro();
            fRegistro.StartPosition = FormStartPosition.CenterScreen;
            fRegistro.ShowDialog(); //ShowDialog muestra el formulario, pero no puedes ver en formulario que lo ejecutó
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '\0';
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '*';
        }
    }
}
