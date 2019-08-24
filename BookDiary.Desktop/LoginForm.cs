using System;
using System.Windows.Forms;

namespace BookDiary.Desktop
{
    public partial class LoginForm : Form
    {
        private readonly ApiService _usersService = new ApiService("Users");
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, System.EventArgs e)
        {
            ApiService.Username = usernameTxt.Text;
            ApiService.Password = passwordTxt.Text;

            try
            {
                var user = await _usersService.Get<dynamic>(null);
                var mainForm = new MainForm();
                mainForm.Show();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
