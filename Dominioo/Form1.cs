using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominioo
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

        private void button1_Click(object sender, EventArgs e)
        {
            Persistencia.Administrador newAdministrador = new Persistencia.Administrador();
            newAdministrador.CedulaA = Convert.ToInt32(textBox1.Text);
            newAdministrador.Nombres = "Admin";
            newAdministrador.Apellidos = "admin";
            newAdministrador.Correo = "admin@admin.com";
            newAdministrador.Contraseña = "0000";
            newAdministrador.Telefono = "311122";
            newAdministrador.Direccion = "calle joropo";
            Persistencia.DataClassDataContext d = new Persistencia.DataClassDataContext();
            d.Administrador.InsertOnSubmit(newAdministrador);
            


            Persistencia.DataClassDataContext dbcontext = new Persistencia.DataClassDataContext();
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
                MessageBox.Show("fracaso");
            }

        }
    }
}
