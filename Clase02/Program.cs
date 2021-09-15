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
            var complejo01 = new Complejo(1, 2);
            var complejo02 = new Complejo(3, 1);

            var multi = complejo01.MultiplicarComplejos(complejo02);
            Console.WriteLine(multi.FormaBinomica());

            /*
            Console.WriteLine(complejo01.FormaBinomica());
            //Aquí estamos declarando que la instancia temporal que devuelve suma
            //Se guarda en la 'variable' que se llama "res"
            var res01 = complejo01.Resta(8, 2);
            var res02 = complejo01.Resta(complejo02);

            Console.WriteLine("Resultado 1: " + res01.FormaBinomica());
            Console.WriteLine("Complejo01: " + complejo01.FormaBinomica());

            Console.WriteLine("Resultado 2: " + res02.FormaBinomicaTernaria());
            Console.WriteLine("Resultado 2: " + res02.FormaBinomica());*/

            Console.ReadKey();
        }
    }
}
