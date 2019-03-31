using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Con_dinero : tramite
    {
        //double monto;

        public Con_dinero(int id_tramite, string estado, string nombre, string tipo, DateTime fecha, float tiempo, string descripcion, string lugar_origen, string lugar_destino, string transporte, double monto_total, DateTime dateTime) : base(id_tramite, estado, nombre, tipo, fecha, tiempo, descripcion, lugar_origen, lugar_destino, transporte, monto_total, dateTime)
        {
        }

    }


}
