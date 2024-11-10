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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForms));
            menuStrip1 = new MenuStrip();
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
            label1 = new Label();
            lblUser = new Label();
            pictureBox1 = new PictureBox();
            btnCerrarSesion = new Button();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reportesDeAsistenciaToolStripMenuItem = new ToolStripMenuItem();
            reporteDeEstudiantesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionDeMateriaToolStripMenuItem, gestionDeGradoToolStripMenuItem, gestionHumanoToolStripMenuItem, gestionDeClasesToolStripMenuItem, gestionDeAsistenciasToolStripMenuItem, gestionUToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(890, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // gestionDeMateriaToolStripMenuItem
            // 
            gestionDeMateriaToolStripMenuItem.Name = "gestionDeMateriaToolStripMenuItem";
            gestionDeMateriaToolStripMenuItem.Size = new Size(118, 20);
            gestionDeMateriaToolStripMenuItem.Text = "Gestion de Materia";
            gestionDeMateriaToolStripMenuItem.Click += gestionDeMateriaToolStripMenuItem_Click;
            // 
            // gestionDeGradoToolStripMenuItem
            // 
            gestionDeGradoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asignarMateriasAGradoToolStripMenuItem, añadirEditarOBorrarToolStripMenuItem });
            gestionDeGradoToolStripMenuItem.Name = "gestionDeGradoToolStripMenuItem";
            gestionDeGradoToolStripMenuItem.Size = new Size(110, 20);
            gestionDeGradoToolStripMenuItem.Text = "Gestion de Grado";
            gestionDeGradoToolStripMenuItem.Click += gestionDeGradoToolStripMenuItem_Click;
            // 
            // asignarMateriasAGradoToolStripMenuItem
            // 
            asignarMateriasAGradoToolStripMenuItem.Name = "asignarMateriasAGradoToolStripMenuItem";
            asignarMateriasAGradoToolStripMenuItem.Size = new Size(206, 22);
            asignarMateriasAGradoToolStripMenuItem.Text = "Asignar Materias a Grado";
            asignarMateriasAGradoToolStripMenuItem.Click += asignarMateriasAGradoToolStripMenuItem_Click;
            // 
            // añadirEditarOBorrarToolStripMenuItem
            // 
            añadirEditarOBorrarToolStripMenuItem.Name = "añadirEditarOBorrarToolStripMenuItem";
            añadirEditarOBorrarToolStripMenuItem.Size = new Size(206, 22);
            añadirEditarOBorrarToolStripMenuItem.Text = "Añadir, Editar o Borrar";
            añadirEditarOBorrarToolStripMenuItem.Click += añadirEditarOBorrarToolStripMenuItem_Click;
            // 
            // gestionHumanoToolStripMenuItem
            // 
            gestionHumanoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeEstudianteToolStripMenuItem, gestionDeProfesorToolStripMenuItem });
            gestionHumanoToolStripMenuItem.Name = "gestionHumanoToolStripMenuItem";
            gestionHumanoToolStripMenuItem.Size = new Size(109, 20);
            gestionHumanoToolStripMenuItem.Text = "Gestion Humano";
            // 
            // gestionDeEstudianteToolStripMenuItem
            // 
            gestionDeEstudianteToolStripMenuItem.Name = "gestionDeEstudianteToolStripMenuItem";
            gestionDeEstudianteToolStripMenuItem.Size = new Size(188, 22);
            gestionDeEstudianteToolStripMenuItem.Text = "Gestion de Estudiante";
            gestionDeEstudianteToolStripMenuItem.Click += gestionDeEstudianteToolStripMenuItem_Click;
            // 
            // gestionDeProfesorToolStripMenuItem
            // 
            gestionDeProfesorToolStripMenuItem.Name = "gestionDeProfesorToolStripMenuItem";
            gestionDeProfesorToolStripMenuItem.Size = new Size(188, 22);
            gestionDeProfesorToolStripMenuItem.Text = "Gestion de Profesor";
            gestionDeProfesorToolStripMenuItem.Click += gestionDeProfesorToolStripMenuItem_Click;
            // 
            // gestionDeClasesToolStripMenuItem
            // 
            gestionDeClasesToolStripMenuItem.Name = "gestionDeClasesToolStripMenuItem";
            gestionDeClasesToolStripMenuItem.Size = new Size(111, 20);
            gestionDeClasesToolStripMenuItem.Text = "Gestion de Clases";
            gestionDeClasesToolStripMenuItem.Click += gestionDeClasesToolStripMenuItem_Click;
            // 
            // gestionDeAsistenciasToolStripMenuItem
            // 
            gestionDeAsistenciasToolStripMenuItem.Name = "gestionDeAsistenciasToolStripMenuItem";
            gestionDeAsistenciasToolStripMenuItem.Size = new Size(136, 20);
            gestionDeAsistenciasToolStripMenuItem.Text = "Gestion de Asistencias";
            gestionDeAsistenciasToolStripMenuItem.Click += gestionDeAsistenciasToolStripMenuItem_Click;
            // 
            // gestionUToolStripMenuItem
            // 
            gestionUToolStripMenuItem.Name = "gestionUToolStripMenuItem";
            gestionUToolStripMenuItem.Size = new Size(107, 20);
            gestionUToolStripMenuItem.Text = "Gestion Usuarios";
            gestionUToolStripMenuItem.Click += gestionUToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido al sistema";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(261, 39);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(75, 25);
            lblUser.TabIndex = 2;
            lblUser.Text = "usuario";
            lblUser.Click += lblUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(295, 130);
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
            btnCerrarSesion.Location = new Point(12, 76);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(133, 30);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesDeAsistenciaToolStripMenuItem, reporteDeEstudiantesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(141, 20);
            reportesToolStripMenuItem.Text = "Generacion de reportes";
            // 
            // reportesDeAsistenciaToolStripMenuItem
            // 
            reportesDeAsistenciaToolStripMenuItem.Name = "reportesDeAsistenciaToolStripMenuItem";
            reportesDeAsistenciaToolStripMenuItem.Size = new Size(194, 22);
            reportesDeAsistenciaToolStripMenuItem.Text = "Reportes de Asistencia";
            // 
            // reporteDeEstudiantesToolStripMenuItem
            // 
            reporteDeEstudiantesToolStripMenuItem.Name = "reporteDeEstudiantesToolStripMenuItem";
            reporteDeEstudiantesToolStripMenuItem.Size = new Size(194, 22);
            reporteDeEstudiantesToolStripMenuItem.Text = "Reporte de Estudiantes";
            // 
            // MenuForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(890, 481);
            ControlBox = false;
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
    }
}