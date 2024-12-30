using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectos
{
    public partial class VistaDetallesProyecto : Form
    {
        private int idProyecto;
        public event Action DatosActualizados;

        public VistaDetallesProyecto(string nombre, string fechaInicio, string fechaFin, string descripcion, int idProyecto)
        {

            InitializeComponent();


            this.idProyecto = idProyecto;

            lblNombreProyecto.Text = nombre;
            lblFechaInicio.Text = fechaInicio;
            lblFechaFin.Text = fechaFin;
            lblDescripcion.Text = descripcion;

            CargarTareas(this.idProyecto);
        }
        private void CargarTareas(int idProyecto)
        {
            using (var connection = new SQLiteConnection("Data Source=proyectos.db"))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT IDTarea, Titulo, Estado, TiempoEstimado, AsignadoA FROM Tareas WHERE IDProyecto = @IDProyecto", connection);
                command.Parameters.AddWithValue("@IDProyecto", idProyecto);
                var reader = command.ExecuteReader();

                var dt = new DataTable();
                dt.Load(reader);

                if (dgvTareas.InvokeRequired)
                {
                    dgvTareas.Invoke(new Action(() =>
                    {
                        dgvTareas.DataSource = dt;
                    }));
                }
                else
                {
                    dgvTareas.DataSource = dt;
                }
            }
        }

        private void ActualizarTarea(int idTarea, int nuevoTiempo, string nuevoEstado)
        {
            using (var connection = new SQLiteConnection("Data Source=proyectos.db"))
            {
                connection.Open();
                var command = new SQLiteCommand(
                    "UPDATE Tareas SET TiempoEstimado = @Tiempo, Estado = @Estado WHERE IDTarea = @IDTarea",
                    connection
                );
                command.Parameters.AddWithValue("@Tiempo", nuevoTiempo);
                command.Parameters.AddWithValue("@Estado", nuevoEstado);
                command.Parameters.AddWithValue("@IDTarea", idTarea);

                command.ExecuteNonQuery();
            }


            DatosActualizados?.Invoke();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            using (var formAgregarTarea = new frmAgregarTarea(idProyecto))
            {
                if (formAgregarTarea.ShowDialog() == DialogResult.OK)
                {
                    CargarTareas(idProyecto);
                }
            }
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            using (var formAgregarTarea = new frmAgregarTarea(idProyecto))
            {
                if (formAgregarTarea.ShowDialog() == DialogResult.OK)
                {
                    CargarTareas(idProyecto);
                }
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una tarea para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvTareas.SelectedRows[0];
            int idTarea = Convert.ToInt32(filaSeleccionada.Cells["IDTarea"].Value);

            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta tarea?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                using (var connection = new SQLiteConnection("Data Source=proyectos.db"))
                {
                    connection.Open();
                    var command = new SQLiteCommand("DELETE FROM Tareas WHERE IDTarea = @IDTarea", connection);
                    command.Parameters.AddWithValue("@IDTarea", idTarea);

                    command.ExecuteNonQuery();
                }


                CargarTareas(idProyecto);
            }
        }

        private void BtnCompletarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una tarea para completar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvTareas.SelectedRows[0];
            int idTarea = Convert.ToInt32(filaSeleccionada.Cells["IDTarea"].Value);

            using (var connection = new SQLiteConnection("Data Source=proyectos.db"))
            {
                connection.Open();
                var command = new SQLiteCommand("UPDATE Tareas SET Estado = 'Completado' WHERE IDTarea = @IDTarea", connection);
                command.Parameters.AddWithValue("@IDTarea", idTarea);

                command.ExecuteNonQuery();
            }


            CargarTareas(idProyecto);
        }
        private async void CargarTareasAsync(int idProyecto)
        {

            await Task.Run(() => CargarTareas(idProyecto));

        }
        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTiempoRestante_Click(object sender, EventArgs e)
        {

        }

        private void VistaDetallesProyecto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
