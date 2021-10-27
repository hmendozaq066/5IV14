using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clase06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            //1.- Using System.Data.SqlClient;
            //2.- Cadena de conexión
            //2.1 Orígenes de datos -> Agregar nuevo origen de datos -> Base de datos -> Siguiente -> conjunto de datos
            //-> Nueva conexión --> sql server -> nombre del servidor -> autenticación de windows -> selecciona la base de datos
            //-> Probar conexión -> Avanzadas y copiar la cadena que esta abajo -> cerrar todo
            //Data Source=DESKTOP-0HLSANU;Initial Catalog=Prueba02;Integrated Security=True

            //Para conectarte necesitas el objeto SqlConnection el cual recibe de parámetro la cadena de conexión
            var sqlCnn = new SqlConnection("Data Source=DESKTOP-0HLSANU;Initial Catalog=Prueba02;Integrated Security=True");
            //Abrimos la conexión
            sqlCnn.Open();

            MessageBox.Show("Conexión exitosa");
            //Cuando terminamos cerramos la conexión
            sqlCnn.Close();


            //Error 1.- Error relacionado con la red o específico de la instancia mientras se establecía una conexión con el servidor SQL Server. No se encontró el servidor o éste no estaba accesible. Compruebe que el nombre de la instancia es correcto y que SQL Server está configurado para admitir conexiones remotas. (provider: Named Pipes Provider, error: 40 - No se pudo abrir una conexión con SQL Server)
            //Significa que el nombre del servidor no esta bien escrito (Data source), que no tiene instalado el SQL o el firewall lo esta bloqueando
            //Solución: Hay que verificar que el nombre del servidor sea el correcto

            //Cannot open database "Prueba03" requested by the login. The login failed. Login failed for user 'SERVIDOR\usuario'
            //Significa que el nombre de la base datos no esta bien escrita (Initial Catalog) o no existe
            //Solución: Hay que verificar que el nombre de la base de datos sea la correcta.

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //PASOS PARA HACER UNA CONSULTA DE TIPO SELECT

            //Para conectarte necesitas el objeto SqlConnection el cual recibe de parámetro la cadena de conexión
            var sqlCnn = new SqlConnection("Data Source=DESKTOP-0HLSANU;Initial Catalog=Prueba02;Integrated Security=True");
            //Abrimos la conexión
            sqlCnn.Open();
            //Para consultas (SELECT) se usa el objeto SqlDataAdapter 
            //Nos pide primero la consulta (query) después el objeto sqlConnection
            var sqlAdapter = new SqlDataAdapter(txtConsulta.Text, sqlCnn);
            //Hacemos una instancia del objeto DataTable en el cual se almacenarán los resultados
            var resultados = new DataTable();
            //El objeto sqlDataAdapter tiene un método que se llama Fill el cual 
            //llena una tabla (hay pasarla como un argmento)
            sqlAdapter.Fill(resultados);
            //DataGridView Tiene la propiedad DataSource que es donde indicamos los datos a mostrar
            dgvResultados.DataSource = resultados;

            //Cuando terminamos cerramos la conexión
            sqlCnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PASOS PARA HACER UNA CONSULTA DE TIPO SELECT

            //Para conectarte necesitas el objeto SqlConnection el cual recibe de parámetro la cadena de conexión
            var sqlCnn = new SqlConnection("Data Source=DESKTOP-0HLSANU;Initial Catalog=Prueba02;Integrated Security=True");
            //Abrimos la conexión
            sqlCnn.Open();
            //Para consultas (SELECT) se usa el objeto SqlDataAdapter 
            //Nos pide primero la consulta (query) después el objeto sqlConnection
            var sqlAdapter = new SqlDataAdapter("SELECT * FROM usuario", sqlCnn);
            //Hacemos una instancia del objeto DataTable en el cual se almacenarán los resultados
            var resultados = new DataTable();
            //El objeto sqlDataAdapter tiene un método que se llama Fill el cual 
            //llena una tabla (hay pasarla como un argmento)
            sqlAdapter.Fill(resultados);
            //DataGridView Tiene la propiedad DataSource que es donde indicamos los datos a mostrar
            dgvResultados.DataSource = resultados;

            //Cuando terminamos cerramos la conexión
            sqlCnn.Close();
        }

        private void btnInsertarConcatenar_Click(object sender, EventArgs e)
        {
            //Aquí vamos a insertar un registro a una tabla concatenando una cadena
            //ESTO NO ES RECOMENDABLE YA QUE ES MUY INSEGURO (HACKEAR)
            //Primero siempre debemos tener la conexión lista
            var conexion = new SqlConnection("Data Source=DESKTOP-0HLSANU;Initial Catalog=Prueba02;Integrated Security=True");
            conexion.Open();
            //Para insertar, actualizar o borrar se debe utilizar el objeto SQLCommand
            var query = string.Format("INSERT INTO usuario(nombre, apellidos, correo, ip, genero) VALUES('{0}', '{1}', '{2}', '{3}', '{4}'); ",
                txtNombre.Text,txtApellidos.Text, txtCorreo.Text, txtIP.Text, txtGenero.Text);
            txtConsulta.Text = query;
            var comando = new SqlCommand(query, conexion);
            //ExecuteNonQuery Ejecuta el query especificado y nos indica el numero de registros insertados/modificados/afectados
            var resultado = comando.ExecuteNonQuery();
            if(resultado > 0)
            {
                MessageBox.Show("El registro se inserto correctamente");
            }
            else
            {
                MessageBox.Show("El registro no se pudo insertar");
            }

        }

        private void btnValidarUsuario_Click(object sender, EventArgs e)
        {
            var conexion = new SqlConnection("Data Source=DESKTOP-0HLSANU;Initial Catalog=Prueba02;Integrated Security=True");
            conexion.Open();
            var query = string.Format("SELECT * FROM usuario WHERE usuario_id = {0} AND correo = '{1}';", txtID.Text, txtCorreoUsuario.Text);
            txtConsulta.Text = query;

            var adapter = new SqlDataAdapter(query, conexion);
            var resultados = new DataTable();
            adapter.Fill(resultados);

            if(resultados.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " +  resultados.Rows[0]["nombre"].ToString());
            }
            else
            {
                MessageBox.Show("Correo y/o ID no válidos ");
            }
        }

        private void btnInsertarCorrecto_Click(object sender, EventArgs e)
        {
            //Aquí vamos a insertar un registro a una tabla concatenando una cadena
            //ESTA ES la forma recomendada
            //Primero siempre debemos tener la conexión lista
            var conexion = new SqlConnection("Data Source=DESKTOP-0HLSANU;Initial Catalog=Prueba02;Integrated Security=True");
            conexion.Open();
            //Para insertar, actualizar o borrar se debe utilizar el objeto SQLCommand
            //El query para insertar en la parte de VALUES debe llevar el nombre de lo campos con un @ al inicio
            var query = "INSERT INTO usuario(nombre, apellidos, correo, ip, genero) VALUES(@nombre, @apellidos, @correo, @ip, @genero);";
            txtConsulta.Text = query;
            var comando = new SqlCommand(query, conexion);
            //Debo pasar los parámetros

            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
            comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
            comando.Parameters.AddWithValue("@ip", txtIP.Text);
            comando.Parameters.AddWithValue("@genero", txtGenero.Text);

            //ExecuteNonQuery Ejecuta el query especificado y nos indica el numero de registros insertados/modificados/afectados
            var resultado = comando.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("El registro se inserto correctamente");
            }
            else
            {
                MessageBox.Show("El registro no se pudo insertar");
            }
        }

        private void btnValidarSeguro_Click(object sender, EventArgs e)
        {
            var conexion = new SqlConnection("Data Source=DESKTOP-0HLSANU;Initial Catalog=Prueba02;Integrated Security=True");
            conexion.Open();
            var query = "SELECT * FROM usuario WHERE usuario_id = @usuario_id AND correo = @correo;";
            txtConsulta.Text = query;

            var adapter = new SqlDataAdapter(query, conexion);
            //Aquí se agregan los parámetros del adapter
            adapter.SelectCommand.Parameters.AddWithValue("@usuario_id", txtID.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@correo", txtCorreoUsuario.Text);

            var resultados = new DataTable();
            adapter.Fill(resultados);

            if (resultados.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + resultados.Rows[0]["nombre"].ToString());
            }
            else
            {
                MessageBox.Show("Correo y/o ID no válidos ");
            }
        }
    }
}
