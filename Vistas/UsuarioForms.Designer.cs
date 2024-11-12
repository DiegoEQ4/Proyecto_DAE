namespace Proyecto_DAE.Vistas
{
    partial class UsuarioForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForms));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtID = new TextBox();
            cmbTipo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtContrasena = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 55);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(352, 234);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(487, 92);
            label1.Name = "label1";
            label1.Size = new Size(21, 14);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(522, 84);
            txtID.Name = "txtID";
            txtID.Size = new Size(49, 23);
            txtID.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "1", "2" });
            cmbTipo.Location = new Point(522, 212);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(100, 23);
            cmbTipo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(411, 131);
            label2.Name = "label2";
            label2.Size = new Size(103, 14);
            label2.TabIndex = 4;
            label2.Text = "Nombre Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(438, 172);
            label3.Name = "label3";
            label3.Size = new Size(77, 14);
            label3.TabIndex = 5;
            label3.Text = "Contrasena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(475, 220);
            label4.Name = "label4";
            label4.Size = new Size(33, 14);
            label4.TabIndex = 6;
            label4.Text = "Tipo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(522, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(522, 172);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(654, 77);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 45);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SteelBlue;
            btnModificar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(654, 142);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 45);
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
            btnBorrar.Location = new Point(654, 200);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 45);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // UsuarioForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(760, 299);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbTipo);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UsuarioForms";
            Text = "Gestion de usuarios";
            Load += UsuarioForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtID;
        private ComboBox cmbTipo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtContrasena;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private PictureBox pictureBox1;
    }
}