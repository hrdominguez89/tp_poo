/*namespace coneccion_SQL_v
{
    partial class listado_de_compra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listado_de_compra));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ver_ticket = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Transaction = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bondAPPetiteDataSet = new coneccion_SQL_v.bondAPPetiteDataSet();
            this.productosTableAdapter = new coneccion_SQL_v.bondAPPetiteDataSetTableAdapters.ProductosTableAdapter();
            this.Gracias = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad_To_Bill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.Label();
            this.ProductQtty = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Products = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bondAPPetiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.Address);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.CustomerName);
            this.panel2.Controls.Add(this.CustomerId);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.Client);
            this.panel2.Location = new System.Drawing.Point(341, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 136);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::coneccion_SQL_v.Properties.Resources.mujer_comiendo_papas_fritas_salsa_tomate;
            this.pictureBox1.Location = new System.Drawing.Point(12, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ver_ticket
            // 
            this.ver_ticket.BackColor = System.Drawing.Color.LightGray;
            this.ver_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_ticket.Location = new System.Drawing.Point(830, 267);
            this.ver_ticket.Name = "ver_ticket";
            this.ver_ticket.Size = new System.Drawing.Size(112, 37);
            this.ver_ticket.TabIndex = 3;
            this.ver_ticket.Text = "Ver ticket";
            this.ver_ticket.UseVisualStyleBackColor = false;
            this.ver_ticket.Click += new System.EventHandler(this.ver_ticket_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.LightGray;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(205, 105);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(112, 37);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Transaction
            // 
            this.Transaction.Location = new System.Drawing.Point(845, 351);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(290, 176);
            this.Transaction.TabIndex = 11;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.bondAPPetiteDataSet;
            // 
            // bondAPPetiteDataSet
            // 
            this.bondAPPetiteDataSet.DataSetName = "bondAPPetiteDataSet";
            this.bondAPPetiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // Gracias
            // 
            this.Gracias.AutoSize = true;
            this.Gracias.BackColor = System.Drawing.Color.MediumPurple;
            this.Gracias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gracias.ForeColor = System.Drawing.Color.White;
            this.Gracias.Location = new System.Drawing.Point(21, 83);
            this.Gracias.Name = "Gracias";
            this.Gracias.Size = new System.Drawing.Size(277, 29);
            this.Gracias.TabIndex = 6;
            this.Gracias.Text = "Gracias por tu compra!";
            // 
            // Productos
            // 
            this.Productos.AutoSize = true;
            this.Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.ForeColor = System.Drawing.Color.White;
            this.Productos.Location = new System.Drawing.Point(388, 271);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(118, 25);
            this.Productos.TabIndex = 7;
            this.Productos.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(906, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Transacciones";
            // 
            // ProductDGV
            // 
            this.ProductDGV.AutoGenerateColumns = false;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ProductDGV.DataSource = this.productosBindingSource;
            this.ProductDGV.Location = new System.Drawing.Point(362, 402);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.Size = new System.Drawing.Size(237, 48);
            this.ProductDGV.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn2.HeaderText = "precio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Ad_To_Bill
            // 
            this.Ad_To_Bill.BackColor = System.Drawing.Color.LightGray;
            this.Ad_To_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad_To_Bill.Location = new System.Drawing.Point(62, 105);
            this.Ad_To_Bill.Name = "Ad_To_Bill";
            this.Ad_To_Bill.Size = new System.Drawing.Size(112, 37);
            this.Ad_To_Bill.TabIndex = 13;
            this.Ad_To_Bill.Text = "Ad To Bill";
            this.Ad_To_Bill.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.ProductQtty);
            this.panel1.Controls.Add(this.ProductPrice);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.Ad_To_Bill);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Location = new System.Drawing.Point(341, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 162);
            this.panel1.TabIndex = 14;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.BackColor = System.Drawing.Color.White;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.Color.MediumPurple;
            this.ProductName.Location = new System.Drawing.Point(9, 40);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(117, 20);
            this.ProductName.TabIndex = 16;
            this.ProductName.Text = "ProductName";
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSize = true;
            this.ProductPrice.BackColor = System.Drawing.Color.White;
            this.ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice.ForeColor = System.Drawing.Color.MediumPurple;
            this.ProductPrice.Location = new System.Drawing.Point(132, 40);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(111, 20);
            this.ProductPrice.TabIndex = 17;
            this.ProductPrice.Text = "ProductPrice";
            // 
            // ProductQtty
            // 
            this.ProductQtty.AutoSize = true;
            this.ProductQtty.BackColor = System.Drawing.Color.White;
            this.ProductQtty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQtty.ForeColor = System.Drawing.Color.MediumPurple;
            this.ProductQtty.Location = new System.Drawing.Point(262, 40);
            this.ProductQtty.Name = "ProductQtty";
            this.ProductQtty.Size = new System.Drawing.Size(104, 20);
            this.ProductQtty.TabIndex = 18;
            this.ProductQtty.Text = "ProductQtty";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(266, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.BackColor = System.Drawing.Color.White;
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.MediumPurple;
            this.Products.Location = new System.Drawing.Point(365, 379);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(80, 20);
            this.Products.TabIndex = 15;
            this.Products.Text = "Products";
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.BackColor = System.Drawing.Color.White;
            this.Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.ForeColor = System.Drawing.Color.MediumPurple;
            this.Client.Location = new System.Drawing.Point(17, 14);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(55, 20);
            this.Client.TabIndex = 15;
            this.Client.Text = "Client";
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(21, 101);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 16;
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSize = true;
            this.CustomerId.BackColor = System.Drawing.Color.White;
            this.CustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerId.ForeColor = System.Drawing.Color.MediumPurple;
            this.CustomerId.Location = new System.Drawing.Point(19, 34);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(102, 20);
            this.CustomerId.TabIndex = 18;
            this.CustomerId.Text = "CustomerId";
            this.CustomerId.Click += new System.EventHandler(this.CustomerId_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.BackColor = System.Drawing.Color.White;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.ForeColor = System.Drawing.Color.MediumPurple;
            this.CustomerName.Location = new System.Drawing.Point(17, 80);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(132, 20);
            this.CustomerName.TabIndex = 19;
            this.CustomerName.Text = "CustomerName";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 57);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(149, 66);
            this.textBox6.TabIndex = 20;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.MediumPurple;
            this.Address.Location = new System.Drawing.Point(183, 34);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(75, 20);
            this.Address.TabIndex = 21;
            this.Address.Text = "Address";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(335, 34);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(335, 101);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(341, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(341, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // listado_de_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1157, 612);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.Gracias);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.ver_ticket);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "listado_de_compra";
            this.Text = "listado_de_compra";
            this.Load += new System.EventHandler(this.listado_de_compra_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bondAPPetiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ver_ticket;
        private System.Windows.Forms.Button Reset;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView Transaction;
        private bondAPPetiteDataSet bondAPPetiteDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private bondAPPetiteDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Gracias;
        private System.Windows.Forms.Label Productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button Ad_To_Bill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProductQtty;
        private System.Windows.Forms.Label ProductPrice;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.Label Client;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label CustomerId;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}*/