using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dominioo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lina\SoftwareII\WindowsFormsApp1\Database.mdf;Integrated Security=True;Connect Timeout=30");


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("se abrio");
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT [Tramitador] (CedulaT,Nombres,Apellidos,Privilegios,Telefono,Email,ContraseñaT,Fecha_nacimiento,Pasado_judicial,Descripcion,Tipo_vehiculol) VALUES ('" + cedula.Text + "','" + nombre.Text + "','" + apellido.Text + "','"+ apellido.Text + "','" + telefono.Text + "','" + email.Text + "','" + contraseña.Text + "','" + fechanacimiento.Text + "','" + pasadojudicial.Text + "','" + descripcionp.Text + "','" + direccion.Text + "','"    + experiencial.Text + "','"   + tipovehiculo.Text + "')";
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("datos insertados");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
