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
using System.Drawing.Printing;

namespace Balneario_Tencoa_Ticket
{
    public partial class Entradas : Form
    {
        string UsuarioActual;

        int AdultosTicket;
        int ninosTicket;
        double totalTicket;
        
        public Entradas(string usuario)
        {
            InitializeComponent();
            UsuarioActual = usuario;
        }

        private double ObtenerPrecio(string tipo)
        {
            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string query = "SELECT precio FROM precios WHERE tipo=@tipo";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                    return Convert.ToDouble(resultado);

                return 0;
            }
        }

        private void CalcularTotal()
        {
            int adultos = (int)numAdultos.Value;
            int ninos = (int)numNinos.Value;

            double precioAdulto = ObtenerPrecio("adulto");
            double precioNino = ObtenerPrecio("nino");

            double total = (adultos * precioAdulto) + (ninos * precioNino);

            lblTotal.Text = "TOTAL: L " + total;
        }

        private void Entradas_Load(object sender, EventArgs e)
        {

        }

        private void numAdultos_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void numNinos_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            int adultos = (int)numAdultos.Value;
            int ninos = (int)numNinos.Value;

            double precioAdulto = ObtenerPrecio("adulto");
            double precioNino = ObtenerPrecio("nino");
            

            double total = (adultos * precioAdulto) + (ninos * precioNino);
            AdultosTicket = adultos;
            ninosTicket = ninos;
            totalTicket = total;


            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string queryVenta = @"INSERT INTO ventas (fecha,total,usuario)
                              VALUES (@fecha,@total,@usuario)";

                SQLiteCommand cmdVenta = new SQLiteCommand(queryVenta, conn);

                cmdVenta.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmdVenta.Parameters.AddWithValue("@total", total);
                cmdVenta.Parameters.AddWithValue("@usuario", UsuarioActual);

                cmdVenta.ExecuteNonQuery();

                long ventaId = conn.LastInsertRowId;

                int totalPersonas = adultos + ninos;

                string queryRegistro = @"INSERT INTO registro_entradas
                                 (venta_id,adultos,ninos,total_personas)
                                 VALUES (@venta,@adultos,@ninos,@total)";

                SQLiteCommand cmdRegistro = new SQLiteCommand(queryRegistro, conn);

                cmdRegistro.Parameters.AddWithValue("@venta", ventaId);
                cmdRegistro.Parameters.AddWithValue("@adultos", adultos);
                cmdRegistro.Parameters.AddWithValue("@ninos", ninos);
                cmdRegistro.Parameters.AddWithValue("@total", totalPersonas);

                cmdRegistro.ExecuteNonQuery();
            }

            MessageBox.Show("Venta registrada");
            ImprimirTicket();

            numAdultos.Value = 0;
            numNinos.Value = 0;
        }

        private void ImprimirTicket()
        {
            PrintDocument pd = new PrintDocument();
            double precioAdulto = ObtenerPrecio("adulto");
            double precioNino = ObtenerPrecio("nino");

            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;

                Font titulo = new Font("Consolas", 14, FontStyle.Bold);
                Font texto = new Font("Consolas", 10);

                int y = 10;
               
                g.DrawString("BALNEARIO TENCOA", titulo, Brushes.Black, 10, y);
                y += 40;

                g.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"), texto, Brushes.Black, 10, y);
                y += 20;

                g.DrawString("Hora : " + DateTime.Now.ToString("HH:mm"), texto, Brushes.Black, 10, y);
                y += 20;

                g.DrawString("Cajero: " + UsuarioActual, texto, Brushes.Black, 10, y);
                y += 30;

                g.DrawString("Adultos: " + AdultosTicket +" X " + precioAdulto , texto, Brushes.Black, 10, y);
                y += 20;

                g.DrawString("Niños  : " + ninosTicket + " X "+ precioNino, texto, Brushes.Black, 10, y);
                y += 20;

                g.DrawString("----------------------------", texto, Brushes.Black, 10, y);
                y += 20;

                g.DrawString("Total Personas: " + (AdultosTicket + ninosTicket), texto, Brushes.Black, 10, y);
                y += 30;

                g.DrawString("TOTAL: L " + totalTicket.ToString("N2"), titulo, Brushes.Black, 10, y);
                y += 40;

                g.DrawString("¡Gracias por visitarnos!", texto, Brushes.Black, 10, y);
                y += 20;

                g.DrawString("Disfrute su estadía", texto, Brushes.Black, 10, y);
            };

            pd.Print();
        }
    }
}
