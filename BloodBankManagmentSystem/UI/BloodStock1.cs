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
    public partial class BloodStock1 : Form
    {
        public BloodStock1()
        {
            InitializeComponent();
        }

        private void buttonDonor_Click(object sender, EventArgs e)
        {
            bloodstock bloodstock = new bloodstock();
            bloodstock.Show();            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            SStock sStock = new SStock();
            sStock.Show();
        }
    }
}
