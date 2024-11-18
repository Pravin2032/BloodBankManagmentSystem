using System;
using System.Collections;
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
    public partial class Donors : Form
    {
        string ConnectionString = fromlogin.ConnectionString;
        public Donors()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Get the values from the text boxes
                    string first_name = textBoxFirstName.Text.Trim();
                    string last_name = textBoxLastName.Text.Trim();
                    string email = textBoxEmailD.Text.Trim();
                    string gender = comboBoxGender.Text.Trim();
                    string blood_group = comboBoxBloodGroup.Text.Trim();
                    string contact = textBoxContact.Text.Trim();
                    string address = textBoxAddress.Text.Trim();

                    // Validation checks
                    if (string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(email) ||
                        string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(blood_group) || string.IsNullOrEmpty(contact) ||
                        string.IsNullOrEmpty(address))
                    {
                        MessageBox.Show("All fields must be filled.");
                        return;
                    }

                    if (!email.Contains("@") || !email.Contains("."))
                    {
                        MessageBox.Show("Email must be a valid format (e.g., user@example.com).");
                        return;
                    }

                    conn.Open();

                    // SQL query with parameters
                    string query = "INSERT INTO m_donors(first_name, last_name, email, gender, blood_group, contact, address) " +
                                   "VALUES (@first_name, @last_name, @email, @gender, @blood_group, @contact, @address)";

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values
                        sqlCommand.Parameters.AddWithValue("@first_name", first_name);
                        sqlCommand.Parameters.AddWithValue("@last_name", last_name);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@gender", gender);
                        sqlCommand.Parameters.AddWithValue("@blood_group", blood_group);
                        sqlCommand.Parameters.AddWithValue("@contact", contact);
                        sqlCommand.Parameters.AddWithValue("@address", address);

                        // Execute the query
                        sqlCommand.ExecuteNonQuery();

                        // Clear the input fields
                        textBoxFirstName.Clear();
                        textBoxLastName.Clear();
                        textBoxEmailD.Clear();
                        textBoxAddress.Clear();
                        comboBoxBloodGroup.SelectedIndex = -1; // Clear combo box selection
                        comboBoxGender.SelectedIndex = -1;
                        textBoxContact.Clear();
                    }

                    // Notify user of successful operation
                    MessageBox.Show("Data Saved Successfully.");
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., show an error message)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            // Get the values from the text boxes

            string first_name = textBoxFirstName.Text;
            string last_name = textBoxLastName.Text;
            string email = textBoxEmailD.Text;
            string gender = comboBoxGender.Text;
            string blood_group = comboBoxBloodGroup.Text;
            string contact = textBoxContact.Text;
            string address = textBoxAddress.Text;

            // Check if userId is provided
            if (string.IsNullOrEmpty(first_name))
            {
                MessageBox.Show("Please provide a first_name.");
                return;
            }

            // SQL query with parameters for updating user data
            string query = @"
        UPDATE m_donors 
        SET first_name = @first_name,
            last_name = @last_name,
            email = @email, 
            gender = @gender,
           blood_group = @blood_group,
            contact = @contact, 
            address = @address 
        WHERE first_name= @first_name";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values

                        sqlCommand.Parameters.AddWithValue("@first_name", first_name);
                        sqlCommand.Parameters.AddWithValue("@last_name", last_name);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@gender", gender);
                        sqlCommand.Parameters.AddWithValue("@blood_group", blood_group);
                        sqlCommand.Parameters.AddWithValue("@contact", contact);
                        sqlCommand.Parameters.AddWithValue("@address", address);

                        // Execute the query
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        textBoxFirstName.Clear();
                        textBoxLastName.Clear();
                        textBoxEmailD.Clear();
                        textBoxAddress.Clear();
                        comboBoxBloodGroup.Text = string.Empty;
                        comboBoxGender.Text = string.Empty;
                        textBoxContact.Clear();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Updated Successfully...");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given User Name.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., show an error message)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        void LoadExistingData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM m_donors ";
                using (SqlDataAdapter db = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    db.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void Donors_Load(object sender, EventArgs e)
        {
            LoadExistingData();
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            // Get the user ID from the text box
            string first_name = textBoxFirstName.Text;

            // Check if userId is provided
            if (string.IsNullOrEmpty(first_name))
            {
                MessageBox.Show("Please provide a User Name.");
                return;
            }

            // SQL query with parameter for deleting user data
            string query = "DELETE FROM m_donors WHERE first_name = @first_name"; // Assuming 'user_id' is the primary key

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameter with actual value
                        sqlCommand.Parameters.AddWithValue("@first_name", first_name);

                        // Execute the query
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Deleted Successfully...");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given User name.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., show an error message)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM m_donors WHERE first_name = @first_name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Replace 'yourTextBox' with the actual textbox control name where the first name is entered
                    cmd.Parameters.AddWithValue("@first_name", textBoxSearch.Text);

                    try
                    {
                        conn.Open();

                        // Execute the query and load the results into a DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
