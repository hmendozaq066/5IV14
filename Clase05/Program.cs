using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Program.cs Es el que inicia el programa en Windows Forms
                               //Aquí puedes poner el nombre de la clase del formulario 
            Application.Run(new FLogin()); //Aquí estamos indicando que cargue el FLogin
        }
    }
}
