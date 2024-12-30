namespace GestionProyectos

{
    using System.Data;
    using System.Data.SQLite;
    public partial class Form1 : Form
    {
        private int idProyecto;


        public Form1(string usuario)

        {
            InitializeComponent();
            lblUsuario.Text = $"Bienvenido, {usuario}!";


            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void CalcularTiempoRestante(int idProyecto)
        {
            Task.Run(() =>
            {
                using (var connection = new SQLiteConnection("Data Source=proyectos.db"))
                {
                    connection.Open();
                    var command = new SQLiteCommand(
                        "SELECT SUM(TiempoEstimado) FROM Tareas WHERE IDProyecto = @ID AND Estado = 'Pendiente'",
                        connection
                    );
                    command.Parameters.AddWithValue("@ID", idProyecto);
                    var resultado = command.ExecuteScalar();
                    int tiempoRestante = resultado != DBNull.Value ? Convert.ToInt32(resultado) : 0;

                    this.Invoke((MethodInvoker)delegate
                    {
                        lblTiempoRestante.Text = $"Tiempo Restante: {tiempoRestante} horas";
                    });
                }
            });
        }
        private void InicializarBaseDeDatos()
        {
            string connectionString = "Data Source=proyectos.db;Version=3;";
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
            }
        }

        private void CargarProyectosEnGrid()
        {
            string connectionString = "Data Source=proyectos.db;Version=3;";
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT IDProyecto, Nombre, Descripcion, FechaInicio, FechaFin FROM Proyectos";

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                {
                    DataTable tablaProyectos = new DataTable();
                    adaptador.Fill(tablaProyectos);

                    dgvProyectos.DataSource = tablaProyectos;
                }

            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarBaseDeDatos();
            CargarProyectosEnGrid();


        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmAgregarProyecto agregarProyectoForm = new frmAgregarProyecto();
            if (agregarProyectoForm.ShowDialog() == DialogResult.OK)
            {
                CargarProyectosEnGrid();
            }
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count > 0)
            {
                idProyecto = Convert.ToInt32(dgvProyectos.SelectedRows[0].Cells["IDProyecto"].Value);
                CalcularTiempoRestante(idProyecto);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();

        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count > 0)
            {
                int idProyecto = Convert.ToInt32(dgvProyectos.SelectedRows[0].Cells["IDProyecto"].Value);
                CalcularTiempoRestante(idProyecto);

                string nombre = dgvProyectos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string descripcion = dgvProyectos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                string fechaInicio = dgvProyectos.SelectedRows[0].Cells["FechaInicio"].Value.ToString();
                string fechaFin = dgvProyectos.SelectedRows[0].Cells["FechaFin"].Value.ToString();

                var vistaDetalles = new VistaDetallesProyecto(nombre, fechaInicio, fechaFin, descripcion, idProyecto);


                vistaDetalles.DatosActualizados += () =>
                {
                    Console.WriteLine("Datos actualizados, recalculando tiempo...");
                    CalcularTiempoRestante(idProyecto);
                };

                vistaDetalles.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un proyecto para ver los detalles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una tarea para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvProyectos.SelectedRows[0];
            int idProyecto = Convert.ToInt32(filaSeleccionada.Cells["IDProyecto"].Value);

            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este proyecto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                using (var connection = new SQLiteConnection("Data Source=proyectos.db"))
                {
                    connection.Open();
                    var command = new SQLiteCommand("DELETE FROM Proyectos WHERE IDProyecto = @IDProyecto", connection);
                    command.Parameters.AddWithValue("IDProyecto", idProyecto);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Proyecto eliminado.", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarProyectosEnGrid();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (idProyecto > 0)
            {
                CalcularTiempoRestante(idProyecto);
            }
        }

        private void dgvProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count > 0)
            {
                idProyecto = Convert.ToInt32(dgvProyectos.SelectedRows[0].Cells["IDProyecto"].Value);
                CalcularTiempoRestante(idProyecto);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
