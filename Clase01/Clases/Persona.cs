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
        //Atributos // Propiedades
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
            Random aleatorio = new Random(DateTime.Now.Millisecond);
            string curp = ObtenerPrimerasLetras() + ObtenerFechaNacimiento() + Genero.Substring(0, 1)
                + ObtenerInicialesEstadoSwitch() + ObtenerConsonanteInterna(ApellidoPaterno) + ObtenerConsonanteInterna(ApellidoMaterno) +
                ObtenerConsonanteInterna(Nombre) + aleatorio.Next(10, 99);
            return curp.ToUpper();
            //return ObtenerPrimerVocal(ApellidoPaterno);
        }

        public string ObtenerFechaNacimiento()
        {
            return FechaNacimiento.Year.ToString().Substring(2, 2) +
                AgregarCero(FechaNacimiento.Month) + AgregarCero(FechaNacimiento.Day);
        }

        

        private string ObtenerInicialesEstadoSwitch()
        {
            switch (LugarNacimiento.ToUpper().Trim())
            {
                case "AGUASCALIENTES":
                    return "AS";
                case "BAJA CALIFORNIA":
                    return "BC";
                case "MÉXICO":
                case "MEXICO":
                    return "MC";
                case "DISTRITO FEDERAL":
                case "CIUDAD DE MEXICO":
                case "CDMX":
                    return "DF";
                case "OAXACA":
                    return "OC";
                default:
                    return "NE";
            }
        }

        //MENDOZA           -- N
        //QUIROZ            -- R
        //HECTOR MANUEL     -- C

        //CUE               -- X

        private string ObtenerConsonanteInterna(string cadena)
        {
            for (int i = 1; i < cadena.Length; i++)
            {
                if(EsVolcal(cadena.Substring(i, 1)) == false)
                {
                    return cadena.Substring(i, 1);
                }
            }
            return "X";
        }

        //6/9/1985

        //850906
        //10/9/2002   2, 2
        //020910  09 = 9

        private string AgregarCero(int numero)
        {
            //if (numero < 10) return "0" + numero; //Conversión implicita

            // Ejemplos de conversiones explicitas
            // x = (int) y;
            // x = Convert.ToInt32(y);
            // x = Int.Parse(y);

            if (numero < 10) return "0" + numero.ToString(); //Conversión explicita -- Es la mejor forma
            return numero.ToString();
        }

        private string ObtenerPrimerasLetras()
        {
            var primerasLetras = PrimeraLetraPaterno(ApellidoPaterno)
                + ObtenerPrimerVocal(ApellidoPaterno) + ApellidoMaterno.Substring(0, 1) + PrimeraLetraNombre();
            string[] palabrasAntisonantes = { "BACA", "BAKA", "BUEI", "PEDO", "LOCO" };

            for (int i = 0; i < palabrasAntisonantes.Length; i++)
            {
                if (primerasLetras.ToUpper() == palabrasAntisonantes[i])
                {
                    //Aquí devuelve la palabra antisonante, cambiando la segunda letra por una X
                    //BAKA --> BXKA
                    //BUEI --> BXEI
                    //PEDO --> PXDO
                    var v1 = primerasLetras.Substring(0, 1);
                    var v2 = primerasLetras.Substring(2, 2);
                    return v1 + "X" + v2;
                }
            }
            return primerasLetras.ToUpper();
        }

        //MARIA LUISA
        //JOSEMARIA
        //JOSE MARIA

        private string PrimeraLetraNombre()
        {
            if (EsCompuesto(Nombre) == true)
            {
                //Aquí obtenemos el primer nombre, limpiamos espacios en blanco con trim
                var primerNombre = Nombre.Substring(0, Nombre.IndexOf(' ')).Trim();
                //Aqui convertimos en mayúsculas el primer nombre
                switch (primerNombre.ToUpper())
                {
                    case "MARIA":
                    case "MA.":
                    case "MA":
                    case "JOSE":
                    case "J":
                    case "J.":
                        //            Se obtiene el segundo nombre     y se obtiene la primera letra del segundo nombre 
                        return Nombre.Substring(Nombre.IndexOf(" ") + 1).Substring(0, 1).ToUpper();
                        //MARIA LUISA
                }
            }
            //Si no es compuesta y no empieza en las excepciones devuelve la primera letra del primer nombre
            return Nombre.Substring(0, 1).ToUpper();
        }

        //Nuevo cambio a las 08:15 PM

        private bool EsCompuesto(string cadena)
        {
            if (cadena.IndexOf(" ") > -1) return true;
            return false;
        }

        /// <summary>
        /// Devuelve la primera letra del apellido paterno
        /// </summary>
        /// <param name="cadena">Apellido paterno</param>
        /// <returns>la primera letra del apellido paterno</returns>
        private string PrimeraLetraPaterno(string cadena)
        {
            //cadena = cadena.ToUpper();
            //Verificamos que si la primera letra es Ñ entonces se cambia por X
            //if (cadena.Substring(0, 1) == "Ñ") return "X";
            return ConvertirEnhe(cadena.Substring(0, 1).ToUpper());
        }

        /// <summary>
        /// Convierte una Ñ en una X
        /// </summary>
        /// <param name="letra">Letra a evaluar</param>
        /// <returns>X si es Ñ de lo contrario la misma letra</returns>
        private string ConvertirEnhe(string letra)
        {
            if (letra.ToUpper() == "Ñ") return "X";
            return letra;
        }

        private string ObtenerPrimerVocal(string cadena)
        {
            //MENDOZA //CRUZ //ALTAMIRANO
            for (int i = 1; i < cadena.Length; i++)
            {
                if (EsVolcal(cadena.Substring(i, 1)) == true)
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
