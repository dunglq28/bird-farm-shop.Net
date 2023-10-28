using BFShopBussinessObjects;
using BFShopBussinessObjects.Utils;
using BFShopDAO;
using BFShopService;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PRN211_BirdFarmShop
{
    public partial class LoginForm : Form
    {
        private readonly IAccountService _accountService;
        private readonly AppSettings _appSettings;

        /// <summary>
        /// Login form constructor
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();

            // init services
            _accountService = new AccountService();

            // config appsettings
            _appSettings = BFShopUtils.ConfigureAppSettings();

            // init component
            tb_Username.Text = "admin@gmail.com";
            // password encoder
            tb_Password.Text = PasswordHelper.ConvertToDecrypt("QEFkbWluMTIz");
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            try
            {
                // get email password login
                var email = tb_Username.Text.ToString();
                var password = tb_Password.Text.ToString();

                // validation
                var isValidEmail = BFShopUtils.IsValidEmail(email);
                if (!isValidEmail)
                {
                    MessageBox.Show("Wrong email format");
                    return;
                }

                var account = _accountService.CheckLogin(email, PasswordHelper.ConvertToEncrypt(password));

                if (account is not null)
                {
                    var role = account?.Role.RoleDesc;

                    /// Remove if done TODO
                    MessageBox.Show("Login Success");

                    switch (role)
                    {
                        case Constants.IsAdmin:
                            ///TODO: Account management form
                            this.Hide();
                            break;
                        case Constants.IsManager:
                            ///TODO: Product, Order management form
                            this.Hide();
                            break;
                        case Constants.IsCustomer:
                            ///TODO: Customer form (View products, View order history, Order products, Privacy info,...)
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("You are not allow to access management app");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // hide current form
            this.Hide();
            // redirect to register form
            var registerForm = new RegisterForm();
            // show redirect form
            registerForm.Show();
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
    }
}