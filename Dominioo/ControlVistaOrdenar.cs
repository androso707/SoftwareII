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
    public partial class ControlVistaOrdenar : Form
    {
        SqlConnection cone = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        public ControlVistaOrdenar()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cone.Open();
            SqlCommand cmd = cone.CreateCommand();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
            }

            cmd.CommandText = "INSERT [Tramite] (id_tramite,estado,nombre,tipo,fecha,transporte,tiempo,descripcion,lugarorigen,lugardestino) VALUES ('" + idtxt.Text + "','" + txtnombre.Text +"')";
            MessageBox.Show("Tramite Isertado");
            cone.Close();
        }
    }
}
