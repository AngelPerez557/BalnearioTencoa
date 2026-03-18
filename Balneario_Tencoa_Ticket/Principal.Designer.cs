
namespace Balneario_Tencoa_Ticket
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnVender = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnCambiarPrecios = new System.Windows.Forms.Button();
            this.btnAdmistrarUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVender.Location = new System.Drawing.Point(3, 221);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(216, 56);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender Entradas";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(32, 617);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cerrar Sesion";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerReportes.FlatAppearance.BorderSize = 0;
            this.btnVerReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReportes.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVerReportes.Location = new System.Drawing.Point(3, 302);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(216, 56);
            this.btnVerReportes.TabIndex = 5;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // btnCambiarPrecios
            // 
            this.btnCambiarPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarPrecios.FlatAppearance.BorderSize = 0;
            this.btnCambiarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarPrecios.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCambiarPrecios.Location = new System.Drawing.Point(3, 385);
            this.btnCambiarPrecios.Name = "btnCambiarPrecios";
            this.btnCambiarPrecios.Size = new System.Drawing.Size(216, 56);
            this.btnCambiarPrecios.TabIndex = 6;
            this.btnCambiarPrecios.Text = "Cambiar Precios";
            this.btnCambiarPrecios.UseVisualStyleBackColor = true;
            this.btnCambiarPrecios.Click += new System.EventHandler(this.btnCambiarPrecios_Click);
            // 
            // btnAdmistrarUsuarios
            // 
            this.btnAdmistrarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmistrarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnAdmistrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmistrarUsuarios.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAdmistrarUsuarios.Location = new System.Drawing.Point(3, 465);
            this.btnAdmistrarUsuarios.Name = "btnAdmistrarUsuarios";
            this.btnAdmistrarUsuarios.Size = new System.Drawing.Size(216, 56);
            this.btnAdmistrarUsuarios.TabIndex = 7;
            this.btnAdmistrarUsuarios.Text = "Administar Usuarios";
            this.btnAdmistrarUsuarios.UseVisualStyleBackColor = true;
            this.btnAdmistrarUsuarios.Click += new System.EventHandler(this.btnAdmistrarUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnAdmistrarUsuarios);
            this.panel1.Controls.Add(this.btnVerReportes);
            this.panel1.Controls.Add(this.btnCambiarPrecios);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 675);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(223, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 115);
            this.panel2.TabIndex = 9;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Location = new System.Drawing.Point(225, 118);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(858, 558);
            this.pnlContenido.TabIndex = 10;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 674);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnCambiarPrecios;
        private System.Windows.Forms.Button btnAdmistrarUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContenido;
    }
}

