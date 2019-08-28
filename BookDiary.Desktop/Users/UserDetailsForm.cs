using BookDiary.Desktop.Properties;
using BookDiary.Model.Requests.UserRoles;
using BookDiary.Model.Requests.Users;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookDiary.Desktop.Users
{
    public partial class UserDetailsForm : Form
    {
        private readonly ApiService _usersService = new ApiService("Users");
        private readonly ApiService _rolesService = new ApiService("Roles");
        private readonly ApiService _userRolesService = new ApiService("UserRoles");
        private int? _userId = null;
        public UserDetailsForm(int? userId = null)
        {
            InitializeComponent();
            _userId = userId;
        }

        private async void UserDetailsForm_Load(object sender, System.EventArgs e)
        {
            var roles = await _rolesService.Get<List<Model.Models.Role>>(null);
            rolesCheckBoxList.DataSource = roles;
            rolesCheckBoxList.DisplayMember = "Name";

            if (_userId.HasValue)
            {
                var entity = await _usersService.GetById<Model.Models.User>(_userId);
                firstNameTextBox.Text = entity.FirstName;
                lastNameTextBox.Text = entity.LastName;
                emailTextBox.Text = entity.Email;
                usernameTextBox.Text = entity.Username;
                userDisabledCheckBox.Checked = entity.Archived;

                var searchRequest = new UserRolesSearchRequest()
                {
                    IsUsersLoadingEnabled = true,
                    IsRolesLoadingEnabled = true,
                    UserId = _userId.Value
                };

                //var userRoles = await _userRolesService.Get<List<Model.Models.UserRole>>(searchRequest);

                //roles.ForEach((role) =>
                //{
                //    if (userRoles.Any(x => x.RoleId == role.Id))
                //        rolesCheckBoxList.SetItemChecked(roles.IndexOf(role), true);
                //    else
                //        rolesCheckBoxList.SetItemChecked(roles.IndexOf(role), false);
                //});
            }
        }

        private void FirstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                e.Cancel = true;
                userDetailsErrorProvider.SetError(firstNameTextBox, Resources.Validation_RequiredField);
            }
            else
            {
                userDetailsErrorProvider.SetError(firstNameTextBox, null);
            }
        }

        private void LastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                e.Cancel = true;
                userDetailsErrorProvider.SetError(lastNameTextBox, Resources.Validation_RequiredField);
            }
            else
            {
                userDetailsErrorProvider.SetError(lastNameTextBox, null);
            }
        }

        private void UsernameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                e.Cancel = true;
                userDetailsErrorProvider.SetError(usernameTextBox, Resources.Validation_RequiredField);
            }
            else
            {
                userDetailsErrorProvider.SetError(usernameTextBox, null);
            }
        }

        private async void AddUserBtn_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            var userRoles = rolesCheckBoxList.CheckedItems.Cast<Model.Models.Role>().Select(role => role.Id).ToList();

            var request = new UsersUpsertRequest()
            {
                Archived = userDisabledCheckBox.Checked,
                ConfirmPassword = confirmPasswordTextBox.Text,
                Password = passwordTextBox.Text,
                Email = emailTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Roles = userRoles,
                Username = usernameTextBox.Text
            };

            Model.Models.User userEntity = null;

            if (!_userId.HasValue)
                userEntity = await _usersService.Insert<Model.Models.User>(request);
            else
                userEntity = await _usersService.Update<Model.Models.User>(_userId.Value, request);

            if (userEntity != null)
            {
                MessageBox.Show("Opration successfull!");
                this.Close();
            }
        }

        private void PasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                e.Cancel = true;
                userDetailsErrorProvider.SetError(passwordTextBox, Resources.Validation_RequiredField);
            }
            else
            {
                userDetailsErrorProvider.SetError(passwordTextBox, null);
            }
        }

        private void ConfirmPasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                e.Cancel = true;
                userDetailsErrorProvider.SetError(confirmPasswordTextBox, Resources.Validation_RequiredField);
            }
            else
            {
                if(passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    e.Cancel = true;
                    userDetailsErrorProvider.SetError(confirmPasswordTextBox, "Passwords do not match");
                }
                else
                {
                    userDetailsErrorProvider.SetError(confirmPasswordTextBox, null);
                }
            }
        }
    }
}
