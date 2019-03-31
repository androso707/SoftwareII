using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persistencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


       

        private void button2_Click(object sender, EventArgs e)
        {

            Dominio.control_n_calificar_cliente calificacliente = new Dominio.control_n_calificar_cliente();
            calificacliente.Existe_cliente("3");

            Administrador newAdministrador = new Administrador();
            newAdministrador.CedulaA = Convert.ToInt32(textBox1.Text); ;
            newAdministrador.Nombres = "Admin";
            newAdministrador.Apellidos = "admin";
            newAdministrador.Correo = "admin@admin.com";
            newAdministrador.Contraseña = "0000";
            newAdministrador.Telefono = "311122";
            newAdministrador.Direccion = "calle joropo";


            DataClassDataContext dbcontext = new DataClassDataContext();
            dbcontext.Administrador.InsertOnSubmit(newAdministrador);

            try
            {
                dbcontext.SubmitChanges();
                MessageBox.Show("Exitoso");
                Console.WriteLine("EXITOO");

            }
            catch (Exception)
            {
                Console.WriteLine("falla");
                calificacliente.Existe_cliente("3");
                MessageBox.Show(Convert.ToString(calificacliente.Existe_cliente("3")));
                MessageBox.Show("fracaso");
            }



        }
    }
}
