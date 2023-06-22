namespace coneccion_SQL_v
{
    partial class Lista_de_compras
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Eliminar_lista = new System.Windows.Forms.Button();
            this.Borrar_elemento = new System.Windows.Forms.Button();
            this.Comprar = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.Listadecompras = new System.Windows.Forms.Label();
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cantidad,
            this.Producto,
            this.Precio});
            this.listView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(715, 482);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Eliminar_lista
            // 
            this.Eliminar_lista.BackColor = System.Drawing.Color.MediumPurple;
            this.Eliminar_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_lista.ForeColor = System.Drawing.Color.White;
            this.Eliminar_lista.Location = new System.Drawing.Point(779, 71);
            this.Eliminar_lista.Name = "Eliminar_lista";
            this.Eliminar_lista.Size = new System.Drawing.Size(184, 47);
            this.Eliminar_lista.TabIndex = 1;
            this.Eliminar_lista.Text = "Eliminar Lista ";
            this.Eliminar_lista.UseVisualStyleBackColor = false;
            // 
            // Borrar_elemento
            // 
            this.Borrar_elemento.BackColor = System.Drawing.Color.MediumPurple;
            this.Borrar_elemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar_elemento.ForeColor = System.Drawing.Color.White;
            this.Borrar_elemento.Location = new System.Drawing.Point(779, 157);
            this.Borrar_elemento.Name = "Borrar_elemento";
            this.Borrar_elemento.Size = new System.Drawing.Size(184, 47);
            this.Borrar_elemento.TabIndex = 2;
            this.Borrar_elemento.Text = "Borrar elemento";
            this.Borrar_elemento.UseVisualStyleBackColor = false;
            // 
            // Comprar
            // 
            this.Comprar.BackColor = System.Drawing.Color.MediumPurple;
            this.Comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comprar.ForeColor = System.Drawing.Color.White;
            this.Comprar.Location = new System.Drawing.Point(779, 251);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(184, 47);
            this.Comprar.TabIndex = 3;
            this.Comprar.Text = "Comprar";
            this.Comprar.UseVisualStyleBackColor = false;
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.MediumPurple;
            this.Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.ForeColor = System.Drawing.Color.White;
            this.Volver.Location = new System.Drawing.Point(779, 350);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(184, 47);
            this.Volver.TabIndex = 4;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = false;
            // 
            // Listadecompras
            // 
            this.Listadecompras.AutoSize = true;
            this.Listadecompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listadecompras.ForeColor = System.Drawing.Color.MediumPurple;
            this.Listadecompras.Location = new System.Drawing.Point(36, 20);
            this.Listadecompras.Name = "Listadecompras";
            this.Listadecompras.Size = new System.Drawing.Size(190, 24);
            this.Listadecompras.TabIndex = 5;
            this.Listadecompras.Text = "Mi lista de compras";
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            this.Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lista_de_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 592);
            this.Controls.Add(this.Listadecompras);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Comprar);
            this.Controls.Add(this.Borrar_elemento);
            this.Controls.Add(this.Eliminar_lista);
            this.Controls.Add(this.listView1);
            this.Name = "Lista_de_compras";
            this.Text = "Lista_de_compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Eliminar_lista;
        private System.Windows.Forms.Button Borrar_elemento;
        private System.Windows.Forms.Button Comprar;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Label Listadecompras;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Precio;
    }
}