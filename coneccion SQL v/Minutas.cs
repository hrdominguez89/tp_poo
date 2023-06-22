using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.IO;
using System.ServiceModel.Syndication;




namespace coneccion_SQL_v
{
    public partial class Minutas : Form
    {
        public Minutas()
        {
            InitializeComponent();
        }

        private void Minutas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(textBoxtortilla.Text);
            item.SubItems.Add(Tortilladepapa.Text);
            item.SubItems.Add(Preciotortilla.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(textBoxmuzza.Text);
            item.SubItems.Add(GrandeMuzza.Text);
            item.SubItems.Add(preciomuzzarella.Text);
            
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            string menu = "";
            Menu menuvolver = new Menu(menu);
            menuvolver.Show();

        }

        private void btnagregarempanadas_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(textBoxempanada.Text);
            item.SubItems.Add(Empanadas.Text);
            item.SubItems.Add(precioempanada.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMila_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregarmila_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(textBoxMila.Text);
            item.SubItems.Add(Mila.Text);
            item.SubItems.Add(PrecioMila.Text);

        }

        private void Iramilista_Click(object sender, EventArgs e)
        {
            Lista_de_compras lista_De_Compras = new Lista_de_compras();
            lista_De_Compras.Show();
        }
    }
}
