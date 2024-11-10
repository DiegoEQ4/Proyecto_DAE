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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(596, 118);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(133, 30);
            btnReporte.TabIndex = 5;
            btnReporte.Text = "Crear Reporte";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // button1
            // 
            button1.Location = new Point(28, 68);
            button1.Name = "button1";
            button1.Size = new Size(133, 30);
            button1.TabIndex = 6;
            button1.Text = "Consultar por Fecha";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(28, 148);
            button2.Name = "button2";
            button2.Size = new Size(133, 30);
            button2.TabIndex = 7;
            button2.Text = "Consultar por Grado";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(28, 216);
            button3.Name = "button3";
            button3.Size = new Size(133, 30);
            button3.TabIndex = 8;
            button3.Text = "Consultar por Clase";
            button3.UseVisualStyleBackColor = true;
            // 
            // ReporteAsistenciaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnReporte);
            Name = "ReporteAsistenciaForms";
            Text = "Reportes de Asistencia";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReporte;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}