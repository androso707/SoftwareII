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
        public DateTime dateTime;

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

        public int Id_tramite { get => id_tramite; set => id_tramite = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Tiempo { get => tiempo; set => tiempo = value; }
        public string Descropcion { get => descropcion; set => descropcion = value; }
        public string Lugar_origen { get => lugar_origen; set => lugar_origen = value; }
        public string Lugar_destino { get => lugar_destino; set => lugar_destino = value; }
        public string Transporte { get => transporte; set => transporte = value; }
        public double Conto_total { get => conto_total; set => conto_total = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
    }

    

    

    
}
