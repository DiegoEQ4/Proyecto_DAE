namespace Proyecto_DAE.Vistas
{
    partial class ProfesorForms
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dateFechaNacimiento = new DateTimePicker();
            txtTelefono = new TextBox();
            txtCorreoProfe = new TextBox();
            txtTitulo = new TextBox();
            txtApellidoProfe = new TextBox();
            txtNombreProfe = new TextBox();
            txtCarnetProfe = new TextBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(503, 387);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 57);
            btnEliminar.TabIndex = 37;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(290, 385);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(133, 58);
            btnModificar.TabIndex = 36;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(83, 385);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 58);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Location = new Point(257, 275);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(400, 31);
            dateFechaNacimiento.TabIndex = 33;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(484, 203);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(173, 31);
            txtTelefono.TabIndex = 32;
            // 
            // txtCorreoProfe
            // 
            txtCorreoProfe.Location = new Point(404, 147);
            txtCorreoProfe.Name = "txtCorreoProfe";
            txtCorreoProfe.Size = new Size(253, 31);
            txtCorreoProfe.TabIndex = 31;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(404, 88);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(253, 31);
            txtTitulo.TabIndex = 30;
            // 
            // txtApellidoProfe
            // 
            txtApellidoProfe.Location = new Point(147, 208);
            txtApellidoProfe.Name = "txtApellidoProfe";
            txtApellidoProfe.Size = new Size(165, 31);
            txtApellidoProfe.TabIndex = 29;
            // 
            // txtNombreProfe
            // 
            txtNombreProfe.Location = new Point(147, 147);
            txtNombreProfe.Name = "txtNombreProfe";
            txtNombreProfe.Size = new Size(165, 31);
            txtNombreProfe.TabIndex = 28;
            // 
            // txtCarnetProfe
            // 
            txtCarnetProfe.Location = new Point(147, 90);
            txtCarnetProfe.Name = "txtCarnetProfe";
            txtCarnetProfe.Size = new Size(165, 31);
            txtCarnetProfe.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(706, 57);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(421, 417);
            dataGridView1.TabIndex = 26;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 275);
            label7.Name = "label7";
            label7.Size = new Size(178, 25);
            label7.TabIndex = 25;
            label7.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 208);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 24;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 103);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 23;
            label5.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 45);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 22;
            label4.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 212);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 21;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 20;
            label2.Text = "Carnet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 147);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 19;
            label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(40, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 288);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion del docente";
            // 
            // ProfesorForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 557);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dateFechaNacimiento);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreoProfe);
            Controls.Add(txtTitulo);
            Controls.Add(txtApellidoProfe);
            Controls.Add(txtNombreProfe);
            Controls.Add(txtCarnetProfe);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProfesorForms";
            Text = "Gestion de Profesores";
            Load += ProfesorForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DateTimePicker dateFechaNacimiento;
        private TextBox txtTelefono;
        private TextBox txtCorreoProfe;
        private TextBox txtTitulo;
        private TextBox txtApellidoProfe;
        private TextBox txtNombreProfe;
        private TextBox txtCarnetProfe;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
    }
}