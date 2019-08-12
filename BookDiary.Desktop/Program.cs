using BookDiary.Desktop.Books;
using BookDiary.Desktop.Reviews;
using BookDiary.Desktop.Users;
using System;
using System.Windows.Forms;

namespace BookDiary.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UsersForm());
        }
    }
}
