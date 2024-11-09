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
            btnEliminar.Location = new Point(352, 232);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 34);
            btnEliminar.TabIndex = 37;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(203, 231);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(93, 35);
            btnModificar.TabIndex = 36;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(58, 231);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 35);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Location = new Point(180, 165);
            dateFechaNacimiento.Margin = new Padding(2);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(281, 23);
            dateFechaNacimiento.TabIndex = 33;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(339, 122);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(122, 23);
            txtTelefono.TabIndex = 32;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtCorreoProfe
            // 
            txtCorreoProfe.Location = new Point(283, 88);
            txtCorreoProfe.Margin = new Padding(2);
            txtCorreoProfe.Name = "txtCorreoProfe";
            txtCorreoProfe.Size = new Size(178, 23);
            txtCorreoProfe.TabIndex = 31;
            txtCorreoProfe.TextChanged += txtCorreoProfe_TextChanged;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(283, 53);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(178, 23);
            txtTitulo.TabIndex = 30;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // txtApellidoProfe
            // 
            txtApellidoProfe.Location = new Point(103, 125);
            txtApellidoProfe.Margin = new Padding(2);
            txtApellidoProfe.Name = "txtApellidoProfe";
            txtApellidoProfe.Size = new Size(117, 23);
            txtApellidoProfe.TabIndex = 29;
            txtApellidoProfe.TextChanged += txtApellidoProfe_TextChanged;
            // 
            // txtNombreProfe
            // 
            txtNombreProfe.Location = new Point(103, 88);
            txtNombreProfe.Margin = new Padding(2);
            txtNombreProfe.Name = "txtNombreProfe";
            txtNombreProfe.Size = new Size(117, 23);
            txtNombreProfe.TabIndex = 28;
            txtNombreProfe.TextChanged += txtNombreProfe_TextChanged;
            // 
            // txtCarnetProfe
            // 
            txtCarnetProfe.Location = new Point(103, 54);
            txtCarnetProfe.Margin = new Padding(2);
            txtCarnetProfe.Name = "txtCarnetProfe";
            txtCarnetProfe.Size = new Size(117, 23);
            txtCarnetProfe.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(494, 34);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(295, 250);
            dataGridView1.TabIndex = 26;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 165);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 25;
            label7.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 125);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 24;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 62);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 23;
            label5.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 27);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 22;
            label4.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 21;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 53);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 20;
            label2.Text = "Carnet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 88);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 19;
            label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(28, 26);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(450, 173);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion del docente";
            // 
            // ProfesorForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 334);
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