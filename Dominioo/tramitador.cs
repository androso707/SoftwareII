using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Tramitador : usuario
    {
        object pasado_judicial;
        string descripcion;
        object experiencia;
        string tipo_vehiculo;

      

        public Tramitador(object pasado_judicial, string descripcion, object experiencia, string tipo_vehiculo,int cedula, string nombre, string privilegios, int telefono, string email, string direccion, string contraseña, DateTime fecha_nacimiento) : base(cedula, nombre, privilegios, telefono, email, direccion, contraseña, fecha_nacimiento)
        {
            this.pasado_judicial = pasado_judicial;
            this.descripcion = descripcion;
            this.experiencia = experiencia;
            this.tipo_vehiculo = tipo_vehiculo;
        }

        public object Pasado_judicial { get => pasado_judicial; set => pasado_judicial = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public object Experiencia { get => experiencia; set => experiencia = value; }
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
    }
}

