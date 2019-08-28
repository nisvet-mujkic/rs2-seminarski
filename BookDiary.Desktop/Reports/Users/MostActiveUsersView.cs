using BookDiary.Infrastructure.Results;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookDiary.Desktop.Reports.Users
{
    public partial class MostActiveUsersView : Form
    {
        public List<MostActiveUsers> Users { get; set; } = new List<MostActiveUsers>();
        public string From { get; set; }
        public string To { get; set; }
        public MostActiveUsersView()
        {
            InitializeComponent();
        }

        private void MostActiveUsersView_Load(object sender, System.EventArgs e)
        {
            var rds = new ReportDataSource("dsUsers", Users);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
