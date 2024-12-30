namespace GestionProyectos
{
    partial class frmAgregarProyecto
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
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFinal = new DateTimePicker();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblEstatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del proyecto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 132);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha de inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 187);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de finalizacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(-38, 0);
            label4.Name = "label4";
            label4.Size = new Size(304, 21);
            label4.TabIndex = 100;
            label4.Text = "____________ Agregar Proyecto ___________";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LemonChiffon;
            btnGuardar.Location = new Point(42, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 44);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar y empezar proyecto.";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveBorder;
            txtNombre.Location = new Point(9, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(9, 150);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(203, 23);
            dtpFechaInicio.TabIndex = 3;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(9, 205);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(203, 23);
            dtpFechaFinal.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Location = new Point(9, 99);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(160, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 81);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.RightToLeft = RightToLeft.Yes;
            lblDescripcion.Size = new Size(141, 15);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripcion del proyecto:";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(6, 285);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(16, 15);
            lblEstatus.TabIndex = 8;
            lblEstatus.Text = "...";
            // 
            // frmAgregarProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(234, 309);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblEstatus);
            Controls.Add(dtpFechaFinal);
            Controls.Add(dtpFechaInicio);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAgregarProyecto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Proyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFinal;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Label lblEstatus;
    }
}