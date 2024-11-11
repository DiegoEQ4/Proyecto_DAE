﻿namespace Proyecto_DAE.Vistas
{
    partial class MateriaForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaForms));
            btnBorrar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtDuracion = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            txtNombreMateria = new TextBox();
            label1 = new Label();
            txtIdMateria = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnBorrar.Location = new Point(244, 253);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(77, 32);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SteelBlue;
            btnModificar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnModificar.Location = new Point(139, 253);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(77, 32);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnAgregar.Location = new Point(39, 253);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(77, 32);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SandyBrown;
            label5.Location = new Point(307, 9);
            label5.Name = "label5";
            label5.Size = new Size(188, 25);
            label5.TabIndex = 18;
            label5.Text = "Gestion de Materias";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(359, 44);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(448, 260);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDuracion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreMateria);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtIdMateria);
            groupBox1.Location = new Point(30, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 192);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de Materia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(262, 53);
            label6.Name = "label6";
            label6.Size = new Size(32, 14);
            label6.TabIndex = 9;
            label6.Text = "Dias";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(82, 96);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(147, 50);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 96);
            label4.Name = "label4";
            label4.Size = new Size(76, 14);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(238, 27);
            txtDuracion.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            txtDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(53, 23);
            txtDuracion.TabIndex = 6;
            txtDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(174, 26);
            label3.Name = "label3";
            label3.Size = new Size(61, 14);
            label3.TabIndex = 5;
            label3.Text = "Duracion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 14);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(82, 56);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(111, 23);
            txtNombreMateria.TabIndex = 2;
            txtNombreMateria.TextChanged += txtNombreMateria_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 27);
            label1.Name = "label1";
            label1.Size = new Size(21, 14);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtIdMateria
            // 
            txtIdMateria.Enabled = false;
            txtIdMateria.Location = new Point(82, 22);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.Size = new Size(53, 23);
            txtIdMateria.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // MateriaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(819, 316);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "MateriaForms";
            Text = "Gestion de Materias";
            Load += MateriaForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBorrar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label5;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private NumericUpDown txtDuracion;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIdMateria;
        private TextBox txtDescripcion;
        private TextBox txtNombreMateria;
        private Label label6;
        private PictureBox pictureBox1;
    }
}