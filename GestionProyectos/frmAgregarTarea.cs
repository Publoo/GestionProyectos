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
    public partial class frmAgregarTarea : Form
    {
        private int idProyecto; 

        public frmAgregarTarea(int idProyecto)
        {
            InitializeComponent();
            this.idProyecto = idProyecto;

            
            cbxEstado.Items.AddRange(new string[] { "Pendiente", "En Proceso", "Completada" });
            cbxAsignadoA.Items.AddRange(new string[] { "Admin", "Usuario", "Pablo", "Jorge" });
            cbxEstado.SelectedIndex = 0;
            cbxAsignadoA.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título de la tarea es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection("Data Source=proyectos.db"))
                {
                    connection.Open();
                    var query = @"INSERT INTO Tareas (Titulo, Descripcion, Estado, TiempoEstimado, AsignadoA, IDProyecto) 
                          VALUES (@Titulo, @Descripcion, @Estado, @TiempoEstimado, @AsignadoA, @IDProyecto)";
                    var command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                    command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                    command.Parameters.AddWithValue("@Estado", cbxEstado.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TiempoEstimado", (int)numTiempoEstimado.Value);
                    command.Parameters.AddWithValue("@AsignadoA", cbxAsignadoA.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@IDProyecto", idProyecto);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Tarea agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            {
                this.Close(); 
            }
        }
    }
}
