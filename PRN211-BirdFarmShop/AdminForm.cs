using BFShopBussinessObjects.Entities;
using BFShopService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_BirdFarmShop
{
    public partial class AdminForm : Form
    {
        private IAccountService accountService = null;
        private IRoleService roleService = null;
        public AdminForm()
        {
            InitializeComponent();
            accountService = new AccountService();
            roleService = new RoleService();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dtg_Account.DataSource = accountService.GetAccounts();
            cbx_Role.DataSource = roleService.GetRoles();
            cbx_Role.DisplayMember = "RoleDesc";
            cbx_Role.ValueMember = "RoleId";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            string password = txt_Password.Text;
            string fullname = txt_FullName.Text;
            string street = txt_Street.Text;
            string city = txt_City.Text;
            string phone = new string(mtb_Phone.Text.Where(char.IsDigit).ToArray());
            string birthday = dt_Birthday.Value.ToShortDateString();
            string gender = txt_Gender.Text;

            // Get the selected role from cbx_Role
            Role selectedRole = (Role)cbx_Role.SelectedItem;

            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(street) ||
                string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(birthday) || selectedRole == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
                return;
            }

            // Check if birthday is valid
            DateTime birthdayDate;
            if (!DateTime.TryParse(birthday, out birthdayDate))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng kiểm tra lại !");
                return;
            }

            // Check if phone number is valid
            if (phone.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại !");
                return;
            }

            IAccountService accountService = new AccountService();

            if (accountService.GetAccount(email) == null)
            {
                Account newAccount = new Account
                {
                    Email = email,
                    Password = password,
                    Fullname = fullname,
                    Street = street,
                    City = city,
                    Phone = phone,
                    Birthday = birthdayDate, // Assign the parsed DateTime value
                    Gender = gender,
                    RoleId = selectedRole.RoleId
                };

                bool success = accountService.Create(newAccount);

                if (success)
                {
                    MessageBox.Show("Tài khoản được tạo thành công.");

                    // Update the DataGridView's data source
                    dtg_Account.DataSource = accountService.GetAccounts();
                }
                else
                {
                    MessageBox.Show("Lỗi tạo tài khoản. Vui lòng thử lại !");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản email này đã tồn tại !");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            string password = txt_Password.Text;
            string fullname = txt_FullName.Text;
            string street = txt_Street.Text;
            string city = txt_City.Text;
            string phone = new string(mtb_Phone.Text.Where(char.IsDigit).ToArray());
            string birthday = dt_Birthday.Value.ToString("yyyy-MM-dd");
            string gender = txt_Gender.Text;

            Role selectedRole = (Role)cbx_Role.SelectedItem;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(street) ||
                string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(birthday) || selectedRole == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
                return;
            }

            DateTime birthdayDate;
            bool isBirthdayValid = DateTime.TryParse(birthday, out birthdayDate);

            if (!isBirthdayValid)
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng kiểm tra lại !");
                return;
            }

            if (phone.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại !");
                return;
            }

            IAccountService accountService = new AccountService();

            Account existingAccount = accountService.GetAccount(email);

            if (existingAccount != null)
            {
                existingAccount.Password = password;
                existingAccount.Fullname = fullname;
                existingAccount.Street = street;
                existingAccount.City = city;
                existingAccount.Phone = phone;

                // Thêm vào phần cập nhật ngày sinh
                existingAccount.Birthday = isBirthdayValid ? birthdayDate : existingAccount.Birthday;

                existingAccount.Gender = gender;
                existingAccount.RoleId = selectedRole.RoleId;

                bool success = accountService.Update(email, existingAccount); // Pass email and updated account

                if (success)
                {
                    MessageBox.Show("Thông tin tài khoản đã được cập nhật.");
                    dtg_Account.DataSource = accountService.GetAccounts();
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật thông tin tài khoản. Vui lòng thử lại !");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản email này không tồn tại !");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email để xóa tài khoản !");
                return;
            }

            IAccountService accountService = new AccountService();

            Account existingAccount = accountService.GetAccount(email);

            if (existingAccount != null)
            {
                bool success = accountService.Delete(email);

                if (success)
                {
                    MessageBox.Show("Tài khoản đã được xóa thành công.");
                    dtg_Account.DataSource = accountService.GetAccounts();
                }
                else
                {
                    MessageBox.Show("Lỗi xóa tài khoản. Vui lòng thử lại !");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản email này không tồn tại !");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_Search.Text;

            IAccountService accountService = new AccountService();

            List<Account> searchResults = accountService.SearchAccount(searchValue);

            if (searchResults != null && searchResults.Any())
            {
                // Gán kết quả tìm kiếm làm nguồn dữ liệu cho DataGridView
                dtg_Account.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản phù hợp !");
            }
        }
    }
}
