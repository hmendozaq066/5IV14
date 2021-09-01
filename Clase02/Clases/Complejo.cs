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
         * Constructores
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
        public Complejo(int A, int b)
        {
            /*
             * this - The this pointer represents the current instance of a class or struct
             */
            this.A = A; //Aquí la propiedad A se llama igual que la variable local A, por lo tanto hay que usar this
            B = b; //Aquí la propiedad B NO sellama igual que la varible local b, por lo tanto el this es opcional
        }


    }
}
