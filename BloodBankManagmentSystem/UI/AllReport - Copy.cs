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
    public partial class AllReport : Form
    {
        public AllReport()
        {
            InitializeComponent();
        }

        private void labelAllReports_Click(object sender, EventArgs e)
        {

        }

        private void AllReport_Load(object sender, EventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            UserReports userReports = new UserReports();
            userReports.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDonors_Click(object sender, EventArgs e)
        {
            DonorReport donorReport = new DonorReport();    
            donorReport.Show();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            SupplierReport supplierReport = new SupplierReport();
            supplierReport.Show();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            PaymentReport paymentReport = new PaymentReport();
            paymentReport.Show();
        }

        private void buttonBloodRequest_Click(object sender, EventArgs e)
        {
            BloodRequestReport bloodRequestReport = new BloodRequestReport();
            bloodRequestReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BStockDonor bStockDonor = new BStockDonor();
                bStockDonor.Show();
        }

        private void buttonBloodStock_Click(object sender, EventArgs e)
        {
            BStockSupplier bStockSupplier = new BStockSupplier();
            bStockSupplier.Show();
        }
    }
}
