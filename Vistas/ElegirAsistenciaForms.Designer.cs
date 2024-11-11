namespace Proyecto_DAE.Vistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirAsistenciaForms));
            dataGrados = new DataGridView();
            dataAsistencia = new DataGridView();
            btnVer = new Button();
            btnBorrar = new Button();
            btnCrear = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataAsistencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnVer.BackColor = Color.Goldenrod;
            btnVer.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVer.Location = new Point(765, 106);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(101, 37);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver Asistencia";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnBorrar.Location = new Point(765, 205);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(101, 50);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar Asistencia";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.YellowGreen;
            btnCrear.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            btnCrear.Location = new Point(765, 149);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(101, 50);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear Asistencia";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(766, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ElegirAsistenciaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(878, 346);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrados;
        private DataGridView dataAsistencia;
        private Button btnVer;
        private Button btnBorrar;
        private Button btnCrear;
        private PictureBox pictureBox1;
    }
}