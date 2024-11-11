namespace Proyecto_DAE.Vistas
{
    partial class ReportesEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesEstudiantes));
            dataGrados = new DataGridView();
            dataEstudiantes = new DataGridView();
            btnCrearReporte = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataEstudiantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGrados
            // 
            dataGrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrados.Location = new Point(51, 117);
            dataGrados.MultiSelect = false;
            dataGrados.Name = "dataGrados";
            dataGrados.ReadOnly = true;
            dataGrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrados.Size = new Size(281, 282);
            dataGrados.TabIndex = 0;
            dataGrados.SelectionChanged += dataGrados_SelectionChanged;
            // 
            // dataEstudiantes
            // 
            dataEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEstudiantes.Location = new Point(371, 117);
            dataEstudiantes.MultiSelect = false;
            dataEstudiantes.Name = "dataEstudiantes";
            dataEstudiantes.ReadOnly = true;
            dataEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataEstudiantes.Size = new Size(281, 282);
            dataEstudiantes.TabIndex = 1;
            dataEstudiantes.SelectionChanged += dataEstudiantes_SelectionChanged;
            // 
            // btnCrearReporte
            // 
            btnCrearReporte.BackColor = Color.YellowGreen;
            btnCrearReporte.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearReporte.Location = new Point(274, 419);
            btnCrearReporte.Name = "btnCrearReporte";
            btnCrearReporte.Size = new Size(168, 50);
            btnCrearReporte.TabIndex = 2;
            btnCrearReporte.Text = "Crear Reporte";
            btnCrearReporte.UseVisualStyleBackColor = false;
            btnCrearReporte.Click += btnCrearReporte_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(224, 46);
            label1.Name = "label1";
            label1.Size = new Size(264, 25);
            label1.TabIndex = 4;
            label1.Text = "CREACIÓN DE REPORTE";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(554, -16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(178, 94);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1, -15);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(123, 93);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // ReportesEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(701, 481);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCrearReporte);
            Controls.Add(dataEstudiantes);
            Controls.Add(dataGrados);
            Name = "ReportesEstudiantes";
            Text = "Reportes de Estudiantes";
            Load += ReportesEstudiantes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataEstudiantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrados;
        private DataGridView dataEstudiantes;
        private Button btnCrearReporte;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}