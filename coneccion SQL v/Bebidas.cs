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
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            string menu = "";
            Menu menuvolver = new Menu(menu);
            menuvolver.Show();
        }

        private void Iramilista_Click(object sender, EventArgs e)
        {
            Lista_de_compras lista_De_Compras = new Lista_de_compras();
            lista_De_Compras.Show();
        }
    }
}
