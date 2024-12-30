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
    public partial class frmAgregarProyecto : Form
    {
        public frmAgregarProyecto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int IDProyecto = 0; // Este campo no se utiliza directamente para insertar
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFinal.Value;

            // Validación: El nombre no puede estar vacío
            if (string.IsNullOrEmpty(nombre))
            {
                lblEstatus.Text = "El nombre del proyecto no puede estar vacío.";
                return;
            }

            string connectionString = "Data Source=proyectos.db;Version=3;";
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                string query = @"
            INSERT INTO Proyectos (Nombre, Descripcion, FechaInicio, FechaFin)
            VALUES (@Nombre, @Descripcion, @FechaInicio, @FechaFin);";

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    // Asignar valores a los parámetros
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@FechaFin", fechaFin);

                    try
                    {
                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();
                        lblEstatus.Text = ""; // Limpiar cualquier mensaje de error previo
                        MessageBox.Show("Proyecto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cerrar el formulario si todo está correcto
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al agregar el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
    
