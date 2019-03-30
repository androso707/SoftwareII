using System;
using System.Collections.Generic;
using System.Text;

namespace EnsayoOscar
{
    class control_n_calificar_cliente
    {
        

        public bool Existe_cliente(String idTramite)
        {
            Console.WriteLine("Existe??? Exitoda del Cliente");
            Console.WriteLine(idTramite);

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





    }
}
