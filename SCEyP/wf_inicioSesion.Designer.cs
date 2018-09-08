namespace SCEyP
{
    partial class wf_inicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_inicioSesion));
            this.txtnombreUsuario = new System.Windows.Forms.TextBox();
            this.txtcontrasenaAcceso = new System.Windows.Forms.TextBox();
            this.btninicioSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llrecuperarContrasena = new System.Windows.Forms.LinkLabel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombreUsuario
            // 
            this.txtnombreUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreUsuario.Location = new System.Drawing.Point(23, 205);
            this.txtnombreUsuario.MaxLength = 50;
            this.txtnombreUsuario.Name = "txtnombreUsuario";
            this.txtnombreUsuario.Size = new System.Drawing.Size(252, 22);
            this.txtnombreUsuario.TabIndex = 0;
            // 
            // txtcontrasenaAcceso
            // 
            this.txtcontrasenaAcceso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasenaAcceso.Location = new System.Drawing.Point(23, 257);
            this.txtcontrasenaAcceso.MaxLength = 20;
            this.txtcontrasenaAcceso.Name = "txtcontrasenaAcceso";
            this.txtcontrasenaAcceso.Size = new System.Drawing.Size(252, 22);
            this.txtcontrasenaAcceso.TabIndex = 1;
            this.txtcontrasenaAcceso.UseSystemPasswordChar = true;
            // 
            // btninicioSesion
            // 
            this.btninicioSesion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicioSesion.Image = ((System.Drawing.Image)(resources.GetObject("btninicioSesion.Image")));
            this.btninicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninicioSesion.Location = new System.Drawing.Point(74, 314);
            this.btninicioSesion.Name = "btninicioSesion";
            this.btninicioSesion.Size = new System.Drawing.Size(157, 46);
            this.btninicioSesion.TabIndex = 2;
            this.btninicioSesion.Text = "Inicio de sesión";
            this.btninicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninicioSesion.UseVisualStyleBackColor = true;
            this.btninicioSesion.Click += new System.EventHandler(this.btninicioSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.llrecuperarContrasena);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnombreUsuario);
            this.panel1.Controls.Add(this.btninicioSesion);
            this.panel1.Controls.Add(this.txtcontrasenaAcceso);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 387);
            this.panel1.TabIndex = 3;
            // 
            // llrecuperarContrasena
            // 
            this.llrecuperarContrasena.AutoSize = true;
            this.llrecuperarContrasena.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llrecuperarContrasena.Location = new System.Drawing.Point(113, 282);
            this.llrecuperarContrasena.Name = "llrecuperarContrasena";
            this.llrecuperarContrasena.Size = new System.Drawing.Size(162, 14);
            this.llrecuperarContrasena.TabIndex = 6;
            this.llrecuperarContrasena.TabStop = true;
            this.llrecuperarContrasena.Text = "Olvide mi contraseña, recuperar";
            this.llrecuperarContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llrecuperarContrasena_LinkClicked);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.Location = new System.Drawing.Point(74, 21);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(157, 123);
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña de acceso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de usuario:";
            // 
            // wf_inicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "wf_inicioSesion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.wf_inicioSesion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombreUsuario;
        private System.Windows.Forms.TextBox txtcontrasenaAcceso;
        private System.Windows.Forms.Button btninicioSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llrecuperarContrasena;
    }
}