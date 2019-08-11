using System.Windows.Forms;

namespace BookDiary.Desktop.Users
{
    public partial class UserDetailsForm : Form
    {
        private int? _userId = null;
        public UserDetailsForm(int? userId = null)
        {
            InitializeComponent();
            _userId = userId;
        }
    }
}
