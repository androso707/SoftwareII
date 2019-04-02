using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Dominio
{
    public class control_n_calificar_cliente
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\boter\SoftwareII\WindowsFormsApp1\Database.mdf;Integrated Security=True");
        int IDTRAMITECLIENTE = 0;
        string nombrecliente;
        String estado;
        int ID;
        public string Existe_cliente(int idTramite)
        {
            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("Select Idcliente from Tramite where Idtramite=" + idTramite);
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter datap = new SqlDataAdapter(cmd);
            datap.Fill(data);
            this.ID = idTramite;
            try
            {
                this.IDTRAMITECLIENTE = (int)data.Rows[0][0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este Cliente ya no Existe");
                MessageBox.Show(ex.Message);
            }
        
            
            if (IDTRAMITECLIENTE > 0)
            {
                int cons = this.IDTRAMITECLIENTE;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("Select Nombres from Cliente where CedulaC=" + this.IDTRAMITECLIENTE);
                DataTable data1 = new DataTable();
                SqlDataAdapter datap1 = new SqlDataAdapter(cmd);
                datap1.Fill(data1);
                this.nombrecliente = (String)data1.Rows[0][0];
                conexion.Close();
                this.estado=Consultar_estado_tramite(idTramite);
                
            }
            else { 
                conexion.Close();
            }
            
            return this.estado;
        }

        public string Consultar_estado_tramite(int idtramite)
        {
            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("Select estado from Tramite where Idtramite=" + Convert.ToString(idtramite));
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter datap = new SqlDataAdapter(cmd);
            datap.Fill(data);
            try
            {
                this.estado = (string)data.Rows[0][0];
                MessageBox.Show(estado);
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.estado = null;
                conexion.Close();
            }


            return this.estado;
        }

        

        public void Guardar_calificacion(String nombre,DateTime fecha,String tipo,String descripcion,String estado,String calificacion,String comentarios)
        {
                conexion.Open();
                MessageBox.Show("se abrio");
                SqlCommand cmd = conexion.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT [Calificar_cliente] (Id,Nombres,Fecha,Tipo,Descripcion,Estado,Calificacion,Comentarios) VALUES ('" + this.ID + "','" + nombre + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tipo + "','" + descripcion + "','" + estado + "','" + calificacion + "','" + comentarios + "')";
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("datos insertados");

            

            Console.WriteLine("Calificacion Exitoda del Cliente");
        }





    }
}
