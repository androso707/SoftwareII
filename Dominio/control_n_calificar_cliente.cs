using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class control_n_calificar_cliente
    {

'# Existe_cliente(idcliente)!=false,
'# consultar_estado_tramite(idtramite)==”TERMINADO”,
'# String.IsNullOrEmpty(nombre),
'# String.IsNullOrEmpty(tipo),
'# String.IsNullOrEmpty(calificacion),
'//fdfjdfd




        public bool Existe_cliente(String idTramite)
        {
            

            return true;
        }


        public String Consultar_estado_tramite(String idtramite)
        {

            return idtramite;
        }

        public void Guardar_calificacion(String nombre,DateTime fecha,String tipo,String descripcion,String estado,String calificacion,String comentarios)
        {
            Console.WriteLine("Calificacion Exitoda del Cliente");
        }




        public static void Main(String[] args)
        {

            Console.WriteLine("Calificar Cliente prueba");
        }


    }
}
