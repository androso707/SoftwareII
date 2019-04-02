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
    public partial class ControlFormTramite : Form
    {
        SqlConnection cone = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leo\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        public ControlFormTramite()

        {
            InitializeComponent();
        }

        private void OrdenarFin_Click(object sender, EventArgs e)
        {
            cone.Open();
            MessageBox.Show("se abrio");
            SqlCommand cmd = cone.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT [Tramite] (id_tramite,nombre) VALUES ('" + txtid.Text + "','" + txttramite.Text + "')";
            cmd.ExecuteNonQuery();
            cone.Close();
            MessageBox.Show("datos insertados del tramite");
            
        }
    }
}
