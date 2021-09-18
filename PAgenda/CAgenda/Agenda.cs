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
        private List<string> Errores = new List<string>();//2

        public List<string> GetErrores()//3
        {
            return Errores;
        }

        public List<Contacto> GetContactos() //Getters y Setters --> encapsulamiento de código
        {
            return Contactos;
        }

        public Contacto BuscarContactoPorNombre(string nombre, bool parcial = true)
        {
            foreach(Contacto cto in Contactos)
            {
                if(parcial == true)
                {
                    if(cto.Nombre.ToUpper().Trim().IndexOf(nombre.ToUpper().Trim()) >= 0)
                    {
                        return cto;
                    }
                }
                else
                {
                    if(cto.Nombre.ToUpper().Trim() == nombre.ToUpper().Trim())
                    {
                        return cto;
                    }
                }
            }
            return null;
        }

        /*public List<Contacto> BuscarContactosPorNombre(string criterio, bool parcial = true)
        {

        }*/

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

            if (contacto.Validar())
            {
                Contactos.Add(contacto);
                return true;
            }
            Errores = contacto.GetErrores();//1
            return false;            
        }

    }
}
