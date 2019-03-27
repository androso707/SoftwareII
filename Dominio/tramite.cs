using System;

namespace Dominio
{
    public class tramite
    {
        int id_tramite;
        string estado;
        string nombre;
        string tipo;
        DateTime fecha;
        float tiempo;
        string descropcion;
        string lugar_origen;
        string lugar_destino;
        string transporte;
        double conto_total;
        private DateTime dateTime;

        public tramite(int id_tramite, string estado, string nombre, string tipo, DateTime fecha, float tiempo, string descropcion, string lugar_origen, string lugar_destino, string transporte, double conto_total, DateTime dateTime)
        {
            this.id_tramite = id_tramite;
            this.estado = estado;
            this.nombre = nombre;
            this.tipo = tipo;
            this.fecha = fecha;
            this.tiempo = tiempo;
            this.descropcion = descropcion;
            this.lugar_origen = lugar_origen;
            this.lugar_destino = lugar_destino;
            this.transporte = transporte;
            this.conto_total = conto_total;
            this.dateTime = dateTime;
        }
    }

    

    

    
}
