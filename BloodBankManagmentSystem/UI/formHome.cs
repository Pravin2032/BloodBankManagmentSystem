using BloodBankManagmentSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagmentSystem
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            formUsers users= new formUsers();
            users.Show();
          
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
    }
}
