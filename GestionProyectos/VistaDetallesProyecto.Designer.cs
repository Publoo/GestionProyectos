namespace GestionProyectos
{
    partial class VistaDetallesProyecto
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
            BtnCompletarTarea = new Button();
            btnEliminarTarea = new Button();
            dgvTareas = new DataGridView();
            lblNombreProyecto = new Label();
            label2 = new Label();
            label3 = new Label();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            label6 = new Label();
            lblDescripcion = new Label();
            panel1 = new Panel();
            label4 = new Label();
            btnAgregarTarea = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCompletarTarea
            // 
            BtnCompletarTarea.BackColor = Color.SeaGreen;
            BtnCompletarTarea.Location = new Point(320, 116);
            BtnCompletarTarea.Name = "BtnCompletarTarea";
            BtnCompletarTarea.Size = new Size(108, 26);
            BtnCompletarTarea.TabIndex = 2;
            BtnCompletarTarea.Text = "Completar Tarea";
            BtnCompletarTarea.UseVisualStyleBackColor = false;
            BtnCompletarTarea.Click += BtnCompletarTarea_Click;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackColor = Color.IndianRed;
            btnEliminarTarea.Location = new Point(434, 116);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(90, 26);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = false;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // dgvTareas
            // 
            dgvTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTareas.BackgroundColor = Color.OliveDrab;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(16, 159);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.Size = new Size(760, 263);
            dgvTareas.TabIndex = 4;
            dgvTareas.CellContentClick += dgvTareas_CellContentClick;
            // 
            // lblNombreProyecto
            // 
            lblNombreProyecto.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProyecto.Location = new Point(278, 0);
            lblNombreProyecto.Name = "lblNombreProyecto";
            lblNombreProyecto.Size = new Size(312, 92);
            lblNombreProyecto.TabIndex = 5;
            lblNombreProyecto.Text = "Nombre";
            lblNombreProyecto.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 17);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 44);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(16, 17);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(89, 15);
            lblFechaInicio.TabIndex = 8;
            lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(16, 52);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(74, 15);
            lblFechaFin.TabIndex = 9;
            lblFechaFin.Text = "Fecha de fin:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 44);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(596, 9);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(180, 133);
            lblDescripcion.TabIndex = 11;
            lblDescripcion.Text = "Descripcion ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAgregarTarea);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvTareas);
            panel1.Controls.Add(btnEliminarTarea);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(BtnCompletarTarea);
            panel1.Controls.Add(lblNombreProyecto);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblFechaFin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblFechaInicio);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 438);
            panel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 136);
            label4.Name = "label4";
            label4.Size = new Size(199, 20);
            label4.TabIndex = 14;
            label4.Text = "Lista de tareas del proyecto:";
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = Color.Teal;
            btnAgregarTarea.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarTarea.Location = new Point(221, 106);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(93, 47);
            btnAgregarTarea.TabIndex = 13;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 34);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 12;
            label1.Text = "al";
            // 
            // VistaDetallesProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 435);
            Controls.Add(panel1);
            Name = "VistaDetallesProyecto";
            Text = "VistaDetallesProyecto";
            Load += VistaDetallesProyecto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnCompletarTarea;
        private Button btnEliminarTarea;
        private DataGridView dgvTareas;
        private Label lblNombreProyecto;
        private Label label2;
        private Label label3;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private Label label6;
        private Label lblDescripcion;
        private Panel panel1;
        private Label label1;
        private Button btnAgregarTarea;
        private Label label4;
    }
}