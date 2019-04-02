using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominioo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
      [STAThread]
        static void Main()
        {
           // AppDomain.CurrentDomain.SetData("DataDirectory", System.Environment.CurrentDirectory.Replace("\\bin\\Debug", ""));
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new CalificarCliente());
=======
            Application.Run(new VistaOrdendarTramite ());
>>>>>>> 292fc9d420c9daf2b82aec35a3170e9bdeccbdbc
            

        }
    }
}
