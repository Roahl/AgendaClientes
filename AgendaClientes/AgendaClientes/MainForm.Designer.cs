namespace AgendaClientes
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEmpresas = new System.Windows.Forms.Label();
            this.listBoxEmpresas = new System.Windows.Forms.ListBox();
            this.lbCif = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbContacto = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbContacto);
            this.groupBox1.Controls.Add(this.lbTelefono);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.lbCif);
            this.groupBox1.Location = new System.Drawing.Point(221, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente:";
            // 
            // lbEmpresas
            // 
            this.lbEmpresas.AutoSize = true;
            this.lbEmpresas.Location = new System.Drawing.Point(13, 13);
            this.lbEmpresas.Name = "lbEmpresas";
            this.lbEmpresas.Size = new System.Drawing.Size(56, 13);
            this.lbEmpresas.TabIndex = 1;
            this.lbEmpresas.Text = "Empresas:";
            // 
            // listBoxEmpresas
            // 
            this.listBoxEmpresas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxEmpresas.FormattingEnabled = true;
            this.listBoxEmpresas.Location = new System.Drawing.Point(16, 33);
            this.listBoxEmpresas.Name = "listBoxEmpresas";
            this.listBoxEmpresas.Size = new System.Drawing.Size(199, 381);
            this.listBoxEmpresas.TabIndex = 2;
            this.listBoxEmpresas.SelectedIndexChanged += new System.EventHandler(this.objetoSeleccionado);
            // 
            // lbCif
            // 
            this.lbCif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbCif.AutoSize = true;
            this.lbCif.Location = new System.Drawing.Point(24, 44);
            this.lbCif.Name = "lbCif";
            this.lbCif.Size = new System.Drawing.Size(26, 13);
            this.lbCif.TabIndex = 0;
            this.lbCif.Text = "CIF:";
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(24, 118);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbContacto
            // 
            this.lbContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbContacto.AutoSize = true;
            this.lbContacto.Location = new System.Drawing.Point(24, 266);
            this.lbContacto.Name = "lbContacto";
            this.lbContacto.Size = new System.Drawing.Size(109, 13);
            this.lbContacto.TabIndex = 3;
            this.lbContacto.Text = "Persona de contacto:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(24, 192);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 2;
            this.lbTelefono.Text = "Teléfono:";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(24, 340);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 426);
            this.Controls.Add(this.listBoxEmpresas);
            this.Controls.Add(this.lbEmpresas);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Vista detallada de empresas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbContacto;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCif;
        private System.Windows.Forms.Label lbEmpresas;
        private System.Windows.Forms.ListBox listBoxEmpresas;
    }
}

