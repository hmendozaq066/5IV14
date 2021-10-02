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
    }
}
