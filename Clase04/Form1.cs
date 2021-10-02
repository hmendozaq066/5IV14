using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "Hola";
            /*Random alea = new Random();
            button1.Location = new Point(alea.Next(0,200), alea.Next(0, 200));*/
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "Adios";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "admin" && txtPassword.Text == "123456")
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña inválidos");
            }
        }
    }
}
