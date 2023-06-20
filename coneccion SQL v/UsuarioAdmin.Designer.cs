namespace coneccion_SQL_v
{
    partial class UsuarioAdmin
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
            this.lblmensajeadmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensajeadmin
            // 
            this.lblmensajeadmin.AutoSize = true;
            this.lblmensajeadmin.Location = new System.Drawing.Point(269, 164);
            this.lblmensajeadmin.Name = "lblmensajeadmin";
            this.lblmensajeadmin.Size = new System.Drawing.Size(95, 16);
            this.lblmensajeadmin.TabIndex = 0;
            this.lblmensajeadmin.Text = "Usuario Admin";
            // 
            // UsuarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 636);
            this.Controls.Add(this.lblmensajeadmin);
            this.Name = "UsuarioAdmin";
            this.Text = "UsuarioAdmin";
            this.Load += new System.EventHandler(this.UsuarioAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensajeadmin;
    }
}