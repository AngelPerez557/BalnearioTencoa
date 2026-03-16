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
    public partial class Precios : Form
    {

        private void CargarPrecios()
        {
            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string query = "SELECT tipo, precio FROM precios";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["tipo"].ToString();
                    string precio = reader["precio"].ToString();

                    if (tipo == "adulto")
                        txtAdulto.Text = precio;

                    if (tipo == "nino")
                        txtNino.Text = precio;
                }
            }
        }

        public Precios()
        {
            InitializeComponent();
        }

        private void Precios_Load(object sender, EventArgs e)
        {
            CargarPrecios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAdulto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string query1 = "UPDATE precios SET precio=@precio WHERE tipo='adulto'";
                SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@precio", txtAdulto.Text);
                cmd1.ExecuteNonQuery();

                string query2 = "UPDATE precios SET precio=@precio WHERE tipo='nino'";
                SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@precio", txtNino.Text);
                cmd2.ExecuteNonQuery();
            }

            MessageBox.Show("Precios actualizados");
        }
    }
}
