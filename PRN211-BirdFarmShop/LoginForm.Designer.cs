namespace PRN211_BirdFarmShop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            gb_Login = new GroupBox();
            lb_UnhidePassword = new PictureBox();
            btn_Register = new Button();
            label2 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            tb_Password = new TextBox();
            tb_Username = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_Login = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            gb_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lb_UnhidePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gb_Login
            // 
            gb_Login.Controls.Add(lb_UnhidePassword);
            gb_Login.Controls.Add(btn_Register);
            gb_Login.Controls.Add(label2);
            gb_Login.Controls.Add(panel2);
            gb_Login.Controls.Add(panel1);
            gb_Login.Controls.Add(tb_Password);
            gb_Login.Controls.Add(tb_Username);
            gb_Login.Controls.Add(pictureBox3);
            gb_Login.Controls.Add(pictureBox2);
            gb_Login.Controls.Add(btn_Login);
            gb_Login.Location = new Point(26, 247);
            gb_Login.Name = "gb_Login";
            gb_Login.Size = new Size(357, 354);
            gb_Login.TabIndex = 5;
            gb_Login.TabStop = false;
            // 
            // lb_UnhidePassword
            // 
            lb_UnhidePassword.AccessibleRole = AccessibleRole.Cursor;
            lb_UnhidePassword.Cursor = Cursors.Hand;
            lb_UnhidePassword.Image = (Image)resources.GetObject("lb_UnhidePassword.Image");
            lb_UnhidePassword.Location = new Point(280, 134);
            lb_UnhidePassword.Name = "lb_UnhidePassword";
            lb_UnhidePassword.Size = new Size(25, 25);
            lb_UnhidePassword.SizeMode = PictureBoxSizeMode.Zoom;
            lb_UnhidePassword.TabIndex = 22;
            lb_UnhidePassword.TabStop = false;
            lb_UnhidePassword.Click += lb_UnhidePassword_Click;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.FromArgb(0, 117, 214);
            btn_Register.Cursor = Cursors.Hand;
            btn_Register.FlatAppearance.BorderSize = 0;
            btn_Register.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Register.Location = new Point(39, 253);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(285, 44);
            btn_Register.TabIndex = 16;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(157, 311);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 15;
            label2.Text = "Exit";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.ForeColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(50, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 3);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.ForeColor = Color.FromArgb(0, 117, 214);
            panel1.Location = new Point(50, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 3);
            panel1.TabIndex = 13;
            // 
            // tb_Password
            // 
            tb_Password.BorderStyle = BorderStyle.None;
            tb_Password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Password.ForeColor = Color.FromArgb(0, 117, 214);
            tb_Password.Location = new Point(81, 134);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '*';
            tb_Password.PlaceholderText = "Password";
            tb_Password.Size = new Size(224, 19);
            tb_Password.TabIndex = 8;
            // 
            // tb_Username
            // 
            tb_Username.BorderStyle = BorderStyle.None;
            tb_Username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Username.ForeColor = Color.FromArgb(0, 117, 214);
            tb_Username.Location = new Point(81, 59);
            tb_Username.Name = "tb_Username";
            tb_Username.PlaceholderText = "Email";
            tb_Username.Size = new Size(224, 19);
            tb_Username.TabIndex = 7;
            // 
            // pictureBox3
            // 

            pictureBox3.Image = PRN211_BirdFarmShop.Properties.Resources.key_image;
            pictureBox3.Location = new Point(50, 134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = PRN211_BirdFarmShop.Properties.Resources.user_login;
            pictureBox2.Location = new Point(50, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(0, 117, 214);
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(39, 203);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(285, 44);
            btn_Login.TabIndex = 9;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(140, 186);
            label1.Name = "label1";
            label1.Size = new Size(114, 36);
            label1.TabIndex = 7;
            label1.Text = "LOG IN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(410, 644);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(gb_Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            FormClosing += Form1_FormClosing;
            gb_Login.ResumeLayout(false);
            gb_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lb_UnhidePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_Login;
        private Button btn_Login;
        private TextBox tb_Password;
        private TextBox tb_Username;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label label2;
        private Button btn_Register;
        private PictureBox lb_UnhidePassword;
    }
}