namespace GestionProyectos
{
    partial class frmAgregarTarea
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
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtTitulo = new TextBox();
            txtDescripcion = new TextBox();
            cbxEstado = new ComboBox();
            numTiempoEstimado = new NumericUpDown();
            label6 = new Label();
            cbxAsignadoA = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)numTiempoEstimado).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(-24, 9);
            label4.Name = "label4";
            label4.Size = new Size(290, 21);
            label4.TabIndex = 4;
            label4.Text = "____________  Agregar Tarea  ___________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(52, 43);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(46, 98);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(86, 152);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Estado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(52, 208);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 8;
            label5.Text = "Tiempo Estimado (hrs)";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.Wheat;
            txtTitulo.Location = new Point(34, 61);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(173, 23);
            txtTitulo.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.Wheat;
            txtDescripcion.Location = new Point(34, 116);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(173, 23);
            txtDescripcion.TabIndex = 10;
            // 
            // cbxEstado
            // 
            cbxEstado.BackColor = Color.Wheat;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(52, 170);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(133, 23);
            cbxEstado.TabIndex = 11;
            // 
            // numTiempoEstimado
            // 
            numTiempoEstimado.BackColor = Color.Wheat;
            numTiempoEstimado.Location = new Point(86, 226);
            numTiempoEstimado.Name = "numTiempoEstimado";
            numTiempoEstimado.Size = new Size(45, 23);
            numTiempoEstimado.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(75, 261);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 13;
            label6.Text = "Asignado a:";
            // 
            // cbxAsignadoA
            // 
            cbxAsignadoA.BackColor = Color.Wheat;
            cbxAsignadoA.FormattingEnabled = true;
            cbxAsignadoA.Location = new Point(46, 279);
            cbxAsignadoA.Name = "cbxAsignadoA";
            cbxAsignadoA.Size = new Size(139, 23);
            cbxAsignadoA.TabIndex = 14;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.Location = new Point(12, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 38);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SeaGreen;
            btnGuardar.Location = new Point(117, 322);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 27);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmAgregarTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(250, 372);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(cbxAsignadoA);
            Controls.Add(label6);
            Controls.Add(numTiempoEstimado);
            Controls.Add(cbxEstado);
            Controls.Add(txtDescripcion);
            Controls.Add(txtTitulo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "frmAgregarTarea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Tarea";
            ((System.ComponentModel.ISupportInitialize)numTiempoEstimado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtTitulo;
        private TextBox txtDescripcion;
        private ComboBox cbxEstado;
        private NumericUpDown numTiempoEstimado;
        private Label label6;
        private ComboBox cbxAsignadoA;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}