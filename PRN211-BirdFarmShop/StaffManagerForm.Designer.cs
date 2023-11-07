namespace PRN211_BirdFarmShop
{
    partial class StaffManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffManagerForm));
            groupBox1 = new GroupBox();
            dtg_staffList = new DataGridView();
            groupBox2 = new GroupBox();
            bt_delete = new Button();
            bt_Save = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btClear = new Button();
            bt_add = new Button();
            panel5 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            S = new Label();
            label4 = new Label();
            Email = new Label();
            panel7 = new Panel();
            txtEmail = new TextBox();
            panel8 = new Panel();
            txtFullname = new TextBox();
            panel9 = new Panel();
            txtCity = new TextBox();
            panel10 = new Panel();
            txtStreet = new TextBox();
            panel11 = new Panel();
            txtPhone = new TextBox();
            panel12 = new Panel();
            dt_birthday = new DateTimePicker();
            panel13 = new Panel();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            panel14 = new Panel();
            txtRole = new TextBox();
            bt_close = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel6 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_staffList).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_staffList);
            groupBox1.Location = new Point(20, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1017, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dtg_staffList
            // 
            dtg_staffList.BackgroundColor = SystemColors.GradientActiveCaption;
            dtg_staffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_staffList.Dock = DockStyle.Fill;
            dtg_staffList.GridColor = Color.Moccasin;
            dtg_staffList.Location = new Point(3, 19);
            dtg_staffList.Name = "dtg_staffList";
            dtg_staffList.RowTemplate.Height = 25;
            dtg_staffList.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dtg_staffList.Size = new Size(1011, 210);
            dtg_staffList.TabIndex = 0;
            dtg_staffList.CellClick += dtg_staffList_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_delete);
            groupBox2.Controls.Add(bt_Save);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(btClear);
            groupBox2.Controls.Add(bt_add);
            groupBox2.Controls.Add(panel5);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(S);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Email);
            groupBox2.Controls.Add(panel7);
            groupBox2.Controls.Add(panel8);
            groupBox2.Controls.Add(panel9);
            groupBox2.Controls.Add(panel10);
            groupBox2.Controls.Add(panel11);
            groupBox2.Controls.Add(panel12);
            groupBox2.Controls.Add(panel13);
            groupBox2.Controls.Add(panel14);
            groupBox2.ImeMode = ImeMode.NoControl;
            groupBox2.Location = new Point(20, 333);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1017, 338);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = Color.Yellow;
            bt_delete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_delete.Image = Properties.Resources.icons8_delete_19;
            bt_delete.Location = new Point(816, 14);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(75, 31);
            bt_delete.TabIndex = 1;
            bt_delete.Text = "Xoá";
            bt_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_Save
            // 
            bt_Save.BackColor = Color.FromArgb(192, 255, 255);
            bt_Save.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Save.Image = (Image)resources.GetObject("bt_Save.Image");
            bt_Save.Location = new Point(715, 14);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new Size(75, 31);
            bt_Save.TabIndex = 2;
            bt_Save.Text = "Lưu";
            bt_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Save.UseVisualStyleBackColor = false;
            bt_Save.Click += bt_Save_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 37);
            panel2.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_profile_2_50;
            pictureBox2.Location = new Point(215, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 5);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 21;
            label2.Text = "Thông tin nhân viên";
            // 
            // btClear
            // 
            btClear.BackColor = Color.Linen;
            btClear.Image = Properties.Resources.icons8_clear_19;
            btClear.Location = new Point(919, 14);
            btClear.Name = "btClear";
            btClear.Size = new Size(75, 29);
            btClear.TabIndex = 0;
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += button6_Click;
            // 
            // bt_add
            // 
            bt_add.BackColor = Color.LightGreen;
            bt_add.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_add.Image = Properties.Resources.icons8_add_button_19;
            bt_add.Location = new Point(613, 14);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 31);
            bt_add.TabIndex = 0;
            bt_add.Text = "Tạo";
            bt_add.TextAlign = ContentAlignment.MiddleRight;
            bt_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += bt_add_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Linen;
            panel5.Location = new Point(1007, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 330);
            panel5.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(548, 176);
            label10.Name = "label10";
            label10.Size = new Size(71, 21);
            label10.TabIndex = 5;
            label10.Text = "Giới tính";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(547, 222);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 17;
            label9.Text = "Chức vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(538, 125);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 16;
            label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(576, 77);
            label7.Name = "label7";
            label7.Size = new Size(39, 21);
            label7.TabIndex = 15;
            label7.Text = "SĐT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(43, 175);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 14;
            label6.Text = "Thành Phố";
            // 
            // S
            // 
            S.AutoSize = true;
            S.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            S.Location = new Point(71, 222);
            S.Name = "S";
            S.Size = new Size(58, 21);
            S.TabIndex = 13;
            S.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(49, 125);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 12;
            label4.Text = "Họ và tên";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Email.Location = new Point(81, 77);
            Email.Name = "Email";
            Email.Size = new Size(48, 21);
            Email.TabIndex = 10;
            Email.Text = "Email";
            Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LavenderBlush;
            panel7.Controls.Add(txtEmail);
            panel7.Location = new Point(152, 61);
            panel7.Name = "panel7";
            panel7.Size = new Size(275, 42);
            panel7.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 31);
            txtEmail.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LavenderBlush;
            panel8.Controls.Add(txtFullname);
            panel8.Location = new Point(154, 117);
            panel8.Name = "panel8";
            panel8.Size = new Size(273, 42);
            panel8.TabIndex = 25;
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullname.Location = new Point(3, 4);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(258, 31);
            txtFullname.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.LavenderBlush;
            panel9.Controls.Add(txtCity);
            panel9.Location = new Point(154, 165);
            panel9.Name = "panel9";
            panel9.Size = new Size(273, 42);
            panel9.TabIndex = 26;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(3, 6);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(258, 31);
            txtCity.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.BackColor = Color.LavenderBlush;
            panel10.Controls.Add(txtStreet);
            panel10.Location = new Point(152, 216);
            panel10.Name = "panel10";
            panel10.Size = new Size(275, 99);
            panel10.TabIndex = 27;
            // 
            // txtStreet
            // 
            txtStreet.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtStreet.Location = new Point(3, 3);
            txtStreet.Multiline = true;
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(258, 93);
            txtStreet.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.BackColor = Color.LavenderBlush;
            panel11.Controls.Add(txtPhone);
            panel11.Location = new Point(648, 61);
            panel11.Name = "panel11";
            panel11.Size = new Size(275, 42);
            panel11.TabIndex = 28;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(3, 8);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(260, 31);
            txtPhone.TabIndex = 5;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // panel12
            // 
            panel12.BackColor = Color.LavenderBlush;
            panel12.Controls.Add(dt_birthday);
            panel12.Location = new Point(648, 117);
            panel12.Name = "panel12";
            panel12.Size = new Size(275, 42);
            panel12.TabIndex = 29;
            // 
            // dt_birthday
            // 
            dt_birthday.CalendarMonthBackground = Color.Azure;
            dt_birthday.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dt_birthday.Format = DateTimePickerFormat.Short;
            dt_birthday.Location = new Point(3, 8);
            dt_birthday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dt_birthday.Name = "dt_birthday";
            dt_birthday.RightToLeft = RightToLeft.No;
            dt_birthday.Size = new Size(260, 31);
            dt_birthday.TabIndex = 18;
            // 
            // panel13
            // 
            panel13.BackColor = Color.LavenderBlush;
            panel13.Controls.Add(radioMale);
            panel13.Controls.Add(radioFemale);
            panel13.Location = new Point(645, 168);
            panel13.Name = "panel13";
            panel13.Size = new Size(275, 39);
            panel13.TabIndex = 30;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Checked = true;
            radioMale.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            radioMale.Location = new Point(26, 3);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(68, 29);
            radioMale.TabIndex = 5;
            radioMale.TabStop = true;
            radioMale.Text = "Nam";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            radioFemale.Location = new Point(161, 3);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(54, 29);
            radioFemale.TabIndex = 6;
            radioFemale.Text = "Nữ";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.BackColor = Color.LavenderBlush;
            panel14.Controls.Add(txtRole);
            panel14.Location = new Point(645, 216);
            panel14.Name = "panel14";
            panel14.Size = new Size(275, 42);
            panel14.TabIndex = 31;
            // 
            // txtRole
            // 
            txtRole.BackColor = SystemColors.ControlLightLight;
            txtRole.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRole.Location = new Point(3, 8);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(260, 31);
            txtRole.TabIndex = 22;
            txtRole.Text = "Nhân Viên";
            // 
            // bt_close
            // 
            bt_close.Image = Properties.Resources.icons8_close_window_50;
            bt_close.Location = new Point(1037, 0);
            bt_close.Name = "bt_close";
            bt_close.Size = new Size(38, 35);
            bt_close.TabIndex = 3;
            bt_close.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.Hand;
            txtSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(20, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm nhân viên . . .";
            txtSearch.Size = new Size(393, 32);
            txtSearch.TabIndex = 3;
            txtSearch.Tag = "";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(415, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 35);
            label1.TabIndex = 1;
            label1.Text = "Quản lí nhân viên";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(bt_close);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Cyan;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 57);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Location = new Point(0, 692);
            panel3.Name = "panel3";
            panel3.Size = new Size(1095, 28);
            panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icons_search_19;
            pictureBox1.Location = new Point(375, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Linen;
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(20, 342);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 329);
            panel4.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1004, 10);
            panel6.TabIndex = 24;
            // 
            // StaffManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1075, 713);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffManagerForm";
            Load += StaffManagerForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_staffList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPhone;
        private TextBox txtCity;
        private TextBox txtStreet;
        private TextBox txtFullname;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button bt_close;
        private Button bt_Save;
        private Button bt_delete;
        private Button bt_add;
        private TextBox txtSearch;
        private Button btClear;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label S;
        private Label label4;
        private Label label3;
        private Label label1;
        private DateTimePicker dt_birthday;
        private DataGridView dtg_staffList;
        private Label label2;
        private TextBox txtRole;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RadioButton radioFemale;
        private Label label10;
        private RadioButton radioMale;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Label Email;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
    }
}