namespace Proyecto_DAE.Vistas
{
    partial class ClaseForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaseForms));
            dataGridView1 = new DataGridView();
            txtID = new TextBox();
            label1 = new Label();
            cmbMateria = new ComboBox();
            txtContent = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            button4 = new Button();
            label4 = new Label();
            txtDuracion = new NumericUpDown();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 42);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(348, 284);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(462, 42);
            txtID.Name = "txtID";
            txtID.Size = new Size(80, 23);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(427, 42);
            label1.Name = "label1";
            label1.Size = new Size(21, 14);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(462, 126);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(169, 23);
            cmbMateria.TabIndex = 3;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(462, 84);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(187, 23);
            txtContent.TabIndex = 4;
            txtContent.TextChanged += txtContent_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(391, 87);
            label2.Name = "label2";
            label2.Size = new Size(71, 14);
            label2.TabIndex = 5;
            label2.Text = "Contenido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(407, 134);
            label3.Name = "label3";
            label3.Size = new Size(53, 14);
            label3.TabIndex = 6;
            label3.Text = "Materia";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Goldenrod;
            btnAgregar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(391, 212);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 47);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(503, 212);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(89, 47);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(612, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 47);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.YellowGreen;
            button4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(441, 279);
            button4.Name = "button4";
            button4.Size = new Size(208, 47);
            button4.TabIndex = 10;
            button4.Text = "Crear Asistencia";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(399, 170);
            label4.Name = "label4";
            label4.Size = new Size(61, 14);
            label4.TabIndex = 11;
            label4.Text = "Duracion";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(462, 168);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(120, 23);
            txtDuracion.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(588, 170);
            label5.Name = "label5";
            label5.Size = new Size(42, 14);
            label5.TabIndex = 13;
            label5.Text = "Horas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(612, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // ClaseForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(713, 380);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(txtDuracion);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtContent);
            Controls.Add(cmbMateria);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Name = "ClaseForms";
            Text = "Gestion de clases";
            Load += ClaseForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtID;
        private Label label1;
        private ComboBox cmbMateria;
        private TextBox txtContent;
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button button4;
        private Label label4;
        private NumericUpDown txtDuracion;
        private Label label5;
        private PictureBox pictureBox1;
    }
}