
namespace Balneario_Tencoa_Ticket
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(23, 30);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(134, 56);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender Entradas";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 411);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cerrar Sesion";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Location = new System.Drawing.Point(23, 114);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(134, 56);
            this.btnVerReportes.TabIndex = 5;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            // 
            // btnCambiarPrecios
            // 
            this.btnCambiarPrecios.Location = new System.Drawing.Point(23, 202);
            this.btnCambiarPrecios.Name = "btnCambiarPrecios";
            this.btnCambiarPrecios.Size = new System.Drawing.Size(134, 56);
            this.btnCambiarPrecios.TabIndex = 6;
            this.btnCambiarPrecios.Text = "Cambiar Precios";
            this.btnCambiarPrecios.UseVisualStyleBackColor = true;
            // 
            // btnAdmistrarUsuarios
            // 
            this.btnAdmistrarUsuarios.Location = new System.Drawing.Point(23, 288);
            this.btnAdmistrarUsuarios.Name = "btnAdmistrarUsuarios";
            this.btnAdmistrarUsuarios.Size = new System.Drawing.Size(134, 56);
            this.btnAdmistrarUsuarios.TabIndex = 7;
            this.btnAdmistrarUsuarios.Text = "Administar Usuarios";
            this.btnAdmistrarUsuarios.UseVisualStyleBackColor = true;
            this.btnAdmistrarUsuarios.Click += new System.EventHandler(this.btnAdmistrarUsuarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 499);
            this.Controls.Add(this.btnAdmistrarUsuarios);
            this.Controls.Add(this.btnCambiarPrecios);
            this.Controls.Add(this.btnVerReportes);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnVender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnCambiarPrecios;
        private System.Windows.Forms.Button btnAdmistrarUsuarios;
    }
}

