using BookDiary.Model.Requests.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop.Users
{
    public partial class UsersForm : Form
    {
        private readonly ApiService _usersService = new ApiService("Users");
        public UsersForm()
        {
            InitializeComponent();
        }

        private async void UsersForm_Load(object sender, EventArgs e)
        {
            await LoadUsers();
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            var searchRequest = new UsersSearchRequest()
            {
                SearchTerm = searchTextBox.Text,
                ShowDisabledUsers = disabledUsersCheckBox.Checked
            };

            await LoadUsers(searchRequest);
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            var userDetailsForm = new UserDetailsForm();
            userDetailsForm.Show();
        }

        private async Task LoadUsers(UsersSearchRequest request = null)
        {
            var userEntities = await _usersService.Get<List<Model.Models.User>>(request);
            allUsersDataGrid.AutoGenerateColumns = false;
            allUsersDataGrid.DataSource = userEntities;
        }

        private void AllUsersDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var userId = int.Parse(allUsersDataGrid.SelectedRows[0].Cells[0].Value.ToString());

            var userDetailsForm = new UserDetailsForm(userId);
            userDetailsForm.Show();
        }
    }
}
