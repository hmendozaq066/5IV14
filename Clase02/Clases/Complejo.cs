using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02.Clases
{
    class Complejo
    {
        //Propiedades
        public int A { get; set; }
        public int B { get; set; }

        /*
         * Constructores //31/08/2021 Act
         * 
         * En Programación Orientada a Objetos (POO), un constructor es 
         * una subrutina cuya misión es inicializar un objeto de una clase. 
         * En el constructor se asignan los valores iniciales del nuevo objeto.
         * 
         * SINTAXIS
         * public|private NombreIgualQueLaClase(parámetros){ código }
         * 
         */
        //Este es un constructor porque:
        //1- No devuelve valores
        //2- Se llama igual que la clase

        /// <summary>
        /// Constructor que solicita 2 parámetros 
        /// Comentario que usa intellisense
        /// </summary>
        /// <param name="A">Parte real del número complejo</param>
        /// <param name="b">Parte imaginaria del número complejo</param>
        public Complejo(int A, int b)
        {
            //Cuando utilizar this: Si una propiedad se llama igual que una variable local
            /*
             * this - The this pointer represents the current instance of a class or struct
             */
            this.A = A; //Aquí la propiedad A se llama igual que la variable local A, por lo tanto hay que usar this
            B = b; //Aquí la propiedad B NO sellama igual que la varible local b, por lo tanto el this es opcional
        }

        /*
         * Sobrecarga métodos y constructores
         * La sobrecarga es la creación dentro de la clase, de un grupo de 
         * métodos que tienen el MISMO NOMBRE pero con un número de parámetros 
         * DISTINTO y/o bien distintos TIPOS DE DATOS.         
         */
        /// <summary>
        /// Inicializa el valor real e imaginario como cero.
        /// </summary>
        public Complejo()
        {
            A = 0;
            B = 0;
        }

        /// <summary>
        /// Suma al número complejo de la instancia actual los valores que se le proporcionen
        /// </summary>
        /// <param name="Real">Parte real del número complejo</param>
        /// <param name="Imaginario">Parte imaginaria del número complejo</param>
        /// <returns>Una instancia con el resultado de la suma del complejo</returns>
        public Complejo Suma(int Real, int Imaginario)
        {
            //Aquí estamos realizano una nueva instancia temporal 
            // de la clase Complejo
            var resultado = new Complejo();
            //Aquí sumamos a la propiedad A de la instancia temporal
            //El valor de A de la instancia actual + el valor de Real
            resultado.A = this.A + Real;
            //Aquí sumamos a la propiedad B de la instancia temporal
            //El valor de B de la instancia actual + el valor de Imaginario
            resultado.B = this.B + Imaginario;
            //Devolvemos la instancia temporal
            return resultado;
        }

        //Implementar la resta de numeros complejos
        //public Complejo Resta(int Real, int Imaginaria)

        /* Suma
         * z = 5 + 4i
         * y = 8 + 2i
         * z + y = -3 + 2i;
         */

        /* Suma
         * z = 5 + 4i
         * y = 8 + 2i
         * z + y = 13 + 6i;
         */

        public string FormaBinomica()
        {
            return string.Format("{0} + {1}i", A, B);
            //return A + " + " + B + "i";
        }

    }
}
