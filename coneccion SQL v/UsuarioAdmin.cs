﻿using System;
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
    public partial class UsuarioAdmin : Form
    {
        public UsuarioAdmin(string nombre)
        {
            InitializeComponent();
            lblmensajeadmin.Text = nombre;
        }

        private void UsuarioAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
