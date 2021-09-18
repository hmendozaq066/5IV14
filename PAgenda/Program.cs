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
            agenda.AgregarContacto("Sergio", "Jimenez", "Rogel", DateTime.Now, "5556465066", "hmendoza@ipn.mx");
            agenda.AgregarContacto("Catalina", "Yela", "Avila", DateTime.Now, "5556465066", "hmendoza@ipn.mx");
            agenda.AgregarContacto("Axel Said", "Caballero", "Bautista", DateTime.Now, "5556465066", "hmendoza@ipn.mx");
            agenda.AgregarContacto("Axel", "Carmona", "Flores", DateTime.Now, "5556465066", "hmendoza@ipn.mx");
            agenda.AgregarContacto("Axel", "García", "Reyes", DateTime.Now, "5556465066", "hmendoza@ipn.mx");

            Contacto contacto = agenda.BuscarContactoPorNombre("lina");
            Console.WriteLine("Contacto localizado: " + contacto.NombreCompleto());

            //agenda.Contactos.Add(new Contacto { ID = 56, ApellidoMaterno = "", ApellidoPaterno = "", Email = "", Nombre = "" });
            /*if(agenda.AgregarContacto("", "", "Quiroz", DateTime.Now, "5556465066", ""))
            {
                Console.WriteLine("Contacto agregado correctamente");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el contacto");
                foreach(string error in agenda.GetErrores())
                {
                    Console.WriteLine("* " + error);
                }
            }*/
            Console.ReadKey();
        }
    }
}
