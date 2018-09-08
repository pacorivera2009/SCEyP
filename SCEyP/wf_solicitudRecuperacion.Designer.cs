namespace SCEyP
{
    partial class wf_solicitudRecuperacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_solicitudRecuperacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombreUsuario = new System.Windows.Forms.TextBox();
            this.btnrecuperacionAcceso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnrecuperacionAcceso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnombreUsuario);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 110);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de usuario:";
            // 
            // txtnombreUsuario
            // 
            this.txtnombreUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreUsuario.Location = new System.Drawing.Point(23, 38);
            this.txtnombreUsuario.MaxLength = 50;
            this.txtnombreUsuario.Name = "txtnombreUsuario";
            this.txtnombreUsuario.Size = new System.Drawing.Size(252, 22);
            this.txtnombreUsuario.TabIndex = 4;
            // 
            // btnrecuperacionAcceso
            // 
            this.btnrecuperacionAcceso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecuperacionAcceso.Image = ((System.Drawing.Image)(resources.GetObject("btnrecuperacionAcceso.Image")));
            this.btnrecuperacionAcceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrecuperacionAcceso.Location = new System.Drawing.Point(136, 66);
            this.btnrecuperacionAcceso.Name = "btnrecuperacionAcceso";
            this.btnrecuperacionAcceso.Size = new System.Drawing.Size(139, 34);
            this.btnrecuperacionAcceso.TabIndex = 6;
            this.btnrecuperacionAcceso.Text = "Enviar solicitud";
            this.btnrecuperacionAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrecuperacionAcceso.UseVisualStyleBackColor = true;
            this.btnrecuperacionAcceso.Click += new System.EventHandler(this.btnrecuperacionAcceso_Click);
            // 
            // wf_solicitudRecuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 136);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "wf_solicitudRecuperacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación de contraseña de acceso";
            this.Load += new System.EventHandler(this.wf_solicitudRecuperacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombreUsuario;
        private System.Windows.Forms.Button btnrecuperacionAcceso;
    }
}