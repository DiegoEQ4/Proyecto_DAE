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
            ((System.ComponentModel.ISupportInitialize)dataGrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataDetalleMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataMateria).BeginInit();
            SuspendLayout();
            // 
            // dataGrados
            // 
            dataGrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrados.Location = new Point(63, 30);
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
            label1.Location = new Point(779, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Grado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(779, 78);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Materia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(779, 127);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
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
            txtGrado.Location = new Point(843, 34);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(121, 23);
            txtGrado.TabIndex = 7;
            // 
            // dataDetalleMateria
            // 
            dataDetalleMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDetalleMateria.Location = new Point(63, 182);
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
            dataMateria.Location = new Point(481, 30);
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
            txtMateria.Location = new Point(843, 75);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(121, 23);
            txtMateria.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(796, 189);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 42);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(796, 237);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(138, 42);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(796, 286);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(138, 42);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // AsignarForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 364);
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
    }
}