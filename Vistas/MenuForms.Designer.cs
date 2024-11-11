namespace Proyecto_DAE.Vistas
{
    partial class MenuForms
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
            MenuStrip menuStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForms));
            gestionDeMateriaToolStripMenuItem = new ToolStripMenuItem();
            gestionDeGradoToolStripMenuItem = new ToolStripMenuItem();
            asignarMateriasAGradoToolStripMenuItem = new ToolStripMenuItem();
            añadirEditarOBorrarToolStripMenuItem = new ToolStripMenuItem();
            gestionHumanoToolStripMenuItem = new ToolStripMenuItem();
            gestionDeEstudianteToolStripMenuItem = new ToolStripMenuItem();
            gestionDeProfesorToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClasesToolStripMenuItem = new ToolStripMenuItem();
            gestionDeAsistenciasToolStripMenuItem = new ToolStripMenuItem();
            gestionUToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reportesDeAsistenciaToolStripMenuItem = new ToolStripMenuItem();
            reporteDeEstudiantesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lblUser = new Label();
            pictureBox1 = new PictureBox();
            btnCerrarSesion = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 64, 64);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.GripMargin = new Padding(10, 9, 10, 10);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionDeMateriaToolStripMenuItem, gestionDeGradoToolStripMenuItem, gestionHumanoToolStripMenuItem, gestionDeClasesToolStripMenuItem, gestionDeAsistenciasToolStripMenuItem, gestionUToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 30, 10, 30);
            menuStrip1.Size = new Size(961, 78);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // gestionDeMateriaToolStripMenuItem
            // 
            gestionDeMateriaToolStripMenuItem.ForeColor = Color.White;
            gestionDeMateriaToolStripMenuItem.Name = "gestionDeMateriaToolStripMenuItem";
            gestionDeMateriaToolStripMenuItem.Size = new Size(134, 18);
            gestionDeMateriaToolStripMenuItem.Text = "Gestion de Materia";
            gestionDeMateriaToolStripMenuItem.Click += gestionDeMateriaToolStripMenuItem_Click;
            // 
            // gestionDeGradoToolStripMenuItem
            // 
            gestionDeGradoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asignarMateriasAGradoToolStripMenuItem, añadirEditarOBorrarToolStripMenuItem });
            gestionDeGradoToolStripMenuItem.ForeColor = Color.White;
            gestionDeGradoToolStripMenuItem.Name = "gestionDeGradoToolStripMenuItem";
            gestionDeGradoToolStripMenuItem.Size = new Size(124, 18);
            gestionDeGradoToolStripMenuItem.Text = "Gestion de Grado";
            gestionDeGradoToolStripMenuItem.Click += gestionDeGradoToolStripMenuItem_Click;
            // 
            // asignarMateriasAGradoToolStripMenuItem
            // 
            asignarMateriasAGradoToolStripMenuItem.Name = "asignarMateriasAGradoToolStripMenuItem";
            asignarMateriasAGradoToolStripMenuItem.Size = new Size(227, 22);
            asignarMateriasAGradoToolStripMenuItem.Text = "Asignar Materias a Grado";
            asignarMateriasAGradoToolStripMenuItem.Click += asignarMateriasAGradoToolStripMenuItem_Click;
            // 
            // añadirEditarOBorrarToolStripMenuItem
            // 
            añadirEditarOBorrarToolStripMenuItem.Name = "añadirEditarOBorrarToolStripMenuItem";
            añadirEditarOBorrarToolStripMenuItem.Size = new Size(227, 22);
            añadirEditarOBorrarToolStripMenuItem.Text = "Añadir, Editar o Borrar";
            añadirEditarOBorrarToolStripMenuItem.Click += añadirEditarOBorrarToolStripMenuItem_Click;
            // 
            // gestionHumanoToolStripMenuItem
            // 
            gestionHumanoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeEstudianteToolStripMenuItem, gestionDeProfesorToolStripMenuItem });
            gestionHumanoToolStripMenuItem.ForeColor = Color.White;
            gestionHumanoToolStripMenuItem.Name = "gestionHumanoToolStripMenuItem";
            gestionHumanoToolStripMenuItem.Size = new Size(120, 18);
            gestionHumanoToolStripMenuItem.Text = "Gestion Humano";
            // 
            // gestionDeEstudianteToolStripMenuItem
            // 
            gestionDeEstudianteToolStripMenuItem.Name = "gestionDeEstudianteToolStripMenuItem";
            gestionDeEstudianteToolStripMenuItem.Size = new Size(209, 22);
            gestionDeEstudianteToolStripMenuItem.Text = "Gestion de Estudiante";
            gestionDeEstudianteToolStripMenuItem.Click += gestionDeEstudianteToolStripMenuItem_Click;
            // 
            // gestionDeProfesorToolStripMenuItem
            // 
            gestionDeProfesorToolStripMenuItem.Name = "gestionDeProfesorToolStripMenuItem";
            gestionDeProfesorToolStripMenuItem.Size = new Size(209, 22);
            gestionDeProfesorToolStripMenuItem.Text = "Gestion de Profesor";
            gestionDeProfesorToolStripMenuItem.Click += gestionDeProfesorToolStripMenuItem_Click;
            // 
            // gestionDeClasesToolStripMenuItem
            // 
            gestionDeClasesToolStripMenuItem.ForeColor = Color.White;
            gestionDeClasesToolStripMenuItem.Name = "gestionDeClasesToolStripMenuItem";
            gestionDeClasesToolStripMenuItem.Size = new Size(125, 18);
            gestionDeClasesToolStripMenuItem.Text = "Gestion de Clases";
            gestionDeClasesToolStripMenuItem.Click += gestionDeClasesToolStripMenuItem_Click;
            // 
            // gestionDeAsistenciasToolStripMenuItem
            // 
            gestionDeAsistenciasToolStripMenuItem.ForeColor = Color.White;
            gestionDeAsistenciasToolStripMenuItem.Name = "gestionDeAsistenciasToolStripMenuItem";
            gestionDeAsistenciasToolStripMenuItem.Size = new Size(155, 18);
            gestionDeAsistenciasToolStripMenuItem.Text = "Gestion de Asistencias";
            gestionDeAsistenciasToolStripMenuItem.Click += gestionDeAsistenciasToolStripMenuItem_Click;
            // 
            // gestionUToolStripMenuItem
            // 
            gestionUToolStripMenuItem.ForeColor = Color.White;
            gestionUToolStripMenuItem.Name = "gestionUToolStripMenuItem";
            gestionUToolStripMenuItem.Size = new Size(120, 18);
            gestionUToolStripMenuItem.Text = "Gestion Usuarios";
            gestionUToolStripMenuItem.Click += gestionUToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesDeAsistenciaToolStripMenuItem, reporteDeEstudiantesToolStripMenuItem });
            reportesToolStripMenuItem.ForeColor = Color.White;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(161, 18);
            reportesToolStripMenuItem.Text = "Generacion de reportes";
            // 
            // reportesDeAsistenciaToolStripMenuItem
            // 
            reportesDeAsistenciaToolStripMenuItem.Name = "reportesDeAsistenciaToolStripMenuItem";
            reportesDeAsistenciaToolStripMenuItem.Size = new Size(219, 22);
            reportesDeAsistenciaToolStripMenuItem.Text = "Reportes de Asistencia";
            reportesDeAsistenciaToolStripMenuItem.Click += reportesDeAsistenciaToolStripMenuItem_Click;
            // 
            // reporteDeEstudiantesToolStripMenuItem
            // 
            reporteDeEstudiantesToolStripMenuItem.Name = "reporteDeEstudiantesToolStripMenuItem";
            reporteDeEstudiantesToolStripMenuItem.Size = new Size(219, 22);
            reporteDeEstudiantesToolStripMenuItem.Text = "Reporte de Estudiantes";
            reporteDeEstudiantesToolStripMenuItem.Click += reporteDeEstudiantesToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(287, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido al sistema";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(255, 128, 0);
            lblUser.Location = new Point(549, 99);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(82, 28);
            lblUser.TabIndex = 2;
            lblUser.Text = "Usuario";
            lblUser.Click += lblUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, 247);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(0, 64, 64);
            btnCerrarSesion.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(388, 633);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(167, 49);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-23, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 711);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(824, 79);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(151, 674);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(362, 133);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(212, 115);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // MenuForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(20, 20);
            BackColor = Color.White;
            ClientSize = new Size(950, 749);
            ControlBox = false;
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnCerrarSesion);
            Controls.Add(pictureBox1);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuForms";
            Text = "Menu Principal";
            Load += MenuForms_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionDeMateriaToolStripMenuItem;
        private ToolStripMenuItem gestionDeGradoToolStripMenuItem;
        private ToolStripMenuItem gestionHumanoToolStripMenuItem;
        private ToolStripMenuItem gestionDeEstudianteToolStripMenuItem;
        private ToolStripMenuItem gestionDeProfesorToolStripMenuItem;
        private Label label1;
        private Label lblUser;
        private PictureBox pictureBox1;
        private ToolStripMenuItem asignarMateriasAGradoToolStripMenuItem;
        private ToolStripMenuItem añadirEditarOBorrarToolStripMenuItem;
        private ToolStripMenuItem gestionDeClasesToolStripMenuItem;
        private ToolStripMenuItem gestionDeAsistenciasToolStripMenuItem;
        private Button btnCerrarSesion;
        private ToolStripMenuItem gestionUToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem reportesDeAsistenciaToolStripMenuItem;
        private ToolStripMenuItem reporteDeEstudiantesToolStripMenuItem;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}