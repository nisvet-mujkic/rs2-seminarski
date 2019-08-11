using BookDiary.Model.Requests.Users;
using System;
using System.Collections.Generic;
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

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            var searchRequest = new UsersSearchRequest()
            {
                SearchTerm = searchTextBox.Text,
                ShowDisabledUsers = disabledUsersCheckBox.Checked
            };

            var userEntities = await _usersService.Get<List<Model.Models.User>>(searchRequest);
            allUsersDataGrid.AutoGenerateColumns = false;
            allUsersDataGrid.DataSource = userEntities;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            var userDetailsForm = new UserDetailsForm();
            userDetailsForm.Show();
        }
    }
}
