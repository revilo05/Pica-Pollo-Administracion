using System;
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
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto Registrado!");
            this.Hide();
            Almacencito Almc = new Almacencito();
            Almc.Show();
        }
    }
}
