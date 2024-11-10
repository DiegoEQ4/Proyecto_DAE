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
            dataGrados = new DataGridView();
            dataEstudiantezs = new DataGridView();
            btnCrearReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataEstudiantezs).BeginInit();
            SuspendLayout();
            // 
            // dataGrados
            // 
            dataGrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrados.Location = new Point(33, 26);
            dataGrados.Name = "dataGrados";
            dataGrados.Size = new Size(281, 282);
            dataGrados.TabIndex = 0;
            // 
            // dataEstudiantezs
            // 
            dataEstudiantezs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEstudiantezs.Location = new Point(348, 26);
            dataEstudiantezs.Name = "dataEstudiantezs";
            dataEstudiantezs.Size = new Size(281, 282);
            dataEstudiantezs.TabIndex = 1;
            // 
            // btnCrearReporte
            // 
            btnCrearReporte.Location = new Point(244, 356);
            btnCrearReporte.Name = "btnCrearReporte";
            btnCrearReporte.Size = new Size(168, 50);
            btnCrearReporte.TabIndex = 2;
            btnCrearReporte.Text = "Crear Reporte";
            btnCrearReporte.UseVisualStyleBackColor = true;
            // 
            // ReportesEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 450);
            Controls.Add(btnCrearReporte);
            Controls.Add(dataEstudiantezs);
            Controls.Add(dataGrados);
            Name = "ReportesEstudiantes";
            Text = "Reportes de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)dataGrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataEstudiantezs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrados;
        private DataGridView dataEstudiantezs;
        private Button btnCrearReporte;
    }
}