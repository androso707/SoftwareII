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
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private DateTime dateTime;
        private float v5;
        private string v6;
        private string v7;
        private string v8;
        private string v9;
        private double v10;

        public tramite(int id_tramite, string estado, string nombre, string tipo, DateTime fecha, float tiempo, string descropcion, string lugar_origen, string lugar_destino, string transporte, double conto_total)
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
        }

        public tramite(int v1, int id_tramite, string v2, string estado, string v3, string nombre, string v4, string tipo, DateTime dateTime, DateTime fecha, float v5, float tiempo, string v6, string descropcion, string v7, string lugar_origen, string v8, string lugar_destino, string v9, string transporte, double v10, double conto_total)
        {
            this.v1 = v1;
            this.id_tramite = id_tramite;
            this.v2 = v2;
            this.estado = estado;
            this.v3 = v3;
            this.nombre = nombre;
            this.v4 = v4;
            this.tipo = tipo;
            this.dateTime = dateTime;
            this.fecha = fecha;
            this.v5 = v5;
            this.tiempo = tiempo;
            this.v6 = v6;
            this.descropcion = descropcion;
            this.v7 = v7;
            this.lugar_origen = lugar_origen;
            this.v8 = v8;
            this.lugar_destino = lugar_destino;
            this.v9 = v9;
            this.transporte = transporte;
            this.v10 = v10;
            this.conto_total = conto_total;
        }
    }

    

    

    
}
