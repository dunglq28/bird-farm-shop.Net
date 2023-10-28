using BFShopBussinessObjects;
using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using BFShopService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_BirdFarmShop
{
    public partial class RegisterForm : Form
    {
        private readonly IAccountService _accountService;
        private readonly IRoleService _roleService;
        public RegisterForm()
        {
            InitializeComponent();

            // init services
            _accountService = new AccountService();
            _roleService = new RoleService();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void lb_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            this.Dispose();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            var email = tb_Username.Text.ToString();
            var fullName = tb_Fullname.Text.ToString();
            var street = tb_Street.Text.ToString();
            var city = tb_City.Text.ToString();
            var password = tb_Password.Text.ToString();
            var confirmPass = tb_ConfirmPassword.Text.ToString();

            // check exist email
            var isExistAccount = _accountService.GetAccount(email);
            if (isExistAccount is not null)
            {
                MessageBox.Show("Email is already exist");
                return;
            }

            // validate email
            var isValidEmail = BFShopUtils.IsValidEmail(email);
            if (!isValidEmail)
            {
                MessageBox.Show("Wrong email format");
                return;
            }

            // validate fullname
            var isValidFullname = BFShopUtils.IsValidFullName(fullName);
            if (!isValidFullname)
            {
                MessageBox.Show("Fullname wrong format");
                return;
            }

            // validate password
            var isValidPassword = BFShopUtils.IsValidPassword(password);
            if (!isValidPassword)
            {
                MessageBox.Show("Password must contain at least 8 characters, 1 upper letter," +
                    " 1 digit, 1 special character, ");
                return;
            }

            // valid confirm password
            var isValidConfirm = password.Trim().Equals(confirmPass);
            if (!isValidConfirm)
            {
                MessageBox.Show("Confirm password not match");
                return;
            }

            // create new account
            bool isSucess = _accountService.Create(new Account
            {
                Email = email,
                Fullname = fullName,
                Password = PasswordHelper.ConvertToEncrypt(password),
                RoleId = _roleService.GetByDesc(Constants.IsCustomer).RoleId
            });
            if (isSucess)
            {
                MessageBox.Show("Create account successfuly");

                // hide current form
                this.Hide();
                // redirect login form
                var loginForm = new LoginForm();
                // show redirect form
                loginForm.Show();
            }
        }

        private void lb_UnhidePassword_Click(object sender, EventArgs e)
        {
            if (tb_Password.PasswordChar.Equals('*'))
            {
                tb_Password.PasswordChar = '\0';
            }
            else
            {
                tb_Password.PasswordChar = '*';
            }
        }

        private void lb_UnhideConfirmPass_Click(object sender, EventArgs e)
        {
            if (tb_ConfirmPassword.PasswordChar.Equals('*'))
            {
                tb_ConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                tb_ConfirmPassword.PasswordChar = '*';
            }
        }
    }
}
