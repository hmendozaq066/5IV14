using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Clase07.Modelos
{
    class Usuario
    {
        public int Usuario_id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Genero { get; set; }
        public string IP { get; set; }

        public static DataTable GetUsuarios()
        {
            //Primero la consulta
            string query = "SELECT usuario_id AS ID, Nombre, Apellidos, Correo, genero AS Género, IP FROM usuario;";
            //2do Obtener el SQLConnection
            var conexion = DAO.GetSqlConnection();
            //3ro para la consulta (SELECT) se usa un SqlDataAdapter
            var adapter = new SqlDataAdapter(query, conexion);
            //4to Creamos un objeto DatataTable
            var resultado = new DataTable();
            //5to LLenamos el DataTable
            adapter.Fill(resultado);
            //6to Cerramos la conexión
            conexion.Close();
            //Por último devolvemos el resultado
            return resultado;
        }

        public static DataTable GetBuscarUsuarios(string criterio, string columna)
        {
            //Primero la consulta
            string query = "SELECT usuario_id AS ID, Nombre, Apellidos, Correo, genero AS Género, IP FROM usuario WHERE " + columna + " LIKE @criterio;";
            //2do Obtener el SQLConnection
            var conexion = DAO.GetSqlConnection();
            //3ro para la consulta (SELECT) se usa un SqlDataAdapter
            var adapter = new SqlDataAdapter(query, conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@columna", columna);
            adapter.SelectCommand.Parameters.AddWithValue("@criterio", "%" + criterio + "%");
            //4to Creamos un objeto DatataTable
            var resultado = new DataTable();
            //5to LLenamos el DataTable
            adapter.Fill(resultado);
            //6to Cerramos la conexión
            conexion.Close();
            //Por último devolvemos el resultado
            return resultado;
        }

        public bool Guardar()
        {
            //Al ser GetSqlConnection un método estatico no es necesario realizar la instancia del objeto
            var conexion = DAO.GetSqlConnection();
            string query = "INSERT INTO usuario(nombre, apellidos, correo, genero, ip) VALUES(@nombre, @apellidos, @correo, @genero, @ip);";
            //El sqlCommand se usa para INSERT/UPDATE/DELETE
            var comando = new SqlCommand(query, conexion);
            //Si hay parametros se deben de indicar antes del ExecuteNonQuery
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@apellidos", Apellidos);
            comando.Parameters.AddWithValue("@correo", Correo);
            comando.Parameters.AddWithValue("@genero", Genero);
            comando.Parameters.AddWithValue("@ip", IP);

            int resultado = comando.ExecuteNonQuery();
            
            conexion.Close();
            return (resultado > 0) ? true : false;
        }

        public bool Eliminar()
        {
            var conexion = DAO.GetSqlConnection();
            string query = "DELETE FROM usuario WHERE usuario_id = @usuario_id;";

            var comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@usuario_id", Usuario_id);

            int resultado = comando.ExecuteNonQuery();
            conexion.Close();
            
            if (resultado > 0)
                return true;

            return false;
        }

        public bool Actualizar()
        {
            var conexion = DAO.GetSqlConnection();
            string query = "UPDATE usuario SET nombre = @nombre, apellidos = @apellidos, correo = @correo, genero = @genero, ip = @ip WHERE usuario_id = @usuario_id; ";

            var comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@apellidos", Apellidos);
            comando.Parameters.AddWithValue("@correo", Correo);
            comando.Parameters.AddWithValue("@genero", Genero);
            comando.Parameters.AddWithValue("@ip", IP);
            comando.Parameters.AddWithValue("@usuario_id", Usuario_id);

            int resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return (resultado > 0) ? true : false;

        }

    }
}
