namespace PRN211_BirdFarmShop
{
    partial class OrderForm
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
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            txt_SoLuong = new TextBox();
            txt_DonGia = new TextBox();
            txt_ThanhTien = new TextBox();
            label10 = new Label();
            cbx_MaHang = new ComboBox();
            label6 = new Label();
            label11 = new Label();
            txt_TenHang = new TextBox();
            txt_GiamGia = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(221, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 0;
            label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 1);
            splitContainer1.Margin = new Padding(2, 2, 2, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(750, 421);
            splitContainer1.SplitterDistance = 149;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 34);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(743, 115);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            groupBox1.ChangeUICues += OrderForm_Load;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 68);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 92);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(150, 44);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 20);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(27, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 5;
            label3.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 117, 214);
            label5.Location = new Point(27, 46);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 4;
            label5.Text = "Ngày bán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(27, 71);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 3;
            label4.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(27, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 1;
            label2.Text = "Mã hoá đơn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(750, 270);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(598, 211);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 117, 214);
            label12.Location = new Point(512, 213);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(72, 19);
            label12.TabIndex = 26;
            label12.Text = "Tổng tiền:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(4, 88);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(744, 120);
            dataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã hàng";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên hàng";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn giá";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Giảm giá";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Thành tiền";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(6, 242);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 28);
            panel1.TabIndex = 26;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 117, 214);
            button1.Location = new Point(13, 2);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(129, 26);
            button1.TabIndex = 0;
            button1.Text = "Thêm hoá đơn";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_SoLuong);
            panel2.Controls.Add(txt_DonGia);
            panel2.Controls.Add(txt_ThanhTien);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cbx_MaHang);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txt_TenHang);
            panel2.Controls.Add(txt_GiamGia);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(6, 18);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 66);
            panel2.TabIndex = 27;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(94, 40);
            txt_SoLuong.Margin = new Padding(2, 2, 2, 2);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(150, 23);
            txt_SoLuong.TabIndex = 21;
            txt_SoLuong.TextChanged += txt_SoLuong_TextChanged;
            // 
            // txt_DonGia
            // 
            txt_DonGia.Location = new Point(592, 13);
            txt_DonGia.Margin = new Padding(2, 2, 2, 2);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.ReadOnly = true;
            txt_DonGia.Size = new Size(150, 23);
            txt_DonGia.TabIndex = 24;
            // 
            // txt_ThanhTien
            // 
            txt_ThanhTien.Location = new Point(592, 38);
            txt_ThanhTien.Margin = new Padding(2, 2, 2, 2);
            txt_ThanhTien.Name = "txt_ThanhTien";
            txt_ThanhTien.ReadOnly = true;
            txt_ThanhTien.Size = new Size(150, 23);
            txt_ThanhTien.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 117, 214);
            label10.Location = new Point(507, 13);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(62, 19);
            label10.TabIndex = 17;
            label10.Text = "Đơn giá:";
            // 
            // cbx_MaHang
            // 
            cbx_MaHang.FormattingEnabled = true;
            cbx_MaHang.Location = new Point(94, 10);
            cbx_MaHang.Margin = new Padding(2, 2, 2, 2);
            cbx_MaHang.Name = "cbx_MaHang";
            cbx_MaHang.Size = new Size(150, 23);
            cbx_MaHang.TabIndex = 10;
            cbx_MaHang.SelectedValueChanged += cbx_MaHang_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 117, 214);
            label6.Location = new Point(21, 13);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 2;
            label6.Text = "Mã hàng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 117, 214);
            label11.Location = new Point(507, 40);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(79, 19);
            label11.TabIndex = 18;
            label11.Text = "Thành tiền:";
            // 
            // txt_TenHang
            // 
            txt_TenHang.Location = new Point(345, 11);
            txt_TenHang.Margin = new Padding(2, 2, 2, 2);
            txt_TenHang.Name = "txt_TenHang";
            txt_TenHang.ReadOnly = true;
            txt_TenHang.Size = new Size(150, 23);
            txt_TenHang.TabIndex = 22;
            // 
            // txt_GiamGia
            // 
            txt_GiamGia.Location = new Point(345, 38);
            txt_GiamGia.Margin = new Padding(2, 2, 2, 2);
            txt_GiamGia.Name = "txt_GiamGia";
            txt_GiamGia.Size = new Size(150, 23);
            txt_GiamGia.TabIndex = 23;
            txt_GiamGia.TextChanged += txt_GiamGia_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 117, 214);
            label7.Location = new Point(21, 40);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 19);
            label7.TabIndex = 11;
            label7.Text = "Số lượng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 117, 214);
            label9.Location = new Point(259, 40);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 19);
            label9.TabIndex = 14;
            label9.Text = "Giảm giá %:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 117, 214);
            label8.Location = new Point(259, 13);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 19);
            label8.TabIndex = 13;
            label8.Text = "Tên hàng:";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 448);
            Controls.Add(splitContainer1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "OrderForm";
            Text = "OrderForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private ComboBox cbx_MaHang;
        private Label label6;
        private TextBox txt_SoLuong;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txt_ThanhTien;
        private TextBox txt_DonGia;
        private TextBox txt_GiamGia;
        private TextBox txt_TenHang;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label12;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button1;
    }
}