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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void CargarUsuarios()
        {
            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string query = "SELECT id, username, es_admin FROM usuarios";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvUsuarios.DataSource = dt;
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int idSeleccionado = -1;
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);

                txtNombre.Text = fila.Cells["username"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text;
            string password = txtPsw.Text;

            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string query = @"INSERT INTO usuarios (username,password,es_admin)
                         VALUES (@user,@pass,0)";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", password);

                cmd.ExecuteNonQuery();
            }

            CargarUsuarios();

            txtNombre.Clear();
            txtPsw.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            string usuario = txtNombre.Text;
            string password = txtPsw.Text;

            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string query = @"UPDATE usuarios
                         SET username=@user,
                         password=@pass
                         WHERE id=@id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);

                cmd.ExecuteNonQuery();
            }

            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string query = "DELETE FROM usuarios WHERE id=@id AND es_admin= 0";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);

                cmd.ExecuteNonQuery();
            }

            CargarUsuarios();

            txtNombre.Clear();
            txtPsw.Clear();

            idSeleccionado = -1;
        }
    }
}
