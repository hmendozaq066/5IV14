using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01.Clases
{
    class Persona
    {
        /*
         Para Definir un atributo se debe
        usar la siguiente sintaxis
        ambito tipo nombre {get; set;}
         */
        /* get es para leer
         * set es para escribir / establecer
         * */
        //Atributos
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string CURP { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public float Peso { get; set; }
        public int Estatura { get; set; }
        public string TipoSangre { get; set; }
        public bool Alergias { get; set; }
        public string RFC { get; set; }
        public string LugarNacimiento { get; set; }
        public string Genero { set; get; }

        //Métodos
        //Sintaxis  ámbito tipoDevuelto Nombre(Argumentos){código}
        //ámbito: public|private|protected
        //tipoDevuelto int|string|list|...
        //Cualquier nombre, no tiene que llevar espacios y siempre empieza con una letra 
        //BP solo alfabeto en inglés (es decir no ñ, no acentos)
        public int CalcularEdad()
        {
            // DateTime.Now devuelve una clase con la fecha actual
            var fechaActual = DateTime.Now;
            //2021 - 1985 = 36
            //return fechaActual.Year - FechaNacimiento.Year;
            var edad = DateTime.Today.Subtract(FechaNacimiento.Date);
            return Convert.ToInt32(edad.Days / 365);
        }

        public string ObtenerCURP()
        {
            string curp = PrimeraLetraPaterno(ApellidoPaterno)
                + ObtenerPrimerVocal(ApellidoPaterno) + ApellidoMaterno.Substring(0, 1);
            return curp.ToUpper();
            //return ObtenerPrimerVocal(ApellidoPaterno);
        }

        //MARIA LUISA
        //JOSEMARIA
        //JOSE MARIA

        private string PrimeraLetraNombre()
        {
            if(EsCompuesto(Nombre) == true)
            {
                switch (Nombre.ToUpper())
                {
                    case "MARIA":
                    case "MA.":
                    case "MA":
                    case "JOSE":
                    case "J":
                    case "J.":

                }
            }
            return Nombre.Substring(0, 1).ToUpper();
        }

        private bool EsCompuesto(string cadena)
        {
            if (cadena.IndexOf(" ") > -1) return true;
            return false;
        }

        private string PrimeraLetraPaterno(string cadena)
        {
            cadena = cadena.ToUpper();
            if (cadena.Substring(0, 1) == "Ñ") return "X";
            return cadena.Substring(0, 1).ToUpper();
        }

        private string ObtenerPrimerVocal(string cadena)
        {
            //MENDOZA //CRUZ //ALTAMIRANO
            for(int i = 1; i < cadena.Length; i++)
            {
                if(EsVolcal(cadena.Substring(i, 1)) == true)
                {
                    return cadena.Substring(i, 1).ToUpper();
                }
            }
            return null;
        }

        private bool EsVolcal(string letra)
        {
            letra = letra.ToUpper().Trim();

            if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
                return true;
            return false;

            /*switch (letra)
            {
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    return true;
            }
            return false;*/
        }

    }
}
