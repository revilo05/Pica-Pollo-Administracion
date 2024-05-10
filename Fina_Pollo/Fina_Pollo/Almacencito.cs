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
    public partial class Almacencito : Form
    {
        public Almacencito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Almacencito_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD Anadir = new ADD();
            Anadir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edt Editar = new Edt();
            Editar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeLe Eliminar = new DeLe();
            Eliminar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Product Ver = new View_Product();
            Ver.Show();
        }
    }
}
