namespace Proyecto_DAE.Vistas
{
    partial class EstudianteForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudianteForms));
            label1 = new Label();
            txtCarnet = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateNacimiento = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnEditar = new Button();
            cmbGrado = new ComboBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 59);
            label1.Name = "label1";
            label1.Size = new Size(48, 14);
            label1.TabIndex = 0;
            label1.Text = "Carnet";
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(113, 51);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(75, 23);
            txtCarnet.TabIndex = 1;
            txtCarnet.TextChanged += txtCarnet_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(318, 99);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(318, 48);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(203, 23);
            txtCorreo.TabIndex = 4;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 14);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(261, 102);
            label3.Name = "label3";
            label3.Size = new Size(56, 14);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(269, 51);
            label4.Name = "label4";
            label4.Size = new Size(48, 14);
            label4.TabIndex = 7;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 155);
            label5.Name = "label5";
            label5.Size = new Size(131, 14);
            label5.TabIndex = 8;
            label5.Text = "Fecha de Nacimiento";
            // 
            // dateNacimiento
            // 
            dateNacimiento.Location = new Point(180, 149);
            dateNacimiento.Name = "dateNacimiento";
            dateNacimiento.Size = new Size(220, 23);
            dateNacimiento.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 187);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(523, 166);
            dataGridView1.TabIndex = 10;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(601, 194);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 43);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(601, 292);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(111, 43);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.RoyalBlue;
            btnEditar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(601, 243);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 43);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button3_Click;
            // 
            // cmbGrado
            // 
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(508, 99);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(121, 23);
            cmbGrado.TabIndex = 14;
            cmbGrado.SelectedIndexChanged += cmbGrado_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(463, 102);
            label6.Name = "label6";
            label6.Size = new Size(43, 14);
            label6.TabIndex = 15;
            label6.Text = "Grado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(635, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(255, 9);
            label7.Name = "label7";
            label7.Size = new Size(185, 18);
            label7.TabIndex = 17;
            label7.Text = "GESTIÓN DE ESTUDIANTE";
            // 
            // EstudianteForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(742, 389);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(cmbGrado);
            Controls.Add(btnEditar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(dateNacimiento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtCarnet);
            Controls.Add(label1);
            Name = "EstudianteForms";
            Text = "Gestion de estudiantes";
            Load += EstudianteForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCarnet;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateNacimiento;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnEditar;
        private ComboBox cmbGrado;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
    }
}