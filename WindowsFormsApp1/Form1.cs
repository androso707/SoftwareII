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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

                  
        SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("se abrio");
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT [Administrador] (CedulaA,Nombres,Apellidos,Correo,Contraseña,Telefono,Direccion) VALUES ('" + Cedula.Text + "','" + Nombre.Text + "','" + Apellido.Text + "','" + Correo.Text + "','" + Contrasena.Text + "','" + Telefono.Text + "','" + Direccion.Text + "')";
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("datos insertados");
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ("Select  * from [Administrador]");
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter datap = new SqlDataAdapter(cmd);
            datap.Fill(data);
            dataGridView1.DataSource = data;
            conexion.Close();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("se abrio");
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Administrador] where CedulaA = '" + Cedula.Text + "'";
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("datos borrados");

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("se abrio");
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  [Administrador] set Nombres = '" + Nombre.Text + "' where CedulaA  = '" + Cedula.Text + "'";
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("datos modificados");
        }
    }
}

