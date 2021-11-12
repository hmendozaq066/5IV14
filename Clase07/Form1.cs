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

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Usuario.GetUsuarios();
            //dgvUsuarios.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Al momento de dar doble clic en el GridView Se llena el formulario 
            //que esta a la derecha con los datos seleccionados
            //MessageBox.Show(dgvUsuarios.SelectedCells[0].Value.ToString());
            txtID.Text = dgvUsuarios.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
            txtApellidos.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
            txtCorreo.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
            cbGenero.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
            txtIP.Text = dgvUsuarios.SelectedCells[5].Value.ToString();
            btnActualizar01.Enabled = true;
            btnEliminar03.Enabled = true;
            txtID.ReadOnly = true;
            //Con focus se establece el control que tendra el FOCO es decir el activo
            txtNombre.Focus();
        }

        private void btnActualizar01_Click(object sender, EventArgs e)
        {
            //Actualizar los datos
            var usuario = new Usuario();
            usuario.Usuario_id = Convert.ToInt32(txtID.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.Genero = cbGenero.Text;
            usuario.IP = txtIP.Text;

            if (usuario.Actualizar())
            {
                btnActualizar01.Enabled = false;
                btnEliminar03.Enabled = false;
                txtID.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtCorreo.Clear();
                txtCriterio.Clear();
                cbColumna.Text = "";
                cbGenero.Text = "";
                txtIP.Clear();
                dgvUsuarios.DataSource = Usuario.GetUsuarios();
                MessageBox.Show("Registro actualizado");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el registro");
            }

        }

        private void btnEliminar03_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Deseas eliminar el registro?", "Clase07", MessageBoxButtons.YesNo);

            if(resultado == DialogResult.Yes)
            {
                var usuario = new Usuario();
                usuario.Usuario_id = Convert.ToInt32(txtID.Text);

                if (usuario.Eliminar())
                {
                    btnActualizar01.Enabled = false;
                    btnEliminar03.Enabled = false;
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellidos.Clear();
                    txtCorreo.Clear();
                    txtCriterio.Clear();
                    cbColumna.Text = "";
                    cbGenero.Text = "";
                    txtIP.Clear();
                    dgvUsuarios.DataSource = Usuario.GetUsuarios();
                    MessageBox.Show("Usuario eliminado");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbColumna.Text))
            {
                dgvUsuarios.DataSource = Usuario.GetBuscarUsuarios(txtCriterio.Text, cbColumna.Text);
            }
        }

        private void btnAgregar03_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.Nombre = txtNombre.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.Genero = cbGenero.Text;
            usuario.IP = txtIP.Text;

            if (usuario.Guardar())
            {
                btnActualizar01.Enabled = false;
                btnEliminar03.Enabled = false;
                txtID.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtCorreo.Clear();
                txtCriterio.Clear();
                cbColumna.Text = "";
                cbGenero.Text = "";
                txtIP.Clear();
                dgvUsuarios.DataSource = Usuario.GetUsuarios();
                MessageBox.Show("Usuario guardado");
            }
            else
            {
                MessageBox.Show("No se pudo guardar");
            }
        }
    }
}
