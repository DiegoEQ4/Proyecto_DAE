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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 28);
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
            label1.Location = new Point(487, 65);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(522, 57);
            txtID.Name = "txtID";
            txtID.Size = new Size(49, 23);
            txtID.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "1", "2" });
            cmbTipo.Location = new Point(522, 185);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(100, 23);
            cmbTipo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 104);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 145);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Contrasena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 193);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "Tipo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(522, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(522, 145);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(654, 50);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 45);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(654, 115);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 45);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(654, 173);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 45);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // UsuarioForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 299);
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
            Text = "UsuarioForms";
            Load += UsuarioForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}