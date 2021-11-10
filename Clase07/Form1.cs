using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase07.Modelos;

namespace Clase07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar01_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.Nombre = "Juanito 02";
            usuario.Apellidos = "Lopez";
            usuario.Correo = "jlopez@correo.com";
            usuario.Genero = "Male";
            usuario.IP = "192.168.1.5";

            if (usuario.Guardar())
            {
                MessageBox.Show("Usuario guardado");
            }
            else
            {
                MessageBox.Show("No se pudo guardar");
            }

        }

        private void btnEliminar01_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Usuario_id = 997;

            if (usuario.Eliminar())
                MessageBox.Show("Usuario eliminado");
            else
                MessageBox.Show("No se pudo eliminar el usuario");
            
        }

        private void btnEliminar02_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Usuario_id = Convert.ToInt32(txtUsuario_id.Value);

            if (usuario.Eliminar())
            {
                MessageBox.Show(string.Format("El ID {0} fue eliminado correctamente", txtUsuario_id.Value));
            }
            else
            {
                MessageBox.Show(string.Format("El ID {0} no se pudo eliminar", txtUsuario_id.Value));
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.Nombre = "Hector";
            usuario.Apellidos = "Mendoza";
            usuario.Correo = "otrocorreo@correo.com";
            usuario.Genero = "Male";
            usuario.IP = "0.0.0.0";
            usuario.Usuario_id = 156;

            if (usuario.Actualizar())
            {
                MessageBox.Show("Usuario actualizado");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar");
            }

        }
    }
}
