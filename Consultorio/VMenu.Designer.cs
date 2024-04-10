namespace Consultorio
{
    partial class VMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VMenu));
            this.PnlMENU = new System.Windows.Forms.Panel();
            this.BtnCitas = new System.Windows.Forms.Button();
            this.BtnPacientes = new System.Windows.Forms.Button();
            this.BtnMedicos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PtbLogo = new System.Windows.Forms.PictureBox();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlMENU.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMENU
            // 
            this.PnlMENU.BackColor = System.Drawing.Color.White;
            this.PnlMENU.Controls.Add(this.BtnCitas);
            this.PnlMENU.Controls.Add(this.BtnPacientes);
            this.PnlMENU.Controls.Add(this.BtnMedicos);
            this.PnlMENU.Controls.Add(this.panel1);
            this.PnlMENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMENU.Location = new System.Drawing.Point(0, 0);
            this.PnlMENU.Name = "PnlMENU";
            this.PnlMENU.Size = new System.Drawing.Size(179, 509);
            this.PnlMENU.TabIndex = 0;
            // 
            // BtnCitas
            // 
            this.BtnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCitas.FlatAppearance.BorderSize = 0;
            this.BtnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCitas.Image = global::Consultorio.Properties.Resources.icons8_documentos_25;
            this.BtnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCitas.Location = new System.Drawing.Point(0, 218);
            this.BtnCitas.Name = "BtnCitas";
            this.BtnCitas.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.BtnCitas.Size = new System.Drawing.Size(179, 50);
            this.BtnCitas.TabIndex = 3;
            this.BtnCitas.Text = " Citas";
            this.BtnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCitas.UseVisualStyleBackColor = true;
            this.BtnCitas.Click += new System.EventHandler(this.BtnCitas_Click);
            // 
            // BtnPacientes
            // 
            this.BtnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPacientes.FlatAppearance.BorderSize = 0;
            this.BtnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPacientes.Image = global::Consultorio.Properties.Resources.icons8_grupo_de_usuarios_hombre_y_mujer_25;
            this.BtnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPacientes.Location = new System.Drawing.Point(0, 168);
            this.BtnPacientes.Name = "BtnPacientes";
            this.BtnPacientes.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.BtnPacientes.Size = new System.Drawing.Size(179, 50);
            this.BtnPacientes.TabIndex = 2;
            this.BtnPacientes.Text = " Pacientes";
            this.BtnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPacientes.UseVisualStyleBackColor = true;
            this.BtnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
            // 
            // BtnMedicos
            // 
            this.BtnMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMedicos.FlatAppearance.BorderSize = 0;
            this.BtnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedicos.Image = global::Consultorio.Properties.Resources.icons8_doctor_25;
            this.BtnMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMedicos.Location = new System.Drawing.Point(0, 118);
            this.BtnMedicos.Name = "BtnMedicos";
            this.BtnMedicos.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.BtnMedicos.Size = new System.Drawing.Size(179, 50);
            this.BtnMedicos.TabIndex = 0;
            this.BtnMedicos.Text = " Medicos";
            this.BtnMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMedicos.UseVisualStyleBackColor = true;
            this.BtnMedicos.Click += new System.EventHandler(this.BtnMedicos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PtbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 118);
            this.panel1.TabIndex = 1;
            // 
            // PtbLogo
            // 
            this.PtbLogo.Image = global::Consultorio.Properties.Resources.icons8_encontrar_clínica_100;
            this.PtbLogo.Location = new System.Drawing.Point(51, 6);
            this.PtbLogo.Name = "PtbLogo";
            this.PtbLogo.Size = new System.Drawing.Size(80, 80);
            this.PtbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLogo.TabIndex = 1;
            this.PtbLogo.TabStop = false;
            this.PtbLogo.Click += new System.EventHandler(this.PtbLogo_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(179, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(730, 509);
            this.PnlContenedor.TabIndex = 1;
            // 
            // VMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 509);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlMENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.VMenu_Load);
            this.PnlMENU.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PtbLogo;
        private System.Windows.Forms.Panel PnlMENU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCitas;
        private System.Windows.Forms.Button BtnPacientes;
        private System.Windows.Forms.Button BtnMedicos;
        private System.Windows.Forms.Panel PnlContenedor;
    }
}