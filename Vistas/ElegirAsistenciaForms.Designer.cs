﻿namespace Proyecto_DAE.Vistas
{
    partial class ElegirAsistenciaForms
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
            dataAsistencia = new DataGridView();
            btnVer = new Button();
            btnBorrar = new Button();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataAsistencia).BeginInit();
            SuspendLayout();
            // 
            // dataGrados
            // 
            dataGrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrados.Location = new Point(19, 34);
            dataGrados.MultiSelect = false;
            dataGrados.Name = "dataGrados";
            dataGrados.ReadOnly = true;
            dataGrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrados.Size = new Size(379, 291);
            dataGrados.TabIndex = 0;
            dataGrados.SelectionChanged += dataGrados_SelectionChanged;
            // 
            // dataAsistencia
            // 
            dataAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAsistencia.Location = new Point(417, 36);
            dataAsistencia.MultiSelect = false;
            dataAsistencia.Name = "dataAsistencia";
            dataAsistencia.ReadOnly = true;
            dataAsistencia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataAsistencia.Size = new Size(342, 291);
            dataAsistencia.TabIndex = 1;
            dataAsistencia.SelectionChanged += dataAsistencia_SelectionChanged;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(765, 36);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(101, 37);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver Asistencia";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(765, 132);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(101, 56);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar Asistencia";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(765, 79);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(101, 37);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear Asistencia";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // ElegirAsistenciaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 346);
            Controls.Add(btnCrear);
            Controls.Add(btnBorrar);
            Controls.Add(btnVer);
            Controls.Add(dataAsistencia);
            Controls.Add(dataGrados);
            Name = "ElegirAsistenciaForms";
            Text = "Elegir Asistencia";
            Load += ElegirAsistenciaForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataAsistencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrados;
        private DataGridView dataAsistencia;
        private Button btnVer;
        private Button btnBorrar;
        private Button btnCrear;
    }
}