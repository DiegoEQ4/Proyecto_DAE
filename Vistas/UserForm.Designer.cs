namespace Proyecto_DAE.Vistas
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            label1 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnCrear = new Button();
            button2 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(131, 119);
            label1.Name = "label1";
            label1.Size = new Size(103, 14);
            label1.TabIndex = 0;
            label1.Text = "Nombre usuario";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(235, 116);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(123, 23);
            txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(235, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(123, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(155, 172);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.YellowGreen;
            btnCrear.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(148, 231);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(86, 40);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(292, 231);
            button2.Name = "button2";
            button2.Size = new Size(93, 40);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(184, 13);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 6;
            label3.Text = "Crear Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(219, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(432, -25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 331);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-18, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 305);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(531, 306);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnCrear);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserForm";
            Text = "Usuario";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label2;
        private Button btnCrear;
        private Button button2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}