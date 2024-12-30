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



namespace GestionProyectos
{
    public partial class login : Form
    {
        bool salir;
        public login()
        {
            InitializeComponent();
            salir = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                lblMensaje.Text = "Ingresa usuario y/o contraseña.";
                lblMensaje.BackColor = Color.Red;
                lblMensaje.ForeColor = Color.White;
                return;
            }

           
            using (var connection = new SQLiteConnection("Data Source=proyectos.db;Version=3;"))
            {
                try
                {
                    connection.Open();

                    
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        command.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0) 
                        {
                            lblMensaje.Text = "Acceso concedido.";
                            lblMensaje.BackColor = Color.Green;
                            lblMensaje.ForeColor = Color.White;

                           
                            Form gestionForm = new Form1(txtUsuario.Text); 
                            gestionForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            lblMensaje.Text = "Usuario o contraseña incorrectos.";
                            lblMensaje.BackColor = Color.Red;
                            lblMensaje.ForeColor = Color.White;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
            {

            }

            private void txtUsuario_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
