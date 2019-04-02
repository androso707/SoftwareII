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
    public partial class CalificarCliente : Form
    {
        string estado;
        public CalificarCliente()
        {
            InitializeComponent();
            textBox2.Text = DateTime.Now.ToString("yyyy,dd,MM");
            //textBox2.Text = Convert.ToString(DateTime.Now.ToLocalTime());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Dominio.control_n_calificar_cliente  califica = new Dominio.control_n_calificar_cliente();
            this.estado=califica.Existe_cliente(2);
            bool bandera=true;
            if (estado.Trim().ToUpper() == "TERMINADO")
            {
                textBox5.Text = this.estado.Trim().ToUpper();

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Inserte por favor un dato");
                    bandera = false;
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Ingrese el tipo de tramite");
                    bandera = false;
                }
                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Inserte Descripcion");
                    bandera = false;
                }
                if (string.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("Inserte calificacion");
                    bandera = false;
                }
                if (bandera)
                {
                    califica.Guardar_calificacion(textBox1.Text, Convert.ToDateTime(textBox2.Text),textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text,
                        textBox7.Text);
                }
                
            }
            
            


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalificarTramitador_Load(object sender, EventArgs e)
        {

        }
    }
}
