
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
//using Microsoft.Data.SqlClient;


namespace BloodBankManagmentSystem.UI
{
    public partial class formUsers : Form
    {
        String ConnectionString = fromlogin.ConnectionString;
        public formUsers()
        {
            InitializeComponent();
        }



        public object Messagebox { get; private set; }
        public object Me { get; private set; }

        private void labelUserId_Click(object sender, EventArgs e)
        {


        }
        void LoadExistingData() {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM blood_users";
                using (SqlDataAdapter db = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    db.Fill(dt);
                    dataGridViewUsers.DataSource = dt;
                }
            }
        }
        private void formUsers_Load(object sender, EventArgs e)
        {
            LoadExistingData();
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
            // Updated connection string with TrustServerCertificate



            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Get the values from the text boxes
                    string user_name = textBoxUsername.Text.Trim();
                    string email = textBoxEmail.Text.Trim();
                    string password = textBoxPassword.Text.Trim();
                    string full_name = textBoxFullName.Text.Trim();
                    string contact = textBoxContact.Text.Trim();
                    string address = textBoxAddress.Text.Trim();

                    // Validation checks
                    if (string.IsNullOrEmpty(user_name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                        string.IsNullOrEmpty(full_name) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address))
                    {
                        MessageBox.Show("All fields must be filled.");
                        return;
                    }

                    if (!email.EndsWith("@gmail.com"))
                    {
                        MessageBox.Show("Email must be a valid Gmail address (e.g., user@gmail.com).");
                        return;
                    }

                    conn.Open();

                    // SQL query with parameters
                    string query = "INSERT INTO blood_users(user_name, email, password, full_name, contact, address) VALUES (@user_name, @email, @password, @full_name, @contact, @address)";

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values
                        sqlCommand.Parameters.AddWithValue("@user_name", user_name);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@password", password);
                        sqlCommand.Parameters.AddWithValue("@full_name", full_name);
                        sqlCommand.Parameters.AddWithValue("@contact", contact);
                        sqlCommand.Parameters.AddWithValue("@address", address);

                        // Execute the query
                        sqlCommand.ExecuteNonQuery();

                        // Clear the text boxes after successful insertion
                        textBoxFullName.Clear();
                        textBoxAddress.Clear();
                        textBoxContact.Clear();
                        textBoxEmail.Clear();
                        textBoxPassword.Clear();
                        textBoxUsername.Clear();
                    }

                    // Notify user of successful operation
                    MessageBox.Show("Data Saved Successfully...");
                    LoadExistingData();
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., show an error message)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }


        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            // Get the values from the text boxes

            string userName = textBoxUsername.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string fullName = textBoxFullName.Text;
            string contact = textBoxContact.Text;
            string address = textBoxAddress.Text;

            // Check if userId is provided
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please provide a User ID.");
                return;
            }

            // SQL query with parameters for updating user data
            string query = @"
        UPDATE blood_users 
        SET user_name = @user_name, 
            email = @email, 
            password = @password, 
            full_name = @full_name, 
            contact = @contact, 
            address = @address 
        WHERE user_name= @user_name"; // Assuming 'user_id' is the primary key

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values

                        sqlCommand.Parameters.AddWithValue("@user_name", userName);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@password", password);
                        sqlCommand.Parameters.AddWithValue("@full_name", fullName);
                        sqlCommand.Parameters.AddWithValue("@contact", contact);
                        sqlCommand.Parameters.AddWithValue("@address", address);

                        // Execute the query
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        textBoxFullName.Clear();
                        textBoxAddress.Clear();
                        textBoxContact.Clear();
                        textBoxEmail.Clear();
                        textBoxPassword.Clear();
                        textBoxUsername.Clear();

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            // Get the user ID from the text box
            string user_name = textBoxUsername.Text;

            // Check if userId is provided
            if (string.IsNullOrEmpty(user_name))
            {
                MessageBox.Show("Please provide a User Name.");
                return;
            }

            // SQL query with parameter for deleting user data
            string query = "DELETE FROM blood_users WHERE user_name = @user_name"; // Assuming 'user_id' is the primary key

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameter with actual value
                        sqlCommand.Parameters.AddWithValue("@user_name", user_name);

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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void buttonUSearch_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM blood_users WHERE user_name = @user_name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Replace 'yourTextBox' with the actual textbox control name where the first name is entered
                    cmd.Parameters.AddWithValue("@user_name", textBoxSearchUser.Text);

                    try
                    {
                        conn.Open();

                        // Execute the query and load the results into a DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Bind the DataTable to the DataGridView
                            dataGridViewUsers.DataSource = dt;
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



   

