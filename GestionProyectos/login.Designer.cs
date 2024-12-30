namespace GestionProyectos
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtContrasena = new TextBox();
            label3 = new Label();
            btnAceptar = new Button();
            lblMensaje = new Label();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkKhaki;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 60);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkKhaki;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 129);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(46, 153);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(140, 23);
            txtContrasena.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cornsilk;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(-63, 1);
            label3.Name = "label3";
            label3.Size = new Size(420, 18);
            label3.TabIndex = 4;
            label3.Text = "                      Ingresar a Pro Planner                                 ";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LemonChiffon;
            btnAceptar.Font = new Font("Candara", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(69, 197);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(77, 28);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Ingresar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(2, 264);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(86, 15);
            lblMensaje.TabIndex = 6;
            lblMensaje.Text = "Ingrese datos...";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(46, 84);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(140, 23);
            txtUsuario.TabIndex = 7;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(246, 285);
            Controls.Add(txtUsuario);
            Controls.Add(lblMensaje);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log-In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtContrasena;
        private Label label3;
        private Button btnAceptar;
        private Label lblMensaje;
        private TextBox txtUsuario;
    }
}