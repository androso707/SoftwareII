using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Administrador : usuario
    {
        public Administrador(int cedula, string nombre, string privilegios, int telefono, string email, string direccion, string contraseña, DateTime fecha_nacimiento) : base(cedula, nombre, privilegios, telefono, email, direccion, contraseña, fecha_nacimiento)
        {
        }
    }
}
