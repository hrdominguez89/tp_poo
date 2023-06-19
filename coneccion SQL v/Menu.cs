using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coneccion_SQL_v
{
    public partial class Menu : Form
    {
        public Menu(String nombre)
        {
            InitializeComponent();
            lblmensaje.Text = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Minutas minutas = new Minutas();
            minutas.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Postres postres= new Postres();
            postres.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cafeteria cafeteria= new Cafeteria();
            cafeteria.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
