namespace Balneario_Tencoa_Ticket
{
    partial class Entradas
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
            this.label1 = new System.Windows.Forms.Label();
            this.numAdultos = new System.Windows.Forms.NumericUpDown();
            this.numNinos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNinos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADULTOS";
            // 
            // numAdultos
            // 
            this.numAdultos.Location = new System.Drawing.Point(121, 25);
            this.numAdultos.Name = "numAdultos";
            this.numAdultos.Size = new System.Drawing.Size(120, 22);
            this.numAdultos.TabIndex = 1;
            this.numAdultos.ValueChanged += new System.EventHandler(this.numAdultos_ValueChanged);
            // 
            // numNinos
            // 
            this.numNinos.Location = new System.Drawing.Point(121, 71);
            this.numNinos.Name = "numNinos";
            this.numNinos.Size = new System.Drawing.Size(120, 22);
            this.numNinos.TabIndex = 2;
            this.numNinos.ValueChanged += new System.EventHandler(this.numNinos_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIÑOS";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(173, 146);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 17);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: L 0";
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(37, 127);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(110, 42);
            this.btnCobrar.TabIndex = 5;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 207);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numNinos);
            this.Controls.Add(this.numAdultos);
            this.Controls.Add(this.label1);
            this.Name = "Entradas";
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAdultos;
        private System.Windows.Forms.NumericUpDown numNinos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
    }
}