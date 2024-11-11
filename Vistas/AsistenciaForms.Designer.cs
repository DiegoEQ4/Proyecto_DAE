namespace Proyecto_DAE.Vistas
{
    partial class AsistenciaForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistenciaForms));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtCarnet = new TextBox();
            btnPresente = new Button();
            btnPermiso = new Button();
            btnAusente = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            btnAllPresente = new Button();
            btnAllAusente = new Button();
            btnAllPermisos = new Button();
            txtEstado = new TextBox();
            label3 = new Label();
            txtObservacion = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 92);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(532, 439);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(580, 13);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Carnet";
            // 
            // txtCarnet
            // 
            txtCarnet.Enabled = false;
            txtCarnet.Location = new Point(580, 41);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(73, 23);
            txtCarnet.TabIndex = 2;
            // 
            // btnPresente
            // 
            btnPresente.BackColor = Color.FromArgb(255, 128, 0);
            btnPresente.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPresente.Location = new Point(613, 226);
            btnPresente.Name = "btnPresente";
            btnPresente.Size = new Size(171, 38);
            btnPresente.TabIndex = 3;
            btnPresente.Text = "Presente";
            btnPresente.UseVisualStyleBackColor = false;
            btnPresente.Click += btnPresente_Click;
            // 
            // btnPermiso
            // 
            btnPermiso.BackColor = Color.FromArgb(255, 128, 0);
            btnPermiso.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPermiso.Location = new Point(613, 270);
            btnPermiso.Name = "btnPermiso";
            btnPermiso.Size = new Size(171, 38);
            btnPermiso.TabIndex = 4;
            btnPermiso.Text = "Permiso";
            btnPermiso.UseVisualStyleBackColor = false;
            btnPermiso.Click += btnPermiso_Click;
            // 
            // btnAusente
            // 
            btnAusente.BackColor = Color.FromArgb(255, 128, 0);
            btnAusente.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAusente.Location = new Point(613, 314);
            btnAusente.Name = "btnAusente";
            btnAusente.Size = new Size(171, 38);
            btnAusente.TabIndex = 5;
            btnAusente.Text = "Ausente";
            btnAusente.UseVisualStyleBackColor = false;
            btnAusente.Click += btnAusente_Click;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(580, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(580, 74);
            label2.Name = "label2";
            label2.Size = new Size(124, 14);
            label2.TabIndex = 6;
            label2.Text = "Nombre Estudiante";
            // 
            // btnAllPresente
            // 
            btnAllPresente.BackColor = Color.FromArgb(255, 128, 0);
            btnAllPresente.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnAllPresente.Location = new Point(613, 374);
            btnAllPresente.Name = "btnAllPresente";
            btnAllPresente.Size = new Size(171, 48);
            btnAllPresente.TabIndex = 8;
            btnAllPresente.Text = "Todos Presente";
            btnAllPresente.UseVisualStyleBackColor = false;
            btnAllPresente.Click += btnAllPresente_Click;
            // 
            // btnAllAusente
            // 
            btnAllAusente.BackColor = Color.FromArgb(255, 128, 0);
            btnAllAusente.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnAllAusente.Location = new Point(613, 483);
            btnAllAusente.Name = "btnAllAusente";
            btnAllAusente.Size = new Size(171, 48);
            btnAllAusente.TabIndex = 9;
            btnAllAusente.Text = "Todos Ausentes";
            btnAllAusente.UseVisualStyleBackColor = false;
            btnAllAusente.Click += btnAllAusente_Click;
            // 
            // btnAllPermisos
            // 
            btnAllPermisos.BackColor = Color.FromArgb(255, 128, 0);
            btnAllPermisos.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnAllPermisos.Location = new Point(613, 428);
            btnAllPermisos.Name = "btnAllPermisos";
            btnAllPermisos.Size = new Size(171, 48);
            btnAllPermisos.TabIndex = 10;
            btnAllPermisos.Text = "Todos Permisos";
            btnAllPermisos.UseVisualStyleBackColor = false;
            btnAllPermisos.Click += btnAllPermisos_Click;
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(717, 140);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(83, 23);
            txtEstado.TabIndex = 12;
            txtEstado.TextChanged += txtEstado_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(717, 122);
            label3.Name = "label3";
            label3.Size = new Size(49, 14);
            label3.TabIndex = 11;
            label3.Text = "Estado";
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(580, 140);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(109, 66);
            txtObservacion.TabIndex = 14;
            txtObservacion.TextChanged += txtObservacion_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(581, 121);
            label4.Name = "label4";
            label4.Size = new Size(81, 14);
            label4.TabIndex = 13;
            label4.Text = "Observacion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // AsistenciaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(812, 543);
            Controls.Add(pictureBox1);
            Controls.Add(txtObservacion);
            Controls.Add(label4);
            Controls.Add(txtEstado);
            Controls.Add(label3);
            Controls.Add(btnAllPermisos);
            Controls.Add(btnAllAusente);
            Controls.Add(btnAllPresente);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(btnAusente);
            Controls.Add(btnPermiso);
            Controls.Add(btnPresente);
            Controls.Add(txtCarnet);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AsistenciaForms";
            Text = "Registro de Asistencia";
            Load += AsistenciaForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtCarnet;
        private Button btnPresente;
        private Button btnPermiso;
        private Button btnAusente;
        private TextBox txtNombre;
        private Label label2;
        private Button btnAllPresente;
        private Button btnAllAusente;
        private Button btnAllPermisos;
        private TextBox txtEstado;
        private Label label3;
        private TextBox txtObservacion;
        private Label label4;
        private PictureBox pictureBox1;
    }
}