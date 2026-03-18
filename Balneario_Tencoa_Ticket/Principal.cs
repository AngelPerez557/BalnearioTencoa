using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Balneario_Tencoa_Ticket
{
    public partial class Principal : Form
    {
        bool esAdmin;
        string UsuarioActual;

        public Principal(bool admin, string usuario)
        {
            InitializeComponent();
            esAdmin = admin;
            UsuarioActual = usuario;
            CrearBaseDeDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!esAdmin)
            {
                MessageBox.Show("Modo empleado");

                // ocultar funciones de administrador
                btnAdmistrarUsuarios.Visible = false;
                btnCambiarPrecios.Visible = false;
                btnVerReportes.Visible = false;
            }
            else
            {
                MessageBox.Show("Modo administrador");
            }
        }

        // --- MÉTODO PARA CARGAR VISTAS EN EL PANEL ---
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Limpiamos el panel por si ya hay otra vista cargada
            if (this.pnlContenido.Controls.Count > 0)
                this.pnlContenido.Controls.RemoveAt(0);

            // Configuramos el formulario para que se comporte como un control
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Agregamos al panel y mostramos
            this.pnlContenido.Controls.Add(formularioHijo);
            this.pnlContenido.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void CrearBaseDeDatos()
        {
            string conexion = "Data Source=Tencoa.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS ventas (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    fecha TEXT,
                    total REAL,
                    usuario TEXT
                );

                CREATE TABLE IF NOT EXISTS registro_entradas (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    venta_id INTEGER,
                    adultos INTEGER,
                    ninos INTEGER,
                    total_personas INTEGER
                );

                CREATE TABLE IF NOT EXISTS precios (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    tipo TEXT UNIQUE,
                    precio REAL
                );

                CREATE TABLE IF NOT EXISTS usuarios (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT UNIQUE,
                    password TEXT,
                    es_admin INTEGER
                );";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                string check = "SELECT COUNT(*) FROM precios";
                SQLiteCommand cmdCheck = new SQLiteCommand(check, conn);
                long cantidad = (long)cmdCheck.ExecuteScalar();

                if (cantidad == 0)
                {
                    string insert = @"
                    INSERT INTO precios (tipo,precio) VALUES ('adulto',100);
                    INSERT INTO precios (tipo,precio) VALUES ('nino',50);";

                    SQLiteCommand cmdInsert = new SQLiteCommand(insert, conn);
                    cmdInsert.ExecuteNonQuery();
                }

                string checkAdmin = "SELECT COUNT(*) FROM usuarios WHERE username='admin'";
                SQLiteCommand cmdCheckAdmin = new SQLiteCommand(checkAdmin, conn);
                long existe = (long)cmdCheckAdmin.ExecuteScalar();

                if (existe == 0)
                {
                    string crearAdmin = @"
                    INSERT INTO usuarios (username,password,es_admin)
                    VALUES ('admin','admin123',1);";

                    SQLiteCommand cmdAdmin = new SQLiteCommand(crearAdmin, conn);
                    cmdAdmin.ExecuteNonQuery();
                }
            }
        }

        // --- EVENTOS ACTUALIZADOS PARA USAR EL PANEL ---

        private void btnVender_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Entradas(UsuarioActual));
        }

        private void btnAdmistrarUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Usuarios());
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Reportes());
        }

        private void btnCambiarPrecios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Precios());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            MessageBox.Show("Sesion Cerrada Exitosamente");
            this.Close();
        }
    }
}