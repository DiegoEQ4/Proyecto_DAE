namespace Proyecto_DAE
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(245, 250);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 0;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(275, 133);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(275, 205);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 2;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 213);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 141);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 85);
            label3.Name = "label3";
            label3.Size = new Size(232, 15);
            label3.TabIndex = 5;
            label3.Text = "Ingresa tus credenciales de inicio de sesion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 37);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 6;
            label4.Text = "INGRESA AL SISTEMA";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(245, 313);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 46);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 415);
            ControlBox = false;
            Controls.Add(btnCerrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(button1);
            Name = "Login";
            Text = "Inicio de Sesion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCerrar;
    }
}
