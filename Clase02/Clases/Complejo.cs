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

        /// <summary>
        /// Esta es una sobrecarga del método suma de la clase complejo, en este se recibe una instancia del tipo Complejo
        /// </summary>
        /// <param name="complejo">Instancia del tipo Complejo</param>
        /// <returns>Una instancia del tipo Complejo con la suma de estos</returns>
        public Complejo Suma(Complejo complejo)
        {
            var resultado = new Complejo();
            //Aquí estamos sumando la propiedad A de la instancia actual con la propiedad A de la instancia que se llama 'complejo'
            resultado.A = A + complejo.A;
            //Aquí estamos sumando la propiedad B de la instancia actual con la propiedad B de la instancia que se llama 'complejo'
            resultado.B = B + complejo.B;
            return resultado;
        }

        //La multiplicación de dos complejos
        //La multiplicación de un entero con un complejo

        //El valor absoluto de un numero complejo a^2 = b^2 + c^2  --> a = raiz(b^2 + c^2) 
        //el valor absoluto de un número complejo es un entero positivo

        //public int ValorAbsoluto()

        //public Complejo Multiplicar(int real)
        //public Complejo Multiplicar(Complejo complejo)

        /// <summary>
        /// Resta de un número complejo
        /// </summary>
        /// <param name="complejo">Número complejo a restar</param>
        /// <returns>La instancia del resultado de la resta de un complejo</returns>
        public Complejo Resta(Complejo complejo)
        {
            var resultado = new Complejo();
            resultado.A = this.A - complejo.A;
            resultado.B = this.B - complejo.B;
            return resultado;
        }

        public Complejo Resta(int Real, int Imaginario)
        {
            var resultado = new Complejo();
            //Aquí no usamos this porque las propiedas no tienen el mismo nombre que las variables locales o los argumentos.
            resultado.A = A - Real;
            resultado.B = B - Imaginario;
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
            if (B < 0)
            {
                //BP Cuando exista un return dentro de una condición IF no es necesario el else
                //Si tiene mas lineas son necesarias las llaves
                return string.Format("{0} - {1}i", A, Math.Abs(B));
            }
            return string.Format("{0} + {1}i", A, B);
        }

        public string FormaBinomicaTernaria()
        {
            return string.Format("{0} {1} {2}i", A, (B < 0) ? "-" : "+", Math.Abs(B));
            //La sintaxis del operador ternario es (condicion) ? true : false;

        }

    }
}
