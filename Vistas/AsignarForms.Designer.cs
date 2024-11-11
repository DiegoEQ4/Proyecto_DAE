namespace Proyecto_DAE.Vistas
{
    partial class AsignarForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarForms));
            dataGrados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbProfe = new ComboBox();
            txtGrado = new TextBox();
            dataDetalleMateria = new DataGridView();
            dataMateria = new DataGridView();
            txtMateria = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataDetalleMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGrados
            // 
            dataGrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrados.Location = new Point(94, 34);
            dataGrados.MultiSelect = false;
            dataGrados.Name = "dataGrados";
            dataGrados.ReadOnly = true;
            dataGrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrados.Size = new Size(344, 132);
            dataGrados.TabIndex = 0;
            dataGrados.SelectionChanged += dataGrados_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(779, 34);
            label1.Name = "label1";
            label1.Size = new Size(43, 14);
            label1.TabIndex = 2;
            label1.Text = "Grado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(779, 78);
            label2.Name = "label2";
            label2.Size = new Size(53, 14);
            label2.TabIndex = 4;
            label2.Text = "Materia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(779, 127);
            label3.Name = "label3";
            label3.Size = new Size(59, 14);
            label3.TabIndex = 6;
            label3.Text = "Profesor";
            // 
            // cmbProfe
            // 
            cmbProfe.FormattingEnabled = true;
            cmbProfe.Location = new Point(843, 124);
            cmbProfe.Name = "cmbProfe";
            cmbProfe.Size = new Size(121, 23);
            cmbProfe.TabIndex = 5;
            // 
            // txtGrado
            // 
            txtGrado.Enabled = false;
            txtGrado.Location = new Point(843, 34);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(121, 23);
            txtGrado.TabIndex = 7;
            // 
            // dataDetalleMateria
            // 
            dataDetalleMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDetalleMateria.Location = new Point(94, 194);
            dataDetalleMateria.MultiSelect = false;
            dataDetalleMateria.Name = "dataDetalleMateria";
            dataDetalleMateria.ReadOnly = true;
            dataDetalleMateria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataDetalleMateria.Size = new Size(659, 150);
            dataDetalleMateria.TabIndex = 8;
            dataDetalleMateria.CellContentClick += dataDetalleMateria_CellContentClick;
            dataDetalleMateria.SelectionChanged += dataDetalleMateria_SelectionChanged;
            // 
            // dataMateria
            // 
            dataMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMateria.Location = new Point(512, 30);
            dataMateria.MultiSelect = false;
            dataMateria.Name = "dataMateria";
            dataMateria.ReadOnly = true;
            dataMateria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataMateria.Size = new Size(241, 132);
            dataMateria.TabIndex = 9;
            dataMateria.SelectionChanged += dataMateria_SelectionChanged;
            // 
            // txtMateria
            // 
            txtMateria.Enabled = false;
            txtMateria.Location = new Point(843, 75);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(121, 23);
            txtMateria.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(812, 189);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 42);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Goldenrod;
            btnModificar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(812, 237);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(138, 42);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(812, 286);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(138, 42);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(203, 9);
            label4.Name = "label4";
            label4.Size = new Size(91, 16);
            label4.TabIndex = 15;
            label4.Text = "TABLA GRADO";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 9.75F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(587, 8);
            label5.Name = "label5";
            label5.Size = new Size(106, 16);
            label5.TabIndex = 16;
            label5.Text = "TABLA MATERIA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 9.75F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(365, 174);
            label6.Name = "label6";
            label6.Size = new Size(120, 16);
            label6.TabIndex = 17;
            label6.Text = "Detalle Materia";
            // 
            // AsignarForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1001, 364);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtMateria);
            Controls.Add(dataMateria);
            Controls.Add(dataDetalleMateria);
            Controls.Add(txtGrado);
            Controls.Add(label3);
            Controls.Add(cmbProfe);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGrados);
            Name = "AsignarForms";
            Text = "Asignar materias";
            Load += AsignarForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataDetalleMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrados;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbProfe;
        private TextBox txtGrado;
        private DataGridView dataDetalleMateria;
        private DataGridView dataMateria;
        private TextBox txtMateria;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}