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
            Application.Run(new Form2());
=======
            Application.Run(new CalificarTramitador());
>>>>>>> 0ab8fa2de78dc7000d4dc96c2fdbd3a4a44b38c9
            

        }
    }
}
