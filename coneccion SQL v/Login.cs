﻿using System;
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
             Form3 C = new Form3 ();
            C.Show();
        }
    }
}
