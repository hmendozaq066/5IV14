using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* LIST
             * List<T> class in C# represents a strongly typed list of objects. List<T> provides 
             * functionality to create a list of objects, find list items, sort list, search list, 
             * and manipulate list items.
             * Sintaxis
             * List<Objeto> Nombre = new List<Objeto>();
             */

            List<string> Cadenas = new List<string>();      //Lista de cadenas
            List<int> Enteros = new List<int>();            //Lista de Enteros
            List<bool> Boleanos = new List<bool>();         //Lista de Boleanos
            List<float> Flotantes = new List<float>();      //Lista de números flotantes
            List<Persona> Personas = new List<Persona>();   //Lista de Elementos de la clase persona

            //Para agregar elementos de una lista existe un método llamado Add

            Cadenas.Add("Dell");
            Cadenas.Add("HP");
            Cadenas.Add("Lenovo");

            foreach (string item in Cadenas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("************************************************");
            for (int i = 0; i < Cadenas.Count; i++)
            {
                Console.WriteLine(Cadenas[i]);
            }

            //foreach
            /*
             * The foreach statement in C# iterates through a collection of items 
             * such as an array or list, The foreach body must be enclosed in {} 
             * braces unless it consists of a single statement
             * Sintaxis
             * foreach(Tipo nombre in Colección/Lista/Array){
             *      Código
             * }
             */

            Enteros.Add(1);
            Enteros.Add(2);
            Enteros.Add(3);
            Enteros.Add(4);
            Enteros.Add(5);
            Enteros.Add(6);
            Enteros.Add(7);
            Enteros.Add(8);
            Enteros.Add(9);

            int suma = 0;
            foreach (int numero in Enteros)
            {
                if (numero % 2 == 0)
                {
                    suma += numero;
                }
            }
            Console.WriteLine("La suma es: " + suma);
            //LINQ -- Expresiones lamba
            var pares = Enteros.Where(numero => numero % 2 == 0).ToList().Sum();
            Console.WriteLine("La suma por LINQ es: " + pares);

            Boleanos.Add(true);
            Boleanos.Add(false);
            Boleanos.Add(true);
            Boleanos.Add(true);

            Console.WriteLine("********************************************************************");

            Flotantes.Add(3.5f);

            Personas.Add(new Persona { Apellidos = "Apellidos", Nombre = "Nombre", ID = 1 });//Forma 1
            Personas.Add(new Persona { Apellidos = "Magón", Nombre = "Ricardo", ID = 3 });//Forma 1

            Persona per = new Persona();//Forma 2 //Para buscar podemos usar LINQ
            per.ID = 2;
            per.Nombre = "Ricardo";
            per.Apellidos = "Flores";
            Personas.Add(per);

            var busqueda = Personas.Where(item => item.ID > 0 && item.Nombre == "Ricardo").ToList();

            foreach(Persona elemento in busqueda)
            {
                Console.WriteLine("ID " + elemento.ID);
                Console.WriteLine("Nombre " + elemento.Nombre);
                Console.WriteLine("Apellidos " + elemento.Apellidos);
            }

            Console.ReadKey();
        }

        class Persona
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
        }
    }
}
