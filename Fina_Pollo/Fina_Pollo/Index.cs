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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Almacencito Alm = new Almacencito();
            Alm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Cajita Caj = new Cajita();
            Caj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Delivery Dely = new Delivery();
            Dely.Show();
        }
    }
}
