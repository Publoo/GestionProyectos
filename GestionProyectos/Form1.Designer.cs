namespace GestionProyectos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvProyectos = new DataGridView();
            btnAgregarProyecto = new Button();
            btnDetalles = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            lblTiempoRestante = new Label();
            lblUsuario = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProyectos
            // 
            dgvProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProyectos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProyectos.BackgroundColor = Color.Honeydew;
            dgvProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyectos.Location = new Point(22, 194);
            dgvProyectos.Name = "dgvProyectos";
            dgvProyectos.ReadOnly = true;
            dgvProyectos.Size = new Size(738, 217);
            dgvProyectos.TabIndex = 0;
            dgvProyectos.CellClick += dgvProyectos_CellClick;
            dgvProyectos.CellContentClick += dgvProyectos_CellContentClick;
            // 
            // btnAgregarProyecto
            // 
            btnAgregarProyecto.BackColor = Color.DarkSeaGreen;
            btnAgregarProyecto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProyecto.Location = new Point(22, 93);
            btnAgregarProyecto.Name = "btnAgregarProyecto";
            btnAgregarProyecto.Size = new Size(98, 64);
            btnAgregarProyecto.TabIndex = 1;
            btnAgregarProyecto.Text = "Nuevo Proyecto";
            btnAgregarProyecto.UseVisualStyleBackColor = false;
            btnAgregarProyecto.Click += btn_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.DarkTurquoise;
            btnDetalles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetalles.Location = new Point(583, 106);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(177, 51);
            btnDetalles.TabIndex = 2;
            btnDetalles.Text = "VIsta avanzada / Gestionar tareas";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(605, 72);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 28);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Proyecto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkKhaki;
            label1.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, -3);
            label1.Name = "label1";
            label1.Size = new Size(287, 38);
            label1.TabIndex = 4;
            label1.Text = "Gestion de proyectos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTiempoRestante);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(btnAgregarProyecto);
            panel1.Controls.Add(btnDetalles);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(dgvProyectos);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 441);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(259, 82);
            label2.Name = "label2";
            label2.Size = new Size(233, 75);
            label2.TabIndex = 7;
            label2.Text = "Mucho éxito en tus proyectos. ¿Que deseas consultar?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(22, 170);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 6;
            label3.Text = "Lista de proyectos:";
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.AutoSize = true;
            lblTiempoRestante.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTiempoRestante.ForeColor = Color.DarkCyan;
            lblTiempoRestante.Location = new Point(486, 173);
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(291, 17);
            lblTiempoRestante.TabIndex = 6;
            lblTiempoRestante.Text = "Seleccione un proyecto para ver su tiempo restante";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Sitka Text", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.RoyalBlue;
            lblUsuario.Location = new Point(12, 16);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(74, 19);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Bienvenido";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(779, 441);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Proyectos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProyectos;
        private Button btnAgregarProyecto;
        private Button btnDetalles;
        private Button btnEliminar;
        private Label label1;
        private Panel panel1;
        private Label lblUsuario;
        private Label label3;
        private Label lblTiempoRestante;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}
