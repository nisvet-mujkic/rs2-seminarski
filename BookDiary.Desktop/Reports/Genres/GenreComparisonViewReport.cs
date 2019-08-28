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

namespace BookDiary.Desktop.Reports
{
    public partial class GenreComparisonViewReport : Form
    {
        public List<GenreComparison> GenreComparisonList { get; set; } = new List<GenreComparison>();
        public string Genre { get; set; }
        public GenreComparisonViewReport()
        {
            InitializeComponent();

        }

        private void GenreComparisonViewReport_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource("dsGenreComparison", GenreComparisonList);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
