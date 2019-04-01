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


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;initial catalog =Database;Integrated Security=True");
        //Persistencia.Conexion con = new Persistencia.Conexion();
        

        
      
        private void Form1_Load(object sender, EventArgs e)
        {
           // con.consultar("select * from Administrador", "Administrador");

            //this.dataGridView1.DataSource = con.ds.Tables["Administrador"];
            //this.dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "insert into Administrador (CedulaA,Nombres,Apellidos,Correo,Contraseña,Telefono,Direccion)" +
                "values ('55','osc','bp','admin@admin.com ','0000  ','311122 ','calle joropo')";
            SqlCommand cmd = new SqlCommand("select * from Administrador", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            /* if (con.insertar(sql))
             {
                 MessageBox.Show("Registro Insertado");
             }
             else
             {
                 MessageBox.Show("Error al insertar");
             }
             Application.Restart();
                 */
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
          
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Properties.Settings.Default.co




    }
}

