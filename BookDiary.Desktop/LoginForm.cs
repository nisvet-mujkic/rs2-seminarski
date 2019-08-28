using BookDiary.Model.Requests.UserRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop
{
    public partial class LoginForm : Form
    {
        private readonly ApiService _usersService = new ApiService("Users");
        private readonly ApiService _userRolesService = new ApiService("UserRoles");
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

        private async Task<string> GetUserRoles(Model.Models.User user)
        {
            var searchRequest = new UserRolesSearchRequest()
            {
                IsRolesLoadingEnabled = true,
                IsUsersLoadingEnabled = true,
                UserId = user.Id
            };

            var roles = await _userRolesService.Get<List<Model.Models.UserRole>>(searchRequest);
            var rolesString = roles.Select(x => x.Role.Name);
            return string.Join(", ", rolesString);
        }

        private async Task SetLoggedUser(List<Model.Models.User> users)
        {
            var storedUser = new Model.Models.User();
            users.ForEach( user =>
            {
                if (ApiService.Username == user.Username)
                {
                    storedUser = user;
                    Properties.Settings.Default.Username = ApiService.Username;
                    Properties.Settings.Default.UserId = user.Id;
                    
                }
            });

            var userRoles = await GetUserRoles(storedUser);
            Properties.Settings.Default.IsAdmin = userRoles.Contains("Admin") ? true : false;
        }
    }
}
