using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;




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

        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = bondAPPetite; Integrated Security = True");

        public void loguear(string email, string password)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select email, rol_id FROM Usuario WHERE email = @email and password = @password", con);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();

                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new UsuarioAdmin(dt.Rows[0][0].ToString()).Show();
                    }

                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new Menu(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Email y/o contraseña incorrecta");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registrodeusuarios Registrodeusuarios = new Registrodeusuarios();
            Registrodeusuarios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loguear(this.textBox3.Text, this.textBox1.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

