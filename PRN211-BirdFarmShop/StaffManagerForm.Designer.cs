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
            groupBox1 = new GroupBox();
            dtg_staffList = new DataGridView();
            groupBox2 = new GroupBox();
            txtRole = new TextBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            radioFemale = new RadioButton();
            radioMale = new RadioButton();
            label10 = new Label();
            dt_birthday = new DateTimePicker();
            btClear = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            S = new Label();
            label4 = new Label();
            Email = new Label();
            txtPhone = new TextBox();
            txtCity = new TextBox();
            txtStreet = new TextBox();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            groupBox3 = new GroupBox();
            bt_close = new Button();
            bt_Save = new Button();
            bt_delete = new Button();
            bt_add = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_staffList).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            dtg_staffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_staffList.Dock = DockStyle.Fill;
            dtg_staffList.Location = new Point(3, 19);
            dtg_staffList.Name = "dtg_staffList";
            dtg_staffList.RowTemplate.Height = 25;
            dtg_staffList.Size = new Size(1011, 210);
            dtg_staffList.TabIndex = 0;
            dtg_staffList.CellClick += dtg_staffList_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(txtRole);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(dt_birthday);
            groupBox2.Controls.Add(btClear);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(S);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Email);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(txtStreet);
            groupBox2.Controls.Add(txtFullname);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Location = new Point(20, 333);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1017, 240);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(596, 200);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(247, 23);
            txtRole.TabIndex = 22;
            txtRole.Text = "Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 13);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 21;
            label2.Text = "Thông tin nhân viên";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioFemale);
            groupBox4.Controls.Add(radioMale);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(509, 142);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(334, 39);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(218, 12);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(41, 19);
            radioFemale.TabIndex = 6;
            radioFemale.Text = "Nữ";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Checked = true;
            radioMale.Location = new Point(87, 12);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(51, 19);
            radioMale.TabIndex = 5;
            radioMale.TabStop = true;
            radioMale.Text = "Nam";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 12);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 5;
            label10.Text = "Giới tính";
            // 
            // dt_birthday
            // 
            dt_birthday.Format = DateTimePickerFormat.Short;
            dt_birthday.Location = new Point(594, 107);
            dt_birthday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dt_birthday.Name = "dt_birthday";
            dt_birthday.RightToLeft = RightToLeft.No;
            dt_birthday.Size = new Size(249, 23);
            dt_birthday.TabIndex = 18;
            // 
            // btClear
            // 
            btClear.Location = new Point(922, 26);
            btClear.Name = "btClear";
            btClear.Size = new Size(75, 23);
            btClear.TabIndex = 0;
            btClear.Text = "Làm trống";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(518, 200);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 17;
            label9.Text = "Chức vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(509, 112);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 16;
            label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 64);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 15;
            label7.Text = "SĐT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 192);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 14;
            label6.Text = "Thành Phố";
            // 
            // S
            // 
            S.AutoSize = true;
            S.Location = new Point(90, 149);
            S.Name = "S";
            S.Size = new Size(43, 15);
            S.TabIndex = 13;
            S.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 102);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 12;
            label4.Text = "Họ và tên";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(97, 55);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 10;
            Email.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(594, 57);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(249, 23);
            txtPhone.TabIndex = 5;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(151, 189);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(258, 23);
            txtCity.TabIndex = 4;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(151, 146);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(258, 23);
            txtStreet.TabIndex = 3;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(151, 104);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(258, 23);
            txtFullname.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 23);
            txtEmail.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_close);
            groupBox3.Controls.Add(bt_Save);
            groupBox3.Controls.Add(bt_delete);
            groupBox3.Controls.Add(bt_add);
            groupBox3.Location = new Point(21, 579);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1016, 58);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // bt_close
            // 
            bt_close.Location = new Point(379, 22);
            bt_close.Name = "bt_close";
            bt_close.Size = new Size(75, 23);
            bt_close.TabIndex = 3;
            bt_close.Text = "Close";
            bt_close.UseVisualStyleBackColor = true;
            // 
            // bt_Save
            // 
            bt_Save.Location = new Point(277, 22);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new Size(75, 23);
            bt_Save.TabIndex = 2;
            bt_Save.Text = "Lưu";
            bt_Save.UseVisualStyleBackColor = true;
            bt_Save.Click += bt_Save_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(168, 22);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(75, 23);
            bt_delete.TabIndex = 1;
            bt_delete.Text = "Xoá";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(68, 22);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 0;
            bt_add.Text = "Tạo";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.Hand;
            txtSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(20, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm nhân viên . . .";
            txtSearch.Size = new Size(352, 32);
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
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Cyan;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 57);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(395, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 36);
            panel2.TabIndex = 23;
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
            pictureBox1.Location = new Point(335, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // StaffManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1075, 713);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(groupBox3);
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
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private GroupBox groupBox3;
        private Button bt_close;
        private Button bt_Save;
        private Button bt_delete;
        private Button bt_add;
        private TextBox txtSearch;
        private Button btClear;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label S;
        private Label label4;
        private Label label3;
        private Label Email;
        private Label label1;
        private DateTimePicker dt_birthday;
        private GroupBox groupBox4;
        private DataGridView dtg_staffList;
        private Label label2;
        private TextBox txtRole;
        private RadioButton radioFemale;
        private RadioButton radioMale;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}