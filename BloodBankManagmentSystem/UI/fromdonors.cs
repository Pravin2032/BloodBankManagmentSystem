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

namespace BloodBankManagmentSystem.UI
{
    public partial class fromdonors : Form
    {
        public fromdonors()
        {
            InitializeComponent();
        }

        private void fromdonors_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this .Hide();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {

            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";


            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Get the values from the text boxes

                    
                    string FullName = textBoxFullName.Text;
                    string LastName = textBoxLastName.Text;
                    string email = textBoxEmail.Text;
                    string Gender = comboBoxGender.Text;
                    string BloodGroup = comboBoxBloodGroup.Text;
                    string contact = textBoxContact.Text;
                    string address = textBoxAddress.Text;

                    // SQL query with parameters
                    string query = "INSERT INTO b_donors(FirstName, LastName, Email, Gender, BloodGroup, Contact, Address)VALUES(@FirstName, @LastName, @Email, @Gender, @BloodGroup, @Contact, @Address)";

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values

                        sqlCommand.Parameters.AddWithValue("@FullName", FullName);
                        sqlCommand.Parameters.AddWithValue("@LastName", LastName);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@Gender", Gender);
                        sqlCommand.Parameters.AddWithValue("@BloodGroup", BloodGroup);
                        sqlCommand.Parameters.AddWithValue("@contact", contact);
                        sqlCommand.Parameters.AddWithValue("@address", address);

                        // Execute the query
                        sqlCommand.ExecuteNonQuery();
                    }

                    // Notify user of successful operation
                    MessageBox.Show("Data Saved Successfully...");
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., show an error message)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

            }

        }
    }
}
