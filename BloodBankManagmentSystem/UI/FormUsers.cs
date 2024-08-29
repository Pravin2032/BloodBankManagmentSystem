
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BloodBankManagmentSystem.UI
{
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();
        }

      

        public object Messagebox { get; private set; }

        private void labelUserId_Click(object sender, EventArgs e)
        {
            
        
        }

        private void formUsers_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //add functionlity to close this user form
            this.Hide();
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                // Establish the connection
                string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=BloodBankManagementSystem;Integrated Security=True;Trust Server Certificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Create the query with parameters
                    string query = "INSERT INTO tbl_users (user_id, user_name, email, password, full_name, contact, address) " +
                                   "VALUES (@UserId, @UserName, @Email, @Password, @FullName, @Contact, @Address)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters with values
                        cmd.Parameters.AddWithValue("@UserId", textBoxUserId.Text);
                        cmd.Parameters.AddWithValue("@UserName", textBoxFullName.Text);
                        cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@FullName", textBoxPassword.Text);
                        cmd.Parameters.AddWithValue("@Contact", textBoxContact.Text);
                        cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the data was inserted
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Inserted");
                        }
                        else
                        {
                            MessageBox.Show("Data Insertion Failed");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display the error message
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uoadtex");
        }
    }

   
}
