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
    }
}
