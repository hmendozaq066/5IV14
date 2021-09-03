using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase02.Clases;

namespace Clase02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Vamos a realizar una instancia de la clase complejo */
            var complejo01 = new Complejo(12, 5);
            var complejo02 = new Complejo();

            Console.WriteLine(complejo01.FormaBinomica());
            //Aquí estamos declarando que la instancia temporal que devuelve suma
            //Se guarda en la 'variable' que se llama "res"
            var res = complejo01.Suma(8, 2);

            Console.WriteLine("Resultado: " + res.FormaBinomica());
            Console.WriteLine("Complejo01: " + complejo01.FormaBinomica());

            Console.ReadKey();
        }
    }
}
