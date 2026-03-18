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

        private void Reportes_Load(object sender, EventArgs e)
        {
            // Aplicar el diseño visual al cargar el formulario
            EstilizarDataGridView();
        }

        private void EstilizarDataGridView()
        {
            // Colores de fondo y bordes
            dgvReportes.BackgroundColor = Color.White;
            dgvReportes.BorderStyle = BorderStyle.None;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.AllowUserToResizeRows = false;
            dgvReportes.RowHeadersVisible = false;

            // Diseño de los Encabezados (Header)
            dgvReportes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReportes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvReportes.ColumnHeadersHeight = 35;
            dgvReportes.EnableHeadersVisualStyles = false;

            // Diseño de las Celdas y Filas
            dgvReportes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvReportes.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvReportes.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Efecto Cebra (Filas alternas)
            dgvReportes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 245, 255);

            // Ajuste automático de columnas al ancho del panel
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbTipo.Text))
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

                // Asignar datos
                dgvReportes.DataSource = dt;

                // --- MEJORA DE NOMBRES DE COLUMNA ---
                if (dgvReportes.Columns.Count > 0)
                {
                    dgvReportes.Columns["id"].HeaderText = "N° Factura";
                    dgvReportes.Columns["fecha"].HeaderText = "Fecha / Hora";
                    dgvReportes.Columns["total"].HeaderText = "Monto (L)";
                    dgvReportes.Columns["usuario"].HeaderText = "Cajero";

                    // Formato de moneda para la columna Total
                    dgvReportes.Columns["total"].DefaultCellStyle.Format = "N2";
                    dgvReportes.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Cálculo del total para el Label
                string queryTotal = "SELECT SUM(total) FROM ventas WHERE " + filtro;
                SQLiteCommand cmdTotal = new SQLiteCommand(queryTotal, conn);
                object total = cmdTotal.ExecuteScalar();

                if (total != DBNull.Value)
                    lblTotal.Text = "Total: L " + Convert.ToDouble(total).ToString("N2");
                else
                    lblTotal.Text = "Total: L 0.00";
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            // Evento opcional
        }
    }
}