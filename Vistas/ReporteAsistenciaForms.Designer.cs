namespace Proyecto_DAE.Vistas
{
    partial class ReporteAsistenciaForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteAsistenciaForms));
            btnReporte = new Button();
            btnFecha = new Button();
            btnGrado = new Button();
            btnClase = new Button();
            dateInicio = new DateTimePicker();
            dateFinal = new DateTimePicker();
            lblInicio = new Label();
            lblFinal = new Label();
            cmbGradoFecha = new ComboBox();
            lblFechaGrado = new Label();
            lblGrado = new Label();
            cmbGrado = new ComboBox();
            lblClase = new Label();
            cmbClase = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.YellowGreen;
            btnReporte.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporte.ForeColor = Color.White;
            btnReporte.Location = new Point(543, 196);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(155, 56);
            btnReporte.TabIndex = 5;
            btnReporte.Text = "Crear Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Visible = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnFecha
            // 
            btnFecha.BackColor = Color.DarkOrange;
            btnFecha.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFecha.ForeColor = Color.White;
            btnFecha.Location = new Point(28, 71);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(133, 48);
            btnFecha.TabIndex = 6;
            btnFecha.Text = "Consultar por Fecha";
            btnFecha.UseVisualStyleBackColor = false;
            btnFecha.Click += btnFecha_Click;
            // 
            // btnGrado
            // 
            btnGrado.BackColor = Color.DarkOrange;
            btnGrado.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnGrado.ForeColor = Color.White;
            btnGrado.Location = new Point(28, 144);
            btnGrado.Name = "btnGrado";
            btnGrado.Size = new Size(133, 49);
            btnGrado.TabIndex = 7;
            btnGrado.Text = "Consultar por Grado";
            btnGrado.UseVisualStyleBackColor = false;
            btnGrado.Click += btnGrado_Click;
            // 
            // btnClase
            // 
            btnClase.BackColor = Color.DarkOrange;
            btnClase.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnClase.ForeColor = Color.White;
            btnClase.Location = new Point(28, 216);
            btnClase.Name = "btnClase";
            btnClase.Size = new Size(133, 45);
            btnClase.TabIndex = 8;
            btnClase.Text = "Consultar por Clase";
            btnClase.UseVisualStyleBackColor = false;
            btnClase.Click += btnClase_Click;
            // 
            // dateInicio
            // 
            dateInicio.Format = DateTimePickerFormat.Short;
            dateInicio.Location = new Point(185, 82);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(111, 23);
            dateInicio.TabIndex = 9;
            dateInicio.Visible = false;
            // 
            // dateFinal
            // 
            dateFinal.Format = DateTimePickerFormat.Short;
            dateFinal.Location = new Point(327, 82);
            dateFinal.Name = "dateFinal";
            dateFinal.Size = new Size(111, 23);
            dateFinal.TabIndex = 10;
            dateFinal.Visible = false;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicio.ForeColor = Color.White;
            lblInicio.Location = new Point(258, 53);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(40, 14);
            lblInicio.TabIndex = 11;
            lblInicio.Text = "Inicio";
            lblInicio.Visible = false;
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblFinal.ForeColor = Color.White;
            lblFinal.Location = new Point(402, 53);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(34, 14);
            lblFinal.TabIndex = 12;
            lblFinal.Text = "Final";
            lblFinal.Visible = false;
            // 
            // cmbGradoFecha
            // 
            cmbGradoFecha.FormattingEnabled = true;
            cmbGradoFecha.Location = new Point(479, 80);
            cmbGradoFecha.Name = "cmbGradoFecha";
            cmbGradoFecha.Size = new Size(99, 23);
            cmbGradoFecha.TabIndex = 13;
            cmbGradoFecha.Visible = false;
            // 
            // lblFechaGrado
            // 
            lblFechaGrado.AutoSize = true;
            lblFechaGrado.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblFechaGrado.ForeColor = Color.White;
            lblFechaGrado.Location = new Point(539, 53);
            lblFechaGrado.Name = "lblFechaGrado";
            lblFechaGrado.Size = new Size(43, 14);
            lblFechaGrado.TabIndex = 14;
            lblFechaGrado.Text = "Grado";
            lblFechaGrado.Visible = false;
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblGrado.ForeColor = Color.White;
            lblGrado.Location = new Point(267, 138);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(43, 14);
            lblGrado.TabIndex = 16;
            lblGrado.Text = "Grado";
            lblGrado.Visible = false;
            // 
            // cmbGrado
            // 
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(185, 165);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(121, 23);
            cmbGrado.TabIndex = 15;
            cmbGrado.Visible = false;
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblClase.ForeColor = Color.White;
            lblClase.Location = new Point(267, 208);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(38, 14);
            lblClase.TabIndex = 18;
            lblClase.Text = "Clase";
            lblClase.Visible = false;
            // 
            // cmbClase
            // 
            cmbClase.FormattingEnabled = true;
            cmbClase.Location = new Point(185, 235);
            cmbClase.Name = "cmbClase";
            cmbClase.Size = new Size(121, 23);
            cmbClase.TabIndex = 17;
            cmbClase.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(614, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 19);
            label1.TabIndex = 20;
            label1.Text = "REPORTE DE ASISTENCIA";
            label1.Click += label1_Click;
            // 
            // ReporteAsistenciaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(725, 322);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblClase);
            Controls.Add(cmbClase);
            Controls.Add(lblGrado);
            Controls.Add(cmbGrado);
            Controls.Add(lblFechaGrado);
            Controls.Add(cmbGradoFecha);
            Controls.Add(lblFinal);
            Controls.Add(lblInicio);
            Controls.Add(dateFinal);
            Controls.Add(dateInicio);
            Controls.Add(btnClase);
            Controls.Add(btnGrado);
            Controls.Add(btnFecha);
            Controls.Add(btnReporte);
            Name = "ReporteAsistenciaForms";
            Text = "Reportes de Asistencia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReporte;
        private Button btnFecha;
        private Button btnGrado;
        private Button btnClase;
        private DateTimePicker dateInicio;
        private DateTimePicker dateFinal;
        private Label lblInicio;
        private Label lblFinal;
        private ComboBox cmbGradoFecha;
        private Label lblFechaGrado;
        private Label lblGrado;
        private ComboBox cmbGrado;
        private Label lblClase;
        private ComboBox cmbClase;
        private PictureBox pictureBox1;
        private Label label1;
    }
}