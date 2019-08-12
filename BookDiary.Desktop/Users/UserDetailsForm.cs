using System.Collections.Generic;
using System.Windows.Forms;

namespace BookDiary.Desktop.Users
{
    public partial class UserDetailsForm : Form
    {
        private readonly ApiService _usersService = new ApiService("Users");
        private readonly ApiService _rolesService = new ApiService("Roles");
        private int? _userId = null;
        public UserDetailsForm(int? userId = null)
        {
            InitializeComponent();
            _userId = userId;
        }

        private async void UserDetailsForm_Load(object sender, System.EventArgs e)
        {
            var roles = await _rolesService.Get<List<Model.Models.Role>>(null);
            rolesCheckBoxList.DisplayMember = "Name";
            rolesCheckBoxList.DataSource = roles;

            if (_userId.HasValue)
            {
                var entity = await _usersService.Get<Model.Models.User>(_userId);
                firstNameTextBox.Text = entity.FirstName;
                lastNameTextBox.Text = entity.LastName;
                emailTextBox.Text = entity.Email;
                usernameTextBox.Text = entity.Username;
                userDisabledCheckBox.Checked = entity.Archived;
            }
        }
    }
}
