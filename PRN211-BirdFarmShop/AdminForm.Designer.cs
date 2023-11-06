namespace PRN211_BirdFarmShop
{
    partial class AdminForm
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
            dtg_Account = new DataGridView();
            groupBox2 = new GroupBox();
            txt_Search = new TextBox();
            btn_Search = new Button();
            groupBox3 = new GroupBox();
            dt_Birthday = new DateTimePicker();
            cbx_Role = new ComboBox();
            mtb_Phone = new MaskedTextBox();
            txt_Gender = new TextBox();
            txt_City = new TextBox();
            txt_Password = new TextBox();
            txt_Street = new TextBox();
            txt_FullName = new TextBox();
            txt_Email = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            btn_Close = new Button();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_Add = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Account).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_Account);
            groupBox1.Location = new Point(12, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1027, 184);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "View";
            // 
            // dtg_Account
            // 
            dtg_Account.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Account.Location = new Point(6, 26);
            dtg_Account.Name = "dtg_Account";
            dtg_Account.RowHeadersWidth = 51;
            dtg_Account.RowTemplate.Height = 29;
            dtg_Account.Size = new Size(1015, 152);
            dtg_Account.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_Search);
            groupBox2.Controls.Add(btn_Search);
            groupBox2.Location = new Point(12, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1027, 64);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txt_Search
            // 
            txt_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Search.Location = new Point(6, 20);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(897, 34);
            txt_Search.TabIndex = 1;
            // 
            // btn_Search
            // 
            btn_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.Location = new Point(909, 17);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(112, 41);
            btn_Search.TabIndex = 0;
            btn_Search.Text = "Tìm Kiếm";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dt_Birthday);
            groupBox3.Controls.Add(cbx_Role);
            groupBox3.Controls.Add(mtb_Phone);
            groupBox3.Controls.Add(txt_Gender);
            groupBox3.Controls.Add(txt_City);
            groupBox3.Controls.Add(txt_Password);
            groupBox3.Controls.Add(txt_Street);
            groupBox3.Controls.Add(txt_FullName);
            groupBox3.Controls.Add(txt_Email);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 265);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1027, 297);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông Tin";
            // 
            // dt_Birthday
            // 
            dt_Birthday.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dt_Birthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dt_Birthday.Location = new Point(651, 195);
            dt_Birthday.Name = "dt_Birthday";
            dt_Birthday.Size = new Size(358, 34);
            dt_Birthday.TabIndex = 17;
            // 
            // cbx_Role
            // 
            cbx_Role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_Role.FormattingEnabled = true;
            cbx_Role.Location = new Point(651, 241);
            cbx_Role.Name = "cbx_Role";
            cbx_Role.Size = new Size(182, 36);
            cbx_Role.TabIndex = 16;
            // 
            // mtb_Phone
            // 
            mtb_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_Phone.Location = new Point(183, 195);
            mtb_Phone.Mask = "(999) 000-0000";
            mtb_Phone.Name = "mtb_Phone";
            mtb_Phone.Size = new Size(356, 34);
            mtb_Phone.TabIndex = 15;
            // 
            // txt_Gender
            // 
            txt_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Gender.Location = new Point(181, 243);
            txt_Gender.Name = "txt_Gender";
            txt_Gender.Size = new Size(358, 34);
            txt_Gender.TabIndex = 14;
            // 
            // txt_City
            // 
            txt_City.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_City.Location = new Point(651, 145);
            txt_City.Name = "txt_City";
            txt_City.Size = new Size(358, 34);
            txt_City.TabIndex = 13;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(651, 93);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(358, 34);
            txt_Password.TabIndex = 12;
            // 
            // txt_Street
            // 
            txt_Street.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Street.Location = new Point(181, 145);
            txt_Street.Name = "txt_Street";
            txt_Street.Size = new Size(358, 34);
            txt_Street.TabIndex = 11;
            // 
            // txt_FullName
            // 
            txt_FullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_FullName.Location = new Point(181, 41);
            txt_FullName.Name = "txt_FullName";
            txt_FullName.Size = new Size(358, 34);
            txt_FullName.TabIndex = 10;
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Email.Location = new Point(181, 93);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(358, 34);
            txt_Email.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(545, 246);
            label9.Name = "label9";
            label9.Size = new Size(88, 28);
            label9.TabIndex = 8;
            label9.Text = "Chức Vụ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(545, 195);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 7;
            label8.Text = "Ngày Sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(545, 145);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 6;
            label7.Text = "Thành Phố:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(545, 93);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 5;
            label6.Text = "Mật Khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 195);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 4;
            label5.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 145);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 3;
            label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 93);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 246);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "Giới Tính:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_Close);
            groupBox4.Controls.Add(btn_Delete);
            groupBox4.Controls.Add(btn_Update);
            groupBox4.Controls.Add(btn_Add);
            groupBox4.Location = new Point(12, 568);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1027, 66);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Close.Location = new Point(909, 19);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(112, 41);
            btn_Close.TabIndex = 4;
            btn_Close.Text = "Đăng Xuất";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.Location = new Point(269, 18);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 41);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(137, 18);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(112, 41);
            btn_Update.TabIndex = 2;
            btn_Update.Text = "Cập Nhật";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.Location = new Point(6, 18);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(112, 41);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 639);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_Account).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private GroupBox groupBox4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dtg_Account;
        private TextBox txt_Search;
        private Button btn_Search;
        private TextBox txt_Email;
        private Button btn_Close;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private DateTimePicker dt_Birthday;
        private ComboBox cbx_Role;
        private MaskedTextBox mtb_Phone;
        private TextBox txt_Gender;
        private TextBox txt_City;
        private TextBox txt_Password;
        private TextBox txt_Street;
        private TextBox txt_FullName;
    }
}