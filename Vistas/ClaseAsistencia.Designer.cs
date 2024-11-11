namespace Proyecto_DAE.Vistas
{
    partial class ClaseAsistencia
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
            fechaInicio = new DateTimePicker();
            fechaFinal = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtClase = new TextBox();
            label4 = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            txtContenido = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // fechaInicio
            // 
            fechaInicio.Format = DateTimePickerFormat.Custom;
            fechaInicio.Location = new Point(123, 71);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(185, 23);
            fechaInicio.TabIndex = 0;
            // 
            // fechaFinal
            // 
            fechaFinal.Format = DateTimePickerFormat.Custom;
            fechaFinal.Location = new Point(324, 71);
            fechaFinal.Name = "fechaFinal";
            fechaFinal.Size = new Size(185, 23);
            fechaFinal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 77);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "Horario Clase";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 53);
            label2.Name = "label2";
            label2.Size = new Size(87, 14);
            label2.TabIndex = 3;
            label2.Text = "HORA INICIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(448, 53);
            label3.Name = "label3";
            label3.Size = new Size(66, 14);
            label3.TabIndex = 4;
            label3.Text = "HORA FIN";
            // 
            // txtClase
            // 
            txtClase.Enabled = false;
            txtClase.Location = new Point(123, 142);
            txtClase.Name = "txtClase";
            txtClase.Size = new Size(194, 23);
            txtClase.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 124);
            label4.Name = "label4";
            label4.Size = new Size(51, 14);
            label4.TabIndex = 6;
            label4.Text = "GRADO";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Lime;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(306, 197);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(93, 35);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(416, 197);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 35);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(105, 9);
            label5.Name = "label5";
            label5.Size = new Size(304, 20);
            label5.TabIndex = 9;
            label5.Text = "CONFIRMA LA CREACION DE ASISTENCIA";
            // 
            // txtContenido
            // 
            txtContenido.Enabled = false;
            txtContenido.Location = new Point(324, 142);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(185, 23);
            txtContenido.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(324, 124);
            label6.Name = "label6";
            label6.Size = new Size(77, 14);
            label6.TabIndex = 11;
            label6.Text = "CONTENIDO";
            // 
            // ClaseAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(521, 244);
            Controls.Add(label6);
            Controls.Add(txtContenido);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(label4);
            Controls.Add(txtClase);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fechaFinal);
            Controls.Add(fechaInicio);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ClaseAsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Asistencia";
            Load += ClaseAsistencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fechaInicio;
        private DateTimePicker fechaFinal;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtClase;
        private Label label4;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label label5;
        private TextBox txtContenido;
        private Label label6;
    }
}