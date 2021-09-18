using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgenda.CAgenda
{
    class Contacto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Lista que contiene los errores en la validación
        /// </summary>
        private List<string> Errrores = new List<string>();
        
        /// <summary>
        /// Devuelve los errores producidos en la validación
        /// </summary>
        /// <returns>Lista con los errores de la validación</returns>
        public List<string> GetErrores()
        {
            return Errrores;
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                Errrores.Add("El nombres es un campo obligatorio");
            }
            if (string.IsNullOrEmpty(ApellidoPaterno))
            {
                Errrores.Add("El apellido paterno es un campo obligatorio");
            }
            if(Telefono.Length != 10)
            {
                Errrores.Add("El formato de teléfono no es correcto (deben ser 10 dígitos)");
            }
            if (ValidarCorreo(Email) == false)
            {
                Errrores.Add("El correo electrónico no es correcto");
            }

            return (Errrores.Count == 0) ? true : false;
        }

        private bool ValidarCorreo(string email)
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

        public string NombreCompleto()
        {
            return Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno;
        }

    }
}
