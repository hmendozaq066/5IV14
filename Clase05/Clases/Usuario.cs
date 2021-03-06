using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Clases
{
    class Usuario
    {
        public int IDUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public int Semestre { get; set; }

        private List<string> Errores = new List<string>();
        //Función de flecha gorda o expresión lamdba 
        public List<string> GetErrores() => Errores;
        //La función de arriba es equivalente a la siguiente función
        /*public List<string> GetErrores()
        {
            return Errores;
        }*/

        public string GetLinea() => string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", IDUsuario, NombreUsuario, Contrasena, CorreoElectronico, Telefono, FechaNacimiento.ToString(), Genero, Semestre);

        public bool Guardar()
        {
            var archivo = new StreamWriter(@".\Contacto.txt", true);
            archivo.WriteLine(GetLinea());
            archivo.Close();
            return true;
        }

        public bool ValidarUsuario()
        {
            var usuarios = CargarUsuarios();
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.NombreUsuario == NombreUsuario && usuario.Contrasena == Contrasena)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Usuario> CargarUsuarios()
        {
            var listado = new List<Usuario>();
            var lector = new StreamReader(@".\Contacto.txt");
            string ln;

            while ((ln = lector.ReadLine()) != null)
            {
                string[] elementos = ln.Split('|');

                var usuario = new Usuario();

                usuario.IDUsuario = Convert.ToInt32(elementos[0]);
                usuario.NombreUsuario = elementos[1];
                usuario.Contrasena = elementos[2];
                usuario.CorreoElectronico = elementos[3];

                usuario.Telefono = elementos[4];
                usuario.FechaNacimiento = Convert.ToDateTime(elementos[5]);
                usuario.Genero = elementos[6];
                usuario.Semestre = Convert.ToInt32(elementos[7]);

                listado.Add(usuario);
            }
            lector.Close();
            return listado;
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombreUsuario)) Errores.Add("El nombre de usuario es requerido");

            var cadena_vacia = !string.IsNullOrEmpty(NombreUsuario); //Aqui negamos el resultado de isNullOrEmpty
            bool longitud = !(NombreUsuario.Length >= 5 && NombreUsuario.Length <= 10); //Aqui negamos el resultado de la operacion AND
            //&& Operador AND Y
            //|| operador OR o
            if (cadena_vacia && longitud) Errores.Add("El nombre de usuario debe ser mayor a 5 y menor a 10 letras");
            //if (!string.IsNullOrEmpty(NombreUsuario) && !(NombreUsuario.Length >= 5 && NombreUsuario.Length <= 10)) Errores.Add("El nombre de usuario debe ser mayor a 5 y menor a 10 letras");
            if (string.IsNullOrEmpty(Contrasena)) Errores.Add("La contraseña es requerida");
            if (!string.IsNullOrEmpty(Contrasena) && !(Contrasena.Length >= 5 && Contrasena.Length <= 10)) Errores.Add("La contraseña debe ser mayor a 5 y menor a 10 letras");
            if (string.IsNullOrEmpty(CorreoElectronico)) Errores.Add("El correo electrónico es requerido");
            if (IsValidEmail(CorreoElectronico) == false) Errores.Add("El formato de correo electrónico no es válido");

            if (FechaNacimiento == null)
            {
                Errores.Add("La fecha de nacimiento es obligatoria");
            }           

            if (string.IsNullOrEmpty(Genero))
            {
                Errores.Add("El género es obligatorio");
            }

            return (Errores.Count == 0) ? true : false;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
