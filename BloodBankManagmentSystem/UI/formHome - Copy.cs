using BloodBankManagmentSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagmentSystem
{
    public partial class FormHome : Form
    {
        String userFullName;
        public FormHome(String userFullName)
        {
            InitializeComponent();
            this.userFullName = userFullName;
        }
       

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LabelOPositiveCount_Click(object sender, EventArgs e)
        {

        }

        private void LabelONegativecount_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //code to close this application
           this.Close();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open users form 
           

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DonersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void usersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            formUsers user= new formUsers();
            user.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Donors donors = new Donors();
            donors.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

            Donors donors = new Donors();
            donors.Show();
        }

        private void buttonBloodStock_Click(object sender, EventArgs e)
        {
           BloodStock1 bloodStock1      = new BloodStock1();
            bloodStock1.Show();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {

            supplier supplier = new supplier();
            supplier.Show();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            payment payment     = new payment();
           
            payment.Show();
        }

        private void buttonBloodRequest_Click(object sender, EventArgs e)
        {
            Blood_Request bloodRequest = new Blood_Request();
            bloodRequest.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LogOut Succesfull");
            this.Hide();
            
            fromlogin fromlogin = new fromlogin();
            fromlogin.Show();
            
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = userFullName;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            AllReport allReport = new AllReport();
            allReport.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
