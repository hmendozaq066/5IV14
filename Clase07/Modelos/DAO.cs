using System;
using System.Collections.Generic;
//1.- Primero poner el using
using System.Data;
using System.Data.SqlClient;

namespace Clase07.Modelos
{
    //Data Access Object
    class DAO
    {
        public static SqlConnection GetSqlConnection()
        {
            //2.- Crear el objeto SQLConnection, este necesita la cadena de conexión
            //Lo pueden buscar en https://www.connectionstrings.com/sql-server/
            //Se selecciona el https://www.connectionstrings.com/microsoft-data-sqlclient/trusted-connection/
            //Se debe cambiar el Server y el DataBase
            var conexion = new SqlConnection("Server=DESKTOP-0HLSANU;Database=Prueba02;Trusted_Connection=True;");
            conexion.Open();
            return conexion;
        }
    }
}
