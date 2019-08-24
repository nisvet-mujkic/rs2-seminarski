using BookDiary.Desktop.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UserManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm();
            usersForm.Show();
        }
    }
}
