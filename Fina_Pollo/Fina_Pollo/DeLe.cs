﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fina_Pollo
{
    public partial class DeLe : Form
    {
        public DeLe()
        {
            InitializeComponent();
        }

        private void DeLe_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto Eliminado.");
            this.Hide();
            Almacencito Almc = new Almacencito();
            Almc.Show();

        }
    }
}
