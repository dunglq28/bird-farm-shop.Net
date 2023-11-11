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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            txt_TenKhachHang = new TextBox();
            label16 = new Label();
            cbx_SoDienThoai = new ComboBox();
            label15 = new Label();
            cbx_EmailNhanVien = new ComboBox();
            txt_TenNhanVien = new TextBox();
            dt_NgayBan = new DateTimePicker();
            txt_MaHoaDon = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label13 = new Label();
            txt_TongTien = new TextBox();
            label12 = new Label();
            dtg_OrderDetailList = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btn_Dong = new Button();
            btn_InHoaDon = new Button();
            btn_HuyHoaDon = new Button();
            btn_LuuHoaDon = new Button();
            btn_ThemSanPham = new Button();
            btn_ThemHoaDon = new Button();
            panel2 = new Panel();
            txt_GiongLoai = new TextBox();
            label17 = new Label();
            txt_SoLuong = new TextBox();
            txt_DonGia = new TextBox();
            txt_ThanhTien = new TextBox();
            label10 = new Label();
            cbx_MaHang = new ComboBox();
            label6 = new Label();
            label11 = new Label();
            txt_TenHang = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txt_TimMaHH = new TextBox();
            btn_TimKiem = new Button();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_OrderDetailList).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(418, 8);
            label1.Name = "label1";
            label1.Size = new Size(358, 45);
            label1.TabIndex = 0;
            label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 1);
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
            splitContainer1.Size = new Size(1207, 702);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_TenKhachHang);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(cbx_SoDienThoai);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbx_EmailNhanVien);
            groupBox1.Controls.Add(txt_TenNhanVien);
            groupBox1.Controls.Add(dt_NgayBan);
            groupBox1.Controls.Add(txt_MaHoaDon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1197, 191);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            groupBox1.ChangeUICues += OrderForm_Load;
            // 
            // txt_TenKhachHang
            // 
            txt_TenKhachHang.Location = new Point(846, 74);
            txt_TenKhachHang.Name = "txt_TenKhachHang";
            txt_TenKhachHang.Size = new Size(266, 31);
            txt_TenKhachHang.TabIndex = 13;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(0, 117, 214);
            label16.Location = new Point(658, 77);
            label16.Name = "label16";
            label16.Size = new Size(156, 28);
            label16.TabIndex = 12;
            label16.Text = "Tên khách hàng";
            // 
            // cbx_SoDienThoai
            // 
            cbx_SoDienThoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_SoDienThoai.FormattingEnabled = true;
            cbx_SoDienThoai.Location = new Point(846, 32);
            cbx_SoDienThoai.Name = "cbx_SoDienThoai";
            cbx_SoDienThoai.Size = new Size(266, 33);
            cbx_SoDienThoai.TabIndex = 11;
            cbx_SoDienThoai.SelectedValueChanged += cbx_SoDienThoai_SelectedValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(0, 117, 214);
            label15.Location = new Point(658, 37);
            label15.Name = "label15";
            label15.Size = new Size(138, 28);
            label15.TabIndex = 10;
            label15.Text = "Số điện thoại:";
            // 
            // cbx_EmailNhanVien
            // 
            cbx_EmailNhanVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_EmailNhanVien.FormattingEnabled = true;
            cbx_EmailNhanVien.Location = new Point(214, 114);
            cbx_EmailNhanVien.Name = "cbx_EmailNhanVien";
            cbx_EmailNhanVien.Size = new Size(266, 33);
            cbx_EmailNhanVien.TabIndex = 9;
            cbx_EmailNhanVien.SelectedValueChanged += cbx_EmailNhanVien_SelectedValueChanged;
            // 
            // txt_TenNhanVien
            // 
            txt_TenNhanVien.Location = new Point(214, 154);
            txt_TenNhanVien.Name = "txt_TenNhanVien";
            txt_TenNhanVien.Size = new Size(266, 31);
            txt_TenNhanVien.TabIndex = 8;
            // 
            // dt_NgayBan
            // 
            dt_NgayBan.Enabled = false;
            dt_NgayBan.Format = DateTimePickerFormat.Short;
            dt_NgayBan.Location = new Point(214, 74);
            dt_NgayBan.Name = "dt_NgayBan";
            dt_NgayBan.Size = new Size(266, 31);
            dt_NgayBan.TabIndex = 7;
            // 
            // txt_MaHoaDon
            // 
            txt_MaHoaDon.Location = new Point(214, 34);
            txt_MaHoaDon.Name = "txt_MaHoaDon";
            txt_MaHoaDon.ReadOnly = true;
            txt_MaHoaDon.Size = new Size(266, 31);
            txt_MaHoaDon.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(38, 157);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 5;
            label3.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 117, 214);
            label5.Location = new Point(38, 77);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 4;
            label5.Text = "Ngày bán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(38, 119);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 3;
            label4.Text = "Email nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(38, 37);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã hoá đơn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txt_TongTien);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(dtg_OrderDetailList);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1207, 448);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(13, 358);
            label13.Name = "label13";
            label13.Size = new Size(210, 21);
            label13.TabIndex = 29;
            label13.Text = "Nháy đúp một dòng để xoá";
            // 
            // txt_TongTien
            // 
            txt_TongTien.Location = new Point(854, 352);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.ReadOnly = true;
            txt_TongTien.Size = new Size(212, 31);
            txt_TongTien.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 117, 214);
            label12.Location = new Point(732, 355);
            label12.Name = "label12";
            label12.Size = new Size(105, 28);
            label12.TabIndex = 26;
            label12.Text = "Tổng tiền:";
            // 
            // dtg_OrderDetailList
            // 
            dtg_OrderDetailList.BackgroundColor = Color.White;
            dtg_OrderDetailList.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtg_OrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_OrderDetailList.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, Quantity, Price, Total });
            dtg_OrderDetailList.GridColor = SystemColors.ControlLight;
            dtg_OrderDetailList.Location = new Point(6, 146);
            dtg_OrderDetailList.Name = "dtg_OrderDetailList";
            dtg_OrderDetailList.RowHeadersWidth = 62;
            dtg_OrderDetailList.RowTemplate.Height = 33;
            dtg_OrderDetailList.Size = new Size(1199, 200);
            dtg_OrderDetailList.TabIndex = 28;
            dtg_OrderDetailList.CellDoubleClick += dtg_OrderDetailList_CellDoubleClick;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "Mã hàng";
            ProductId.MinimumWidth = 8;
            ProductId.Name = "ProductId";
            ProductId.Width = 200;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Tên hàng";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.Width = 250;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 200;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Đơn giá";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 200;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Thành tiền";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.Width = 200;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Dong);
            panel1.Controls.Add(btn_InHoaDon);
            panel1.Controls.Add(btn_HuyHoaDon);
            panel1.Controls.Add(btn_LuuHoaDon);
            panel1.Controls.Add(btn_ThemSanPham);
            panel1.Controls.Add(btn_ThemHoaDon);
            panel1.Location = new Point(8, 389);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 59);
            panel1.TabIndex = 26;
            // 
            // btn_Dong
            // 
            btn_Dong.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Dong.ForeColor = Color.FromArgb(0, 117, 214);
            btn_Dong.Image = (Image)resources.GetObject("btn_Dong.Image");
            btn_Dong.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Dong.Location = new Point(998, 5);
            btn_Dong.Name = "btn_Dong";
            btn_Dong.Size = new Size(190, 48);
            btn_Dong.TabIndex = 6;
            btn_Dong.Text = "Đóng";
            btn_Dong.UseVisualStyleBackColor = true;
            btn_Dong.Click += btn_Dong_Click;
            // 
            // btn_InHoaDon
            // 
            btn_InHoaDon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_InHoaDon.ForeColor = Color.FromArgb(0, 117, 214);
            btn_InHoaDon.Image = (Image)resources.GetObject("btn_InHoaDon.Image");
            btn_InHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_InHoaDon.Location = new Point(802, 5);
            btn_InHoaDon.Name = "btn_InHoaDon";
            btn_InHoaDon.Size = new Size(190, 48);
            btn_InHoaDon.TabIndex = 5;
            btn_InHoaDon.Text = "In hoá đơn";
            btn_InHoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_HuyHoaDon
            // 
            btn_HuyHoaDon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_HuyHoaDon.ForeColor = Color.FromArgb(0, 117, 214);
            btn_HuyHoaDon.Image = (Image)resources.GetObject("btn_HuyHoaDon.Image");
            btn_HuyHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_HuyHoaDon.Location = new Point(606, 5);
            btn_HuyHoaDon.Name = "btn_HuyHoaDon";
            btn_HuyHoaDon.Size = new Size(190, 48);
            btn_HuyHoaDon.TabIndex = 4;
            btn_HuyHoaDon.Text = "Huỷ hoá đơn";
            btn_HuyHoaDon.UseVisualStyleBackColor = true;
            btn_HuyHoaDon.Click += btn_HuyHoaDon_Click;
            // 
            // btn_LuuHoaDon
            // 
            btn_LuuHoaDon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LuuHoaDon.ForeColor = Color.FromArgb(0, 117, 214);
            btn_LuuHoaDon.Image = (Image)resources.GetObject("btn_LuuHoaDon.Image");
            btn_LuuHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LuuHoaDon.Location = new Point(410, 5);
            btn_LuuHoaDon.Name = "btn_LuuHoaDon";
            btn_LuuHoaDon.Size = new Size(190, 48);
            btn_LuuHoaDon.TabIndex = 3;
            btn_LuuHoaDon.Text = "Lưu hoá đơn";
            btn_LuuHoaDon.UseVisualStyleBackColor = true;
            btn_LuuHoaDon.Click += btn_LuuHoaDon_Click;
            // 
            // btn_ThemSanPham
            // 
            btn_ThemSanPham.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThemSanPham.ForeColor = Color.FromArgb(0, 117, 214);
            btn_ThemSanPham.Image = (Image)resources.GetObject("btn_ThemSanPham.Image");
            btn_ThemSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThemSanPham.Location = new Point(205, 5);
            btn_ThemSanPham.Name = "btn_ThemSanPham";
            btn_ThemSanPham.Size = new Size(199, 48);
            btn_ThemSanPham.TabIndex = 2;
            btn_ThemSanPham.Text = "Thêm sản phẩm";
            btn_ThemSanPham.TextAlign = ContentAlignment.MiddleRight;
            btn_ThemSanPham.UseVisualStyleBackColor = true;
            btn_ThemSanPham.Click += btn_ThemSanPham_Click;
            // 
            // btn_ThemHoaDon
            // 
            btn_ThemHoaDon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThemHoaDon.ForeColor = Color.FromArgb(0, 117, 214);
            btn_ThemHoaDon.Image = (Image)resources.GetObject("btn_ThemHoaDon.Image");
            btn_ThemHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThemHoaDon.Location = new Point(5, 5);
            btn_ThemHoaDon.Name = "btn_ThemHoaDon";
            btn_ThemHoaDon.Size = new Size(194, 48);
            btn_ThemHoaDon.TabIndex = 0;
            btn_ThemHoaDon.Text = "Thêm hoá đơn";
            btn_ThemHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btn_ThemHoaDon.UseVisualStyleBackColor = true;
            btn_ThemHoaDon.Click += btn_ThemHoaDon_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_GiongLoai);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(txt_SoLuong);
            panel2.Controls.Add(txt_DonGia);
            panel2.Controls.Add(txt_ThanhTien);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cbx_MaHang);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txt_TenHang);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(8, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(1197, 110);
            panel2.TabIndex = 27;
            // 
            // txt_GiongLoai
            // 
            txt_GiongLoai.Location = new Point(944, 13);
            txt_GiongLoai.Name = "txt_GiongLoai";
            txt_GiongLoai.ReadOnly = true;
            txt_GiongLoai.Size = new Size(212, 31);
            txt_GiongLoai.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(0, 117, 214);
            label17.Location = new Point(828, 16);
            label17.Name = "label17";
            label17.Size = new Size(110, 28);
            label17.TabIndex = 26;
            label17.Text = "Giống loài:";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(135, 67);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(212, 31);
            txt_SoLuong.TabIndex = 21;
            txt_SoLuong.TextChanged += txt_SoLuong_TextChanged;
            // 
            // txt_DonGia
            // 
            txt_DonGia.Location = new Point(556, 67);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.ReadOnly = true;
            txt_DonGia.Size = new Size(212, 31);
            txt_DonGia.TabIndex = 24;
            // 
            // txt_ThanhTien
            // 
            txt_ThanhTien.Location = new Point(944, 64);
            txt_ThanhTien.Name = "txt_ThanhTien";
            txt_ThanhTien.ReadOnly = true;
            txt_ThanhTien.Size = new Size(212, 31);
            txt_ThanhTien.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 117, 214);
            label10.Location = new Point(410, 70);
            label10.Name = "label10";
            label10.Size = new Size(88, 28);
            label10.TabIndex = 17;
            label10.Text = "Đơn giá:";
            // 
            // cbx_MaHang
            // 
            cbx_MaHang.FormattingEnabled = true;
            cbx_MaHang.Location = new Point(135, 16);
            cbx_MaHang.Name = "cbx_MaHang";
            cbx_MaHang.Size = new Size(212, 33);
            cbx_MaHang.TabIndex = 10;
            cbx_MaHang.SelectedValueChanged += cbx_MaHang_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 117, 214);
            label6.Location = new Point(30, 21);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 2;
            label6.Text = "Mã hàng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 117, 214);
            label11.Location = new Point(828, 64);
            label11.Name = "label11";
            label11.Size = new Size(115, 28);
            label11.TabIndex = 18;
            label11.Text = "Thành tiền:";
            // 
            // txt_TenHang
            // 
            txt_TenHang.Location = new Point(556, 16);
            txt_TenHang.Name = "txt_TenHang";
            txt_TenHang.ReadOnly = true;
            txt_TenHang.Size = new Size(212, 31);
            txt_TenHang.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 117, 214);
            label7.Location = new Point(30, 67);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 11;
            label7.Text = "Số lượng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 117, 214);
            label8.Location = new Point(410, 16);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 13;
            label8.Text = "Tên hàng:";
            // 
            // txt_TimMaHH
            // 
            txt_TimMaHH.Location = new Point(182, 712);
            txt_TimMaHH.Name = "txt_TimMaHH";
            txt_TimMaHH.Size = new Size(584, 31);
            txt_TimMaHH.TabIndex = 2;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TimKiem.ForeColor = Color.FromArgb(0, 117, 214);
            btn_TimKiem.Image = (Image)resources.GetObject("btn_TimKiem.Image");
            btn_TimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TimKiem.Location = new Point(783, 706);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(190, 40);
            btn_TimKiem.TabIndex = 6;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 117, 214);
            label14.Location = new Point(49, 715);
            label14.Name = "label14";
            label14.Size = new Size(127, 28);
            label14.TabIndex = 14;
            label14.Text = "Mã hoá đơn:";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 755);
            Controls.Add(label14);
            Controls.Add(btn_TimKiem);
            Controls.Add(txt_TimMaHH);
            Controls.Add(splitContainer1);
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
            ((System.ComponentModel.ISupportInitialize)dtg_OrderDetailList).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private DateTimePicker dt_NgayBan;
        private TextBox txt_MaHoaDon;
        private ComboBox cbx_EmailNhanVien;
        private TextBox txt_TenNhanVien;
        private GroupBox groupBox2;
        private ComboBox cbx_MaHang;
        private Label label6;
        private TextBox txt_SoLuong;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label7;
        private TextBox txt_ThanhTien;
        private TextBox txt_DonGia;
        private TextBox txt_TenHang;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dtg_OrderDetailList;
        private TextBox txt_TongTien;
        private Label label12;
        private Button btn_ThemHoaDon;
        private Button btn_LuuHoaDon;
        private Button btn_ThemSanPham;
        private Label label13;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txt_TimMaHH;
        private TextBox txt_TenKhachHang;
        private Label label16;
        private ComboBox cbx_SoDienThoai;
        private Label label15;
        private Button btn_InHoaDon;
        private Button btn_HuyHoaDon;
        private Button btn_Dong;
        private Button btn_TimKiem;
        private Label label14;
        private TextBox txt_GiongLoai;
        private Label label17;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
    }
}