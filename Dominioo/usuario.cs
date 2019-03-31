using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class usuario {
        int cedula;
        string nombre;
        string privilegios;
        int telefono;
        string email;
        string direccion;
        string contraseña;
        DateTime fecha_nacimiento;

        public usuario(int cedula, string nombre, string privilegios, int telefono, string email, 
            string direccion, string contraseña, DateTime fecha_nacimiento)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.privilegios = privilegios;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
            this.contraseña = contraseña;
            this.fecha_nacimiento = fecha_nacimiento;
        }

        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Privilegios { get => privilegios; set => privilegios = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
    }

}
