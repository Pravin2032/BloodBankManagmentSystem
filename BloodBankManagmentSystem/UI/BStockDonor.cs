using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.UI
{
    public partial class BStockDonor : Form
    {
        public BStockDonor()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            String userPath = "C:\\Users\\pravi\\OneDrive\\Desktop\\BloodBankManagementSystem\\BloodBankManagmentSystem\\BloodBankManagmentSystem\\UI\\BSDonor.rpt";
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load(userPath);
            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.RefreshReport();
        }
    }
}
