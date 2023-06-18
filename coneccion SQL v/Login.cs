using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Login
namespace coneccion_SQL_v
{
    public partial class Login : Form
    {
        Conexionsql c = new Conexionsql();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrodeusuarios Registrodeusuarios = new Registrodeusuarios();
            Registrodeusuarios.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu C = new Menu ();
            C.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
