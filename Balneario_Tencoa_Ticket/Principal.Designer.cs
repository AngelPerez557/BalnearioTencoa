
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
            this.btnVender = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnCambiarPrecios = new System.Windows.Forms.Button();
            this.btnAdmistrarUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(59, 69);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(134, 56);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender Entradas";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(59, 609);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cerrar Sesion";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Location = new System.Drawing.Point(59, 142);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(134, 56);
            this.btnVerReportes.TabIndex = 5;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // btnCambiarPrecios
            // 
            this.btnCambiarPrecios.Location = new System.Drawing.Point(59, 218);
            this.btnCambiarPrecios.Name = "btnCambiarPrecios";
            this.btnCambiarPrecios.Size = new System.Drawing.Size(134, 56);
            this.btnCambiarPrecios.TabIndex = 6;
            this.btnCambiarPrecios.Text = "Cambiar Precios";
            this.btnCambiarPrecios.UseVisualStyleBackColor = true;
            this.btnCambiarPrecios.Click += new System.EventHandler(this.btnCambiarPrecios_Click);
            // 
            // btnAdmistrarUsuarios
            // 
            this.btnAdmistrarUsuarios.Location = new System.Drawing.Point(59, 302);
            this.btnAdmistrarUsuarios.Name = "btnAdmistrarUsuarios";
            this.btnAdmistrarUsuarios.Size = new System.Drawing.Size(134, 56);
            this.btnAdmistrarUsuarios.TabIndex = 7;
            this.btnAdmistrarUsuarios.Text = "Administar Usuarios";
            this.btnAdmistrarUsuarios.UseVisualStyleBackColor = true;
            this.btnAdmistrarUsuarios.Click += new System.EventHandler(this.btnAdmistrarUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnAdmistrarUsuarios);
            this.panel1.Controls.Add(this.btnVerReportes);
            this.panel1.Controls.Add(this.btnCambiarPrecios);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 675);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(276, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 100);
            this.panel2.TabIndex = 9;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 674);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnCambiarPrecios;
        private System.Windows.Forms.Button btnAdmistrarUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

