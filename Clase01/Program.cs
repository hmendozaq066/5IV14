using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01
{
    class Program
    {
        /*
         BP:
        1.- Separar
        2.- Crear capas (carpetas)
        3.- Las clases NO deben tener espacios en blanco
        4.- Se recomienda usar nomenclatura camello alta
        5.- Las clases deben estar en Singular
        6.- Solo se puede usar letras del idioma inglés y números (No ñ ni acentos)

         */
        static void Main(string[] args)
        {
            var persona = new Clases.Persona(); //Instancia
                                                //Para acceder a los atributos, ponemos el nombre la clase
                                                //o instancia seguida de un punto .
                                                //Para establecer el valor de un atributo este debe estar 
                                                //a la izquierda del signo =

            Console.Write("Escribe tu apellido paterno: ");
            persona.ApellidoPaterno = Console.ReadLine();

            Console.Write("Escribe tu apellido materno: ");
            persona.ApellidoMaterno = Console.ReadLine();

            Console.Write("Escribe tu Nombre: ");
            persona.Nombre = Console.ReadLine();

            Console.WriteLine(persona.ObtenerCURP());

            //Console.WriteLine("Tu edad es: " + persona.CalcularEdad());

            /*persona.Nombre = "Héctor Mendoza";//Estableciendo un valor del atributo
            var nombre = persona.Nombre;//Obteniendo el valor de un atributo
            Console.WriteLine(nombre);
            Console.WriteLine(persona.Nombre);
            Console.ReadKey();*/

            /*Console.Write("Escribe tu nombre: ");
            persona.Nombre = Console.ReadLine();



            Console.Write("Escribe tu apellido paterno: ");
            persona.ApellidoPaterno = Console.ReadLine();

            Console.Write("Escribe tu apellido materno: ");
            persona.ApellidoMaterno = Console.ReadLine();

            Console.Write("Escribe tu CURP: ");
            persona.CURP = Console.ReadLine();

            Console.Write("Escribe tu tipo de sangre: ");
            persona.TipoSangre = Console.ReadLine();

            Console.Write("Escribe tu estatura: ");
            persona.Estatura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe tu peso: ");
            persona.Peso = float.Parse(Console.ReadLine());

            Console.Write("Fecha de nacimiento: ");
            var respuesta_fecha = Console.ReadLine();
            persona.FechaNacimiento = DateTime.Parse(respuesta_fecha); //Conversión de string a datetime

            Console.WriteLine(string.Format("Tu fecha de nacimiento es: {0}", persona.FechaNacimiento));

            Console.Write("¿Tienes alergías?(SI/NO): ");
            var respuesta = Console.ReadLine();

            if(respuesta.ToUpper().Substring(0, 1) == "S")
            {
                persona.Alergias = true;
            }
            else
            {
                persona.Alergias = false;
            }



            Console.WriteLine(string.Format("Alergias: {0}", persona.Alergias));

            Console.WriteLine(persona.Nombre);
            Console.WriteLine(persona.Nombre.ToUpper());
            Console.WriteLine(persona.Nombre.ToLower());

            int inicio, longitud;
            Console.WriteLine(string.Format("En que posición empieza la lectura max({0} letras): ", persona.Nombre.Length));
            inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Format("Cuantas letras quieres leer max({0} letras): ", persona.Nombre.Length));
            longitud = Convert.ToInt32(Console.ReadLine());
            //Substring trae una subcadena indicando la posición de inicio y la longitud
            Console.WriteLine(persona.Nombre.Substring(inicio, longitud));
            Console.WriteLine(persona.Nombre.Substring(0, persona.Nombre.Length - 5).ToLower().Substring(0,2));*/



            Console.ReadKey();

        }
    }
}
