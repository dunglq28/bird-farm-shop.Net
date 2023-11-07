using BFShopBussinessObjects;
using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using BFShopService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRN211_BirdFarmShop
{
    public partial class StaffManagerForm : Form
    {
        private IAccountService accountService;
        public StaffManagerForm()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        public bool chkForm()
        {
            if (txtEmail.Text.Trim().Length == 0 ||
                txtFullname.Text.Trim().Length == 0 ||
                    txtCity.Text.Trim().Length == 0 ||
                txtStreet.Text.Trim().Length == 0 ||
                txtPhone.Text.Trim().Length == 0 ||
                dt_birthday.Text.Trim().Length == 0 ||
                (!radioMale.Checked && !radioMale.Checked))
            {
                return false;
            }
            return true;
        }
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

        void UpdateFont()
        {
            var colIndex = 0;
            //Change cell font
            foreach (DataGridViewColumn c in dtg_staffList.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 18F, GraphicsUnit.Pixel);
                // header font custom
                dtg_staffList.Columns[colIndex].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

                // increase column index 
                ++colIndex;
            }
        }

        /// <summary>
        /// Styling form
        /// </summary>
        void StyleDatagridview()
        {

            dtg_staffList.BorderStyle = BorderStyle.None;
            dtg_staffList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtg_staffList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_staffList.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dtg_staffList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dgv_Category.BackgroundColor = Color.FromArgb(240, 240, 240);
            dtg_staffList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dtg_staffList.EnableHeadersVisualStyles = false;
            dtg_staffList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtg_staffList.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dtg_staffList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 122, 219);
            dtg_staffList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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

            Resize_Control(bt_add, new Rectangle(bt_add.Location, bt_add.Size));

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

        public bool chkManager(String email)
        {
            Account account = accountService.GetAccount(email);
            if (account != null && account.Role.RoleDesc.Equals(Constants.IsManager))
            {
                return true;
            }
            return false;
        }

        public void FormatListStaff()
        {
            dtg_staffList.DataSource = accountService.getAllAccountByRole(Constants.IsStaff).
                     Select(staff => new
                     {
                         staff.Email,
                         staff.Fullname,
                         staff.Street,
                         staff.City,
                         staff.Phone,
                         staff.Birthday,
                         staff.Gender,
                         staff.Role.RoleDesc

                     }).ToList();
        }
        void CustomDataGridViewColumn()
        {
        }

        private void StaffManagerForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            //FormatListStaff();
            var stafflist = accountService.getAllAccountByRole(Constants.IsStaff).
                     Select(staff => new
                     {
                         staff.Email,
                         staff.Fullname,
                         staff.Street,
                         staff.City,
                         staff.Phone,
                         staff.Birthday,
                         staff.Gender,
                         staff.Role.RoleDesc
                     }).ToList();

            var bindingSource = new BindingSource();
            // set to bs datasoure <- categories
            bindingSource.DataSource = stafflist;
            dtg_staffList.DataSource = bindingSource;
            if (dtg_staffList.Columns.Count > 1)
            {
                // update to dgv datasource
                dtg_staffList.DataSource = bindingSource;
                dtg_staffList.Columns["Fullname"].HeaderText = "Họ và tên";
                dtg_staffList.Columns["Street"].HeaderText = "Đường";
                dtg_staffList.Columns["City"].HeaderText = "Thành Phố";
                dtg_staffList.Columns["Phone"].HeaderText = "SĐT";
                dtg_staffList.Columns["Street"].HeaderText = "Đường";
                dtg_staffList.Columns["Birthday"].HeaderText = "Ngày Sinh";
                dtg_staffList.Columns["Gender"].HeaderText = "Giới tính";
                dtg_staffList.Columns["RoleDesc"].HeaderText = "Chức vụ";

                dtg_staffList.Columns[0].Width = 190;
                dtg_staffList.Columns[1].Width = 190;
                dtg_staffList.Columns[2].Width = 130;
                dtg_staffList.Columns[7].Width = 70;
            }
            // custom data grid view column
            CustomDataGridViewColumn();

            // custom font
            UpdateFont();
        }

        private void dtg_staffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmail.Text = dtg_staffList.CurrentRow.Cells["Email"].Value.ToString();
            txtFullname.Text = dtg_staffList.CurrentRow.Cells["Fullname"].Value.ToString();
            txtStreet.Text = dtg_staffList.CurrentRow.Cells["Street"].Value.ToString();
            txtCity.Text = dtg_staffList.CurrentRow.Cells["City"].Value.ToString();
            txtPhone.Text = dtg_staffList.CurrentRow.Cells["Phone"].Value.ToString();
            dt_birthday.Text = dtg_staffList.CurrentRow.Cells["Birthday"].Value.ToString();
            string gender = dtg_staffList.CurrentRow.Cells["Gender"].Value.ToString();
            if (gender.ToLower() == "nam")
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtFullname.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtPhone.Clear();
            DateTime today = DateTime.Today;
            dt_birthday.Text = today.ToString();
            radioMale.Checked = true;
            radioFemale.Checked = false;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                var Email = txtEmail.Text.Trim();
                var fullname = txtFullname.Text.Trim();
                if (!chkForm())
                {
                    MessageBox.Show("Vui lòng nhập tất cả thông tin");
                    return;
                }
                // get Email by id
                var existEmail = accountService.GetAccount(Email);
                if (existEmail is not null)
                {
                    MessageBox.Show("Email này đã được nhân viên khác sử dụng");
                    return;
                }

                /// validation
                if (String.IsNullOrEmpty(fullname))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên");
                    return;
                }
                var isValidFullName = BFShopUtils.IsValidFullName(fullname);
                if (!isValidFullName)
                {
                    MessageBox.Show("Tên không chứa số");
                    return;
                }

                // address
                var isValidAddess = BFShopUtils.IsValidFullName(txtCity.Text.Trim());
                if (!isValidFullName)
                {
                    MessageBox.Show("Tên thành phố không chưa số và kí tự đặt biệt");
                    return;
                }
                // birthday
                var isValidAge = BFShopUtils.CalculateAge(DateTime.Parse(dt_birthday.Text));
                if (isValidAge < 18)
                {
                    MessageBox.Show("Tuổi của nhân viên quá nhỏ");
                    return;
                }


                Account account = new Account();
                account.Email = txtEmail.Text;
                account.Fullname = txtFullname.Text;
                account.City = txtCity.Text;
                account.Street = txtStreet.Text;
                account.RoleId = 2;
                account.Password = "123456";
                account.Birthday = DateTime.Parse(dt_birthday.Text);
                account.Phone = txtPhone.Text;
                if (radioFemale.Checked)
                {
                    account.Gender = radioFemale.Text;
                }
                else
                {
                    account.Gender = radioMale.Text;
                }
                if (account == null)
                {
                    MessageBox.Show("Đã sảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // create new category
                bool isSucess = accountService.Create(account);

                if (isSucess)
                {
                    MessageBox.Show("Tạo mới Nhân Viên thành công");

                    // reset features
                    button6_Click(sender, e);

                    // load form data
                    StaffManagerForm_Load(sender, e);

                    return;
                }

                MessageBox.Show("Tạo mới Nhân Viên thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("có lỗi sảy ra ");
            }
        }

        // only accept number in phone number
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var email = txtEmail.Text.Trim();

                // get category by id
                var existEmail = accountService.GetAccount(email);
                if (existEmail is null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên");
                    return;
                }

                // delete category by id
                accountService.Delete(email);

                // load form data
                StaffManagerForm_Load(sender, e);

                MessageBox.Show("Xóa nhân viên thành công");

                // reset features
                button6_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkForm())
                {
                    MessageBox.Show("Vui lòng nhập tất cả thông tin");
                    return;
                }
                var Email = txtEmail.Text.Trim();
                var fullname = txtFullname.Text.Trim();

                // get Email by id
                var existEmail = accountService.GetAccount(Email);
                if (existEmail is null)
                {
                    MessageBox.Show("Không tìm thấy email nhân viên này");
                    return;
                }

                /// validation
                if (String.IsNullOrEmpty(fullname))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên");
                    return;
                }
                var isValidFullName = BFShopUtils.IsValidFullName(fullname);
                if (!isValidFullName)
                {
                    MessageBox.Show("Tên không chứa số");
                    return;
                }

                // address
                var isValidAddess = BFShopUtils.IsValidFullName(txtCity.Text.Trim());
                if (!isValidFullName)
                {
                    MessageBox.Show("Tên thành phố không chưa số và kí tự đặt biệt");
                    return;
                }
                // birthday
                var isValidAge = BFShopUtils.CalculateAge(DateTime.Parse(dt_birthday.Text));
                if (isValidAge < 18)
                {
                    MessageBox.Show("Tuổi của nhân viên quá nhỏ");
                    return;
                }



                existEmail.Email = txtEmail.Text;
                existEmail.Fullname = txtFullname.Text;
                existEmail.City = txtCity.Text;
                existEmail.Street = txtStreet.Text;
                existEmail.RoleId = 2;
                existEmail.Password = "123456";
                existEmail.Birthday = DateTime.Parse(dt_birthday.Text);
                existEmail.Phone = txtPhone.Text;
                if (radioFemale.Checked)
                {
                    existEmail.Gender = radioFemale.Text;
                }
                else
                {
                    existEmail.Gender = radioMale.Text;
                }
                // create new category
                bool isSucess = accountService.Update(Email, existEmail);

                if (isSucess)
                {
                    MessageBox.Show("Cập nhật thông tin Nhân Viên thành công\n" +
                        "Nhân viên mới sẽ có Email là:" + existEmail.Email + "\n" +
                        "Mật khẩu mặc định: 123456");

                    // reset features
                    button6_Click(sender, e);

                    // load form data
                    StaffManagerForm_Load(sender, e);
                    return;
                }

                MessageBox.Show("Cập nhật thông tin Nhân Viên thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("có lỗi sảy ra " + ex.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            StyleDatagridview();
            var searchvalue = txtSearch.Text.Trim();
            var stafflist = accountService.SearchAccountInRole(searchvalue, Constants.IsStaff).
                     Select(staff => new
                     {
                         staff.Email,
                         staff.Fullname,
                         staff.Street,
                         staff.City,
                         staff.Phone,
                         staff.Birthday,
                         staff.Gender,
                         staff.Role.RoleDesc
                     }).ToList();
            var bindingSource = new BindingSource();
            // set to bs datasoure <- categories
            bindingSource.DataSource = stafflist;
            dtg_staffList.DataSource = bindingSource;
            if (dtg_staffList.Columns.Count > 1)
            {
                // update to dgv datasource
                dtg_staffList.DataSource = bindingSource;
                dtg_staffList.Columns["Fullname"].HeaderText = "Họ và tên";
                dtg_staffList.Columns["Street"].HeaderText = "Đường";
                dtg_staffList.Columns["City"].HeaderText = "Thành Phố";
                dtg_staffList.Columns["Phone"].HeaderText = "SĐT";
                dtg_staffList.Columns["Street"].HeaderText = "Đường";
                dtg_staffList.Columns["Birthday"].HeaderText = "Ngày Sinh";
                dtg_staffList.Columns["Gender"].HeaderText = "Giới tính";
                dtg_staffList.Columns["RoleDesc"].HeaderText = "Chức vụ";

                dtg_staffList.Columns[0].Width = 190;
                dtg_staffList.Columns[1].Width = 190;
                dtg_staffList.Columns[2].Width = 130;
                dtg_staffList.Columns[7].Width = 70;
            }
            // custom data grid view column
            CustomDataGridViewColumn();

            // custom font
            UpdateFont();
        }
    }
}


