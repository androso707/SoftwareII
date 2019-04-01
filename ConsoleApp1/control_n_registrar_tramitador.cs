using System;
using System.Collections.Generic;
using System.Text;

namespace EnsayoOscar
{
    class control_n_registrar_tramitador
    {
        

        public bool comprobar_campos(int cedula, string nombre,string apellido, string privilegios, int telefono, string email, string direccion, string contraseña,
            DateTime fecha_nacimiento, object pasado_judicial, string descripcion, object experiencia, string tipo_vehiculo)
        {
            int año = 0;
            int añomayor = 0;
            int añoactual = 0;

            año = DateTime.Today.Year-40;
            añomayor = DateTime.Today.Year-18;
            añoactual = DateTime.Today.Year - fecha_nacimiento.Year;
            bool comprobacion = false;
            if (cedula < 1 || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(privilegios) || 
                string.IsNullOrEmpty(Convert.ToString(telefono))
                || string.IsNullOrEmpty(email)|| 
                string.IsNullOrEmpty(direccion) || 
                fecha_nacimiento.Year<año || 
                fecha_nacimiento.Year>añomayor|| string.IsNullOrEmpty(contraseña)||contraseña.Length >6||contraseña.Length<12||string.IsNullOrEmpty(descripcion)|| string.IsNullOrEmpty(tipo_vehiculo))
            {

                Console.WriteLine("CAmpos invalidos ");
                
                if (cedula < 1)
                {
                    Console.WriteLine("campo cedula invalido ");
                }

                if (string.IsNullOrEmpty(nombre))
                {
                    Console.WriteLine("campo nombre invalido ");
                }
                if (fecha_nacimiento.Year < año)
                {
                    Console.WriteLine("valla a un ancianato ");
                    Console.WriteLine(año);
                    Console.WriteLine(DateTime.Today.Year-fecha_nacimiento.Year);
                }
                if(fecha_nacimiento.Year > añomayor && añoactual>0)
                {
                    Console.WriteLine("eres un culicagado");
                    Console.WriteLine(año);
                    Console.WriteLine(DateTime.Today.Year - fecha_nacimiento.Year);
                }
                if (añoactual<0)
                {
                    Console.WriteLine("weee estas en el futuro vuelve con el profesor en el delorean");
                    Console.WriteLine(año);
                    Console.WriteLine(DateTime.Today.Year - fecha_nacimiento.Year);
                }
                
                comprobacion = false;
            }
            else
            {
                Console.WriteLine("usuario validado");
                Console.WriteLine(nombre);
                Console.WriteLine(cedula);
                Console.WriteLine(privilegios);
                Console.WriteLine(telefono);
                Console.WriteLine(email);
                Console.WriteLine(fecha_nacimiento);
                Console.WriteLine(fecha_nacimiento.Year);
                Console.WriteLine(fecha_nacimiento.Month);
                Console.WriteLine(fecha_nacimiento.Day);
                Console.WriteLine(DateTime.Today.Year);
                Console.WriteLine(descripcion);
                Console.WriteLine(tipo_vehiculo);
                comprobacion = true;
            }


            return comprobacion;
        }
        public bool comprobar_mayusculas(String contraseña) {
             
            return true;
        }




    }
}
