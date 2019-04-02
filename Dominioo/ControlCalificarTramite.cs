using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominioo
{
    public partial class ControlCalificarTramite : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        public ControlCalificarTramite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("se abrio");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT [Administrador] (CedulaA,Nombres,Apellidos,Correo,Contraseña,Telefono,Direccion) VALUES ('" + Cedula.Text + "','" + Nombre.Text + "','" + Apellido.Text + "','" + Correo.Text + "','" + Contrasena.Text + "','" + Telefono.Text + "','" + Direccion.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Calificacion Exitosa");
        }
    }
}
