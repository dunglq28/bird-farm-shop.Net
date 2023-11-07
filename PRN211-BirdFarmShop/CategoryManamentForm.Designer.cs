namespace PRN211_BirdFarmShop
{
    partial class CategoryManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagementForm));
            label1 = new Label();
            tb_CategoryId = new TextBox();
            tb_CategoryName = new TextBox();
            dgv_Category = new DataGridView();
            tb_Search = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_Add = new Button();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_Reset = new Button();
            btn_Close = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_Category).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(234, 18);
            label1.Name = "label1";
            label1.Size = new Size(246, 30);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC LOẠI CHIM";
            // 
            // tb_CategoryId
            // 
            tb_CategoryId.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tb_CategoryId.Location = new Point(90, 76);
            tb_CategoryId.Name = "tb_CategoryId";
            tb_CategoryId.PlaceholderText = "Mã chất liệu";
            tb_CategoryId.Size = new Size(269, 30);
            tb_CategoryId.TabIndex = 10;
            // 
            // tb_CategoryName
            // 
            tb_CategoryName.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tb_CategoryName.Location = new Point(90, 134);
            tb_CategoryName.Name = "tb_CategoryName";
            tb_CategoryName.PlaceholderText = "Tên chất liệu";
            tb_CategoryName.Size = new Size(269, 30);
            tb_CategoryName.TabIndex = 11;
            // 
            // dgv_Category
            // 
            dgv_Category.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Category.BackgroundColor = SystemColors.GradientActiveCaption;
            dgv_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Category.Location = new Point(27, 181);
            dgv_Category.Name = "dgv_Category";
            dgv_Category.RowTemplate.Height = 25;
            dgv_Category.Size = new Size(669, 236);
            dgv_Category.TabIndex = 12;
            dgv_Category.CellClick += dgv_Category_CellClick;
            // 
            // tb_Search
            // 
            tb_Search.AllowDrop = true;
            tb_Search.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Search.Location = new Point(518, 134);
            tb_Search.Name = "tb_Search";
            tb_Search.PlaceholderText = "Tìm kiếm...";
            tb_Search.Size = new Size(178, 31);
            tb_Search.TabIndex = 13;
            tb_Search.TextChanged += tb_Search_TextChanged;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(663, 134);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 27;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(27, 76);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(57, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.WhiteSmoke;
            btn_Add.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.Image = (Image)resources.GetObject("btn_Add.Image");
            btn_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add.Location = new Point(27, 441);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(108, 45);
            btn_Add.TabIndex = 30;
            btn_Add.Text = "Thêm";
            btn_Add.TextAlign = ContentAlignment.MiddleRight;
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.WhiteSmoke;
            btn_Delete.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.Image = (Image)resources.GetObject("btn_Delete.Image");
            btn_Delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Delete.Location = new Point(164, 441);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(108, 45);
            btn_Delete.TabIndex = 31;
            btn_Delete.Text = "Xóa";
            btn_Delete.TextAlign = ContentAlignment.MiddleRight;
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.WhiteSmoke;
            btn_Update.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Image = (Image)resources.GetObject("btn_Update.Image");
            btn_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Update.Location = new Point(304, 441);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(108, 45);
            btn_Update.TabIndex = 32;
            btn_Update.Text = "Sửa";
            btn_Update.TextAlign = ContentAlignment.MiddleRight;
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.WhiteSmoke;
            btn_Reset.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Reset.Image = (Image)resources.GetObject("btn_Reset.Image");
            btn_Reset.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Reset.Location = new Point(446, 441);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(113, 45);
            btn_Reset.TabIndex = 34;
            btn_Reset.Text = "Bỏ Qua";
            btn_Reset.TextAlign = ContentAlignment.MiddleRight;
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.WhiteSmoke;
            btn_Close.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
            btn_Close.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Close.Location = new Point(588, 441);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(108, 45);
            btn_Close.TabIndex = 35;
            btn_Close.Text = "Đóng";
            btn_Close.TextAlign = ContentAlignment.MiddleRight;
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.ForeColor = Color.FromArgb(0, 117, 214);
            panel1.Location = new Point(27, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 3);
            panel1.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.ForeColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(27, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 3);
            panel2.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 117, 214);
            panel3.ForeColor = Color.FromArgb(0, 117, 214);
            panel3.Location = new Point(518, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 3);
            panel3.TabIndex = 38;
            // 
            // CategoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(719, 498);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Close);
            Controls.Add(btn_Reset);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Add);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(tb_Search);
            Controls.Add(dgv_Category);
            Controls.Add(tb_CategoryName);
            Controls.Add(tb_CategoryId);
            Controls.Add(label1);
            Name = "CategoryManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Mục Loại Chim";
            Load += CategoryManagementForm_Load;
            ResizeBegin += CategoryManagementForm_ResizeBegin;
            Resize += CategoryManagementForm_Resize;
            ((System.ComponentModel.ISupportInitialize)dgv_Category).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_CategoryId;
        private TextBox tb_CategoryName;
        private DataGridView dgv_Category;
        private TextBox tb_Search;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Button btn_Add;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Reset;
        private Button btn_Close;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}