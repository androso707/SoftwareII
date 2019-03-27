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

        public tramite(int id_tramite, string estado, string nombre, string tipo, DateTime fecha, float tiempo, string descropcion, string lugar_origen, string lugar_destino, string transporte, double conto_total, int v1, string v2, string v3, string v4, DateTime dateTime, float v5, string v6, string v7, string v8, string v9, double v10)
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
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.dateTime = dateTime;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            this.v8 = v8;
            this.v9 = v9;
            this.v10 = v10;
        }
    }

    

    

    
}
