namespace Proyecto_DAE.Vistas
{
    partial class GradoForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradoForms));
            groupBox1 = new GroupBox();
            txtSeccionGrado = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            txtAnio = new TextBox();
            txtCupos = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            txtNombreGrado = new TextBox();
            label1 = new Label();
            txtIdGrado = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCupos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSeccionGrado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAnio);
            groupBox1.Controls.Add(txtCupos);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreGrado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtIdGrado);
            groupBox1.Location = new Point(30, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de Grado";
            // 
            // txtSeccionGrado
            // 
            txtSeccionGrado.FormattingEnabled = true;
            txtSeccionGrado.Items.AddRange(new object[] { "A", "B", "C" });
            txtSeccionGrado.Location = new Point(66, 104);
            txtSeccionGrado.Name = "txtSeccionGrado";
            txtSeccionGrado.Size = new Size(121, 23);
            txtSeccionGrado.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 24);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 13;
            label7.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Cupos";
            label4.Click += label4_Click;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(211, 21);
            txtAnio.MaxLength = 4;
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(80, 23);
            txtAnio.TabIndex = 12;
            txtAnio.TextChanged += txtAnio_TextChanged;
            // 
            // txtCupos
            // 
            txtCupos.Location = new Point(66, 145);
            txtCupos.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            txtCupos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtCupos.Name = "txtCupos";
            txtCupos.Size = new Size(53, 23);
            txtCupos.TabIndex = 6;
            txtCupos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Seccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Grado";
            // 
            // txtNombreGrado
            // 
            txtNombreGrado.Location = new Point(66, 68);
            txtNombreGrado.Name = "txtNombreGrado";
            txtNombreGrado.Size = new Size(100, 23);
            txtNombreGrado.TabIndex = 2;
            txtNombreGrado.TextChanged += txtNombreGrado_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 29);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // txtIdGrado
            // 
            txtIdGrado.Enabled = false;
            txtIdGrado.Location = new Point(66, 29);
            txtIdGrado.Name = "txtIdGrado";
            txtIdGrado.Size = new Size(53, 23);
            txtIdGrado.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(367, 83);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(386, 171);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(292, 31);
            label5.Name = "label5";
            label5.Size = new Size(193, 22);
            label5.TabIndex = 8;
            label5.Text = "Gestion de grados";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(39, 271);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(77, 32);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SteelBlue;
            btnModificar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(142, 271);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(77, 32);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(244, 271);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(77, 32);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(678, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // GradoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(778, 321);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            ForeColor = Color.White;
            Name = "GradoForms";
            Text = "Gestion de Grados";
            Load += GradoForms_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCupos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtIdGrado;
        private Label label4;
        private NumericUpDown txtCupos;
        private Label label3;
        private Label label2;
        private TextBox txtNombreGrado;
        private DataGridView dataGridView1;
        private Label label5;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Label label7;
        private TextBox txtAnio;
        private ComboBox txtSeccionGrado;
        private PictureBox pictureBox1;
    }
}