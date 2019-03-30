using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsayoOscar
{
    class Program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("pruebas");
            control_n_calificar_cliente metodos = new control_n_calificar_cliente();
            metodos.Existe_cliente("jashs");
            Console.WriteLine(metodos.Existe_cliente("jashs"));
            Console.ReadKey();
        }
    }
}
