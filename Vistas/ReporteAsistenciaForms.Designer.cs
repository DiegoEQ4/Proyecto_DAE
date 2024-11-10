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
            SuspendLayout();
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(543, 141);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(155, 56);
            btnReporte.TabIndex = 5;
            btnReporte.Text = "Crear Reporte";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Visible = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnFecha
            // 
            btnFecha.Location = new Point(28, 68);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(133, 30);
            btnFecha.TabIndex = 6;
            btnFecha.Text = "Consultar por Fecha";
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFecha_Click;
            // 
            // btnGrado
            // 
            btnGrado.Location = new Point(28, 148);
            btnGrado.Name = "btnGrado";
            btnGrado.Size = new Size(133, 30);
            btnGrado.TabIndex = 7;
            btnGrado.Text = "Consultar por Grado";
            btnGrado.UseVisualStyleBackColor = true;
            btnGrado.Click += btnGrado_Click;
            // 
            // btnClase
            // 
            btnClase.Location = new Point(28, 216);
            btnClase.Name = "btnClase";
            btnClase.Size = new Size(133, 30);
            btnClase.TabIndex = 8;
            btnClase.Text = "Consultar por Clase";
            btnClase.UseVisualStyleBackColor = true;
            btnClase.Click += btnClase_Click;
            // 
            // dateInicio
            // 
            dateInicio.Format = DateTimePickerFormat.Short;
            dateInicio.Location = new Point(185, 70);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(111, 23);
            dateInicio.TabIndex = 9;
            dateInicio.Visible = false;
            // 
            // dateFinal
            // 
            dateFinal.Format = DateTimePickerFormat.Short;
            dateFinal.Location = new Point(327, 70);
            dateFinal.Name = "dateFinal";
            dateFinal.Size = new Size(111, 23);
            dateFinal.TabIndex = 10;
            dateFinal.Visible = false;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(258, 41);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(36, 15);
            lblInicio.TabIndex = 11;
            lblInicio.Text = "Inicio";
            lblInicio.Visible = false;
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(402, 41);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(32, 15);
            lblFinal.TabIndex = 12;
            lblFinal.Text = "Final";
            lblFinal.Visible = false;
            // 
            // cmbGradoFecha
            // 
            cmbGradoFecha.FormattingEnabled = true;
            cmbGradoFecha.Location = new Point(479, 68);
            cmbGradoFecha.Name = "cmbGradoFecha";
            cmbGradoFecha.Size = new Size(99, 23);
            cmbGradoFecha.TabIndex = 13;
            cmbGradoFecha.Visible = false;
            // 
            // lblFechaGrado
            // 
            lblFechaGrado.AutoSize = true;
            lblFechaGrado.Location = new Point(539, 41);
            lblFechaGrado.Name = "lblFechaGrado";
            lblFechaGrado.Size = new Size(39, 15);
            lblFechaGrado.TabIndex = 14;
            lblFechaGrado.Text = "Grado";
            lblFechaGrado.Visible = false;
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.Location = new Point(267, 126);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(39, 15);
            lblGrado.TabIndex = 16;
            lblGrado.Text = "Grado";
            lblGrado.Visible = false;
            // 
            // cmbGrado
            // 
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(185, 153);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(121, 23);
            cmbGrado.TabIndex = 15;
            cmbGrado.Visible = false;
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Location = new Point(267, 196);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(35, 15);
            lblClase.TabIndex = 18;
            lblClase.Text = "Clase";
            lblClase.Visible = false;
            // 
            // cmbClase
            // 
            cmbClase.FormattingEnabled = true;
            cmbClase.Location = new Point(185, 223);
            cmbClase.Name = "cmbClase";
            cmbClase.Size = new Size(121, 23);
            cmbClase.TabIndex = 17;
            cmbClase.Visible = false;
            // 
            // ReporteAsistenciaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 322);
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
    }
}