﻿using System;
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
    public partial class OrdenarTramite : Form
    {
        public OrdenarTramite()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ordenar_Click(object sender, EventArgs e)
        {
            ControlFormTramite Control = new ControlFormTramite();
            Control.Show();
                
        }
    }
}
