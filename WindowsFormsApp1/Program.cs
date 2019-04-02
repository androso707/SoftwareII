using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persistencia
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
       public static void Main()
      {
           AppDomain.CurrentDomain.SetData("DataDirectory",System.Environment.CurrentDirectory.Replace("\\bin\\Debug", ""));
       
        }
    }
}
