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

        public usuario(int cedula, string nombre, string privilegios, int telefono, string email, string direccion, string contraseña, DateTime fecha_nacimiento)
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
    }

}
