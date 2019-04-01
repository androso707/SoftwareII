using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Configuration;

namespace Persistencia
{
    public class Conexion
    {
        //private string cadena = "SERVER=localhost;DATABASE=Database; UID=root; PASSWORD=;";
        //private string cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;initial catalog =Database;Integrated Security=False";
        //Data Source = (LocalDB)\MSSQLLocalDB;Integrated Security = True;
        //private string cadena = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;initial catalog =Database;Integrated Security=True");
        //public SqlConnection cn;
        //private SqlCommandBuilder cmb;
        //public DataSet ds = new DataSet();
        //public SqlDataAdapter da;
        //public void conectar() { cn = new SqlConnection(cadena); }
        //public SqlCommand comando;
        //public Conexion() { conectar(); }

        //Consultar
        //public void consultar(string sql , string tabla)
        /*{
        ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);

        }

        public bool insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else { return false; }
        }

       */ 
    }
}
