using System;
using System.Collections.Generic;
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
                var users = await _usersService.Get<List<Model.Models.User>>(null);

                SetLoggedUser(users);

                var mainForm = new MainForm();
                mainForm.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void SetLoggedUser(List<Model.Models.User> users)
        {
            users.ForEach(user =>
            {
                if (ApiService.Username == user.Username)
                {
                    Properties.Settings.Default.Username = ApiService.Username;
                    Properties.Settings.Default.UserId = user.Id;
                }
            });
        }
    }
}
