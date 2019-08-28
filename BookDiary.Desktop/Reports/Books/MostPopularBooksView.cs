using BookDiary.Infrastructure.Results;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop.Reports.Books
{
    public partial class MostPopularBooksView : Form
    {
        public List<MostPopularBook> Books { get; set; } = new List<MostPopularBook>();
        public MostPopularBooksView()
        {
            InitializeComponent();
        }

        private void MostPopularBooksView_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource("dsBooks", Books);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
