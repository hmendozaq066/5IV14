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

        public string NombreCompleto()
        {
            return Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno;
        }

    }
}
