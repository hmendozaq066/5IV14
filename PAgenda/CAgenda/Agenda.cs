using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgenda.CAgenda
{
    class Agenda
    {
        private List<Contacto> Contactos = new List<Contacto>();

        public List<Contacto> GetContactos() //Getters y Setters --> encapsulamiento de código
        {
            return Contactos;
        }

        public bool AgregarContacto(string Nombre, string ApellidoPaterno, 
            string ApellidoMaterno, DateTime FechaNacimiento, string Telefono, string Email)
        {
            var contacto = new Contacto();
            contacto.ID = Contactos.Count + 1;
            contacto.Nombre = Nombre;
            contacto.ApellidoPaterno = ApellidoPaterno;
            contacto.ApellidoMaterno = ApellidoMaterno;
            contacto.FechaNacimiento = FechaNacimiento;
            contacto.Telefono = Telefono;
            contacto.Email = Email;

            Contactos.Add(contacto);
            return true;
        }

    }
}
