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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "")
            {
                MessageBox.Show("Seleccione el tipo de reporte");
                return;
            }

            string conexion = "Data Source=Tencoa.db;Version=3;";
            string filtro = "";

            if (cmbTipo.Text == "Diario")
                filtro = "date(fecha) = date('now')";

            if (cmbTipo.Text == "Semanal")
                filtro = "strftime('%Y-%W',fecha) = strftime('%Y-%W','now')";

            if (cmbTipo.Text == "Mensual")
                filtro = "strftime('%Y-%m',fecha) = strftime('%Y-%m','now')";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string query = @"SELECT id, fecha, total, usuario
                         FROM ventas
                         WHERE " + filtro + " ORDER BY fecha DESC";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReportes.DataSource = dt;

                string queryTotal = "SELECT SUM(total) FROM ventas WHERE " + filtro;

                SQLiteCommand cmdTotal = new SQLiteCommand(queryTotal, conn);

                object total = cmdTotal.ExecuteScalar();

                if (total != DBNull.Value)
                    lblTotal.Text = "Total: L " + Convert.ToDouble(total).ToString("N2");
                else
                    lblTotal.Text = "Total: L 0";
            }
        }
    }
}
