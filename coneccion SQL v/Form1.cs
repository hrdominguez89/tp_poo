using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace coneccion_SQL_v
{
    public partial class Form1 : Form
    {
        Conexionsql c = new Conexionsql();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Conexionsql c = new Conexionsql();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.UsuarioRegistrado(Convert.ToInt32(textBox5.Text))==0)
            {
                MessageBox.Show(c.Insertar(textBox1.Text, textBox2.Text, textBox3.Text,1, DateTime.Now,1, textBox4.Text, textBox5.Text));

                
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario existente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
