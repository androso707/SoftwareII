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
            control_n_registrar_tramitador registrarT = new control_n_registrar_tramitador();
            DateTime thisDate1 = new DateTime(1900, 6, 10);
            int valor1=5;
            registrarT.comprobar_campos(valor1,"jose","ds","tramitadora",3145555,"paice123@gmail.com","calle 34","paicemiau", thisDate1,"aguapanelaconleche","","hola ","carro");
            Console.ReadKey();
        }
    }
}
