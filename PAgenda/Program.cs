using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAgenda.CAgenda;

namespace PAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            var agenda = new Agenda();
            agenda.AgregarContacto("Nombre", "Apellido paterno", "Apellido materno", DateTime.Now, "5556465066", "hmendoza@ipn.mx");
            //agenda.Contactos.Add(new Contacto { ID = 56, ApellidoMaterno = "", ApellidoPaterno = "", Email = "", Nombre = "" });
        }
    }
}
