using BFShopBussinessObjects;
using BFShopBussinessObjects.Entities;
using BFShopRepository;
using BFShopService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRN211_BirdFarmShop
{
    public partial class CategoryManagementForm : Form
    {
        ICategoryService _categorySerivce;
        public CategoryManagementForm()
        {
            InitializeComponent();
            _categorySerivce = new CategoryService();

            // disable update, delete btn
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
        }

        /// <summary>
        /// Get all form controls
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);

                yield return next;
            }
        }

        /// <summary>
        /// Change data grid view cells Font
        /// </summary>
        void UpdateFont()
        {
            var colIndex = 0;
            //Change cell font
            foreach (DataGridViewColumn c in dgv_Category.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 18F, GraphicsUnit.Pixel);
                // header font custom
                dgv_Category.Columns[colIndex].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

                // increase column index 
                ++colIndex;
            }
        }

        /// <summary>
        /// Styling form
        /// </summary>
        void StyleDatagridview()
        {

            dgv_Category.BorderStyle = BorderStyle.None;
            dgv_Category.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_Category.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Category.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_Category.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dgv_Category.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgv_Category.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgv_Category.EnableHeadersVisualStyles = false;
            dgv_Category.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Category.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgv_Category.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 122, 219);
            dgv_Category.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        /// <summary>
        /// resize form when shrink
        /// </summary>
        void ResizeForm()
        {
            // no smaller than design time size
            //this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            // no larger than screen size
            //this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 0);

            // get all form elements
            var controls = GetAllControls(this).OfType<Control>();
            // resize form element  
            foreach (var control in controls)
            {
                Resize_Control(control, new Rectangle(control.Location, control.Size));
            }

            Resize_Control(btn_Add, new Rectangle(btn_Add.Location, btn_Add.Size));

            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        /// <summary>
        /// Resize form controls
        /// </summary>
        /// <param name="c"></param>
        /// <param name="r"></param>
        void Resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(this.Size.Width);
            float yRatio = (float)(this.Height) / (float)(this.Size.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        /// <summary>
        /// Data Grid View column with
        /// </summary>
        void CustomDataGridViewColumn()
        {
        }

        private void CategoryManagementForm_Load(object sender, EventArgs e)
        {
            // custom form
            StyleDatagridview();


            // get all category
            var categories = _categorySerivce.GetCategories()
                                             .Select(x => new { x.CategoryId, x.CategoryName })
                                             .ToList();

            // binding source
            var bindingSource = new BindingSource();
            // set to bs datasoure <- categories
            bindingSource.DataSource = categories;

            // update to dgv datasource
            dgv_Category.DataSource = bindingSource;
            dgv_Category.Columns["CategoryId"].HeaderText = "Mã chất liệu";
            dgv_Category.Columns["CategoryName"].HeaderText = "Tên chất liệu";
            dgv_Category.Columns[0].Width = 100;
            dgv_Category.Columns[1].Width = 100;

            // custom data grid view column
            CustomDataGridViewColumn();

            // custom font
            UpdateFont();
        }

        private void CategoryManagementForm_ResizeBegin(object sender, EventArgs e)
        {
            //// resize form
            //ResizeForm();
        }

        private void CategoryManagementForm_Resize(object sender, EventArgs e)
        {
            // resize form
            ResizeForm();
        }

        private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var totalRows = dgv_Category.Rows.Count;
            if (e.RowIndex != -1
                && e.RowIndex < totalRows)
            {
                // categoryId 
                tb_CategoryId.Text = dgv_Category.Rows[e.RowIndex].Cells[0].Value.ToString();
                // categoryName
                tb_CategoryName.Text = dgv_Category.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            // hide add button
            btn_Add.Enabled = false;
            // hide categoryId
            tb_CategoryId.Enabled = false;
            // unhide btns
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            // set default features
            tb_CategoryId.Text = null!;
            tb_CategoryName.Text = null!;

            // unhide add button
            btn_Add.Enabled = true;
            // unhide categoryId
            tb_CategoryId.Enabled = true;
            // hide update,delete btn
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // category fields
                var categoryId = tb_CategoryId.Text.Trim();
                var categoryName = tb_CategoryName.Text.Trim();

                // get category by id
                var existCategory = _categorySerivce.GetCategory(Convert.ToInt32(categoryId));
                if (existCategory is not null)
                {
                    MessageBox.Show("Mã chất liệu đã tồn tại");
                    return;
                }

                /// validation
                if (String.IsNullOrEmpty(categoryName))
                {
                    MessageBox.Show("Vui lòng nhập tên chất liệu để thêm mới");
                    return;
                }
                var isValidCategoryName = BFShopUtils.IsNotNumericString(categoryName);
                if (!isValidCategoryName)
                {
                    MessageBox.Show("Tên chất liệu không chứa số");
                    return;
                }

                // generate category model
                var categoryModel = new Category
                {
                    CategoryId = Convert.ToInt32(categoryId),
                    CategoryName = categoryName
                };

                // create new category
                bool isSucess = _categorySerivce.Create(categoryModel);

                if (isSucess)
                {
                    MessageBox.Show("Tạo mới chất liệu thành công");

                    // reset features
                    btn_Reset_Click(sender, e);

                    // load form data
                    CategoryManagementForm_Load(sender, e);

                    return;
                }

                MessageBox.Show("Tạo mới chất liệu thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // category fields
                var categoryId = tb_CategoryId.Text.Trim();
                var categoryName = tb_CategoryName.Text.Trim();

                // get category by id
                var existCategory = _categorySerivce.GetCategory(Convert.ToInt32(categoryId));
                if (existCategory is null)
                {
                    MessageBox.Show("Không tìm thấy mã chất liệu");
                    return;
                }

                /// validation
                if (String.IsNullOrEmpty(categoryName))
                {
                    MessageBox.Show("Vui lòng nhập tên chất liệu để thêm mới");
                    return;
                }
                var isValidCategoryName = BFShopUtils.IsNotNumericString(categoryName);
                if (!isValidCategoryName)
                {
                    MessageBox.Show("Tên chất liệu không chứa số");
                    return;
                }

                // generate category model
                var categoryModel = new Category
                {
                    CategoryId = Convert.ToInt32(categoryId),
                    CategoryName = categoryName
                };

                // update category
                _categorySerivce.Update(Convert.ToInt32(categoryId), categoryModel);


                // reset features
                btn_Reset_Click(sender, e);

                // load form data
                CategoryManagementForm_Load(sender, e);

                MessageBox.Show("Sửa chất liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var categoryId = tb_CategoryId.Text.Trim();

                // get category by id
                var existCategory = _categorySerivce.GetCategory(Convert.ToInt32(categoryId));
                if (existCategory is null)
                {
                    MessageBox.Show("Không tìm thấy mã chất liệu");
                    return;
                }

                // delete category by id
                _categorySerivce.Delete(Convert.ToInt32(categoryId));

                // load form data
                CategoryManagementForm_Load(sender, e);

                MessageBox.Show("Xóa chất liệu thành công");

                // reset features
                btn_Reset_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            // custom form
            StyleDatagridview();

            var searchValue = tb_Search.Text.Trim();

            var categories = _categorySerivce.SearchCategory(searchValue)
                                             .Select(x => new { x.CategoryId, x.CategoryName });

            // binding source
            var bindingSource = new BindingSource();
            // set to bs datasoure <- categories
            bindingSource.DataSource = categories;

            // update to dgv datasource
            dgv_Category.DataSource = bindingSource;
            if (dgv_Category.Columns.Count > 1)
            {
                dgv_Category.Columns["CategoryId"].HeaderText = "Mã chất liệu";
                dgv_Category.Columns["CategoryName"].HeaderText = "Tên chất liệu";
                dgv_Category.Columns[0].Width = 100;
                dgv_Category.Columns[1].Width = 100;
            }

            // custom data grid view column
            CustomDataGridViewColumn();

            // custom font
            UpdateFont();
            // load form data
            //CategoryManagementForm_Load(sender, e);
        }
    }
}
