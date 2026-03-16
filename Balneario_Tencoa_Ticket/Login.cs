using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Balneario_Tencoa_Ticket
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPsw.Text;

            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string query = @"SELECT es_admin 
                         FROM usuarios 
                         WHERE username=@user AND password=@pass";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", password);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    bool esAdmin = Convert.ToInt32(resultado) == 1;

                    Form1 sistema = new Form1(esAdmin);
                    sistema.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }
    }
}
