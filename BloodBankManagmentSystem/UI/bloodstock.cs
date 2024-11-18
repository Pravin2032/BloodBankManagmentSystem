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
    public partial class bloodstock : Form
    {
        public bloodstock()
        {
            InitializeComponent();
        }

        private void labelBloodType_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Get the values from the input fields
                    string blood_type = comboBox1.Text.Trim();
                    string quantity = textBox1.Text.Trim();
                    string donor_name = textBox2.Text.Trim();
                    string date_collected = dateTimePicker1.Text.Trim();
                    string expiry_date = dateTimePicker2.Text.Trim();

                    // Validation checks
                    if (string.IsNullOrEmpty(blood_type) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(donor_name) ||
                        string.IsNullOrEmpty(date_collected) || string.IsNullOrEmpty(expiry_date))
                    {
                        MessageBox.Show("All fields must be filled.");
                        return;
                    }

                    if (!int.TryParse(quantity, out int parsedQuantity) || parsedQuantity <= 0)
                    {
                        MessageBox.Show("Quantity must be a valid positive integer.");
                        return;
                    }

                    conn.Open();

                    // SQL query with parameters
                    string query = "INSERT INTO Blood_Stock (blood_type, quantity, donor_name, date_collected, expiry_date) " +
                                   "VALUES (@blood_type, @quantity, @donor_name, @date_collected, @expiry_date)";

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values
                        sqlCommand.Parameters.AddWithValue("@blood_type", blood_type);
                        sqlCommand.Parameters.AddWithValue("@quantity", parsedQuantity); // Use parsed integer for quantity
                        sqlCommand.Parameters.AddWithValue("@donor_name", donor_name);
                        sqlCommand.Parameters.AddWithValue("@date_collected", date_collected);
                        sqlCommand.Parameters.AddWithValue("@expiry_date", expiry_date);

                        // Execute the query
                        sqlCommand.ExecuteNonQuery();
                    }

                    // Notify user of successful operation
                    MessageBox.Show("Data Saved Successfully.");

                    // Clear the input fields
                    comboBox1.SelectedIndex = -1; // Clear combo box selection
                    textBox1.Clear();
                    textBox2.Clear();
                    dateTimePicker1.Value = DateTime.Now; // Reset date pickers to current date
                    dateTimePicker2.Value = DateTime.Now.AddDays(1); // Default expiry date to tomorrow
                }
                catch (Exception ex)
                {
                    // Handle exceptions and display an error message
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
            comboBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            

            // Reset the DateTimePicker to the current date
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            // Get the values from the text boxes
            string blood_type = comboBox1.Text;
            string quantity = textBox1.Text;
            string donor_name = textBox2.Text;
            string date_collected = dateTimePicker1.Text;
            string expiry_date = dateTimePicker2.Text;

            // Check if userId is provided
            if (string.IsNullOrEmpty(donor_name))
            {
                MessageBox.Show("Please provide a User ID.");
                return;
            }

            // SQL query with parameters for updating user data
            string query = @"
        UPDATE Blood_Stock 
        SET blood_type=@blood_type,
            quantity=@quantity,
            donor_name=@donor_name,
          date_collected=@date_collected,
           expiry_date=@expiry_date
        WHERE donor_name= @donor_name"; // Assuming 'user_id' is the primary key

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values
                        sqlCommand.Parameters.AddWithValue("@blood_type", blood_type);
                        sqlCommand.Parameters.AddWithValue("@quantity", quantity);
                        sqlCommand.Parameters.AddWithValue("@donor_name", donor_name);
                        sqlCommand.Parameters.AddWithValue("@date_collected", date_collected);
                        sqlCommand.Parameters.AddWithValue("@expiry_date", expiry_date);


                        // Execute the query
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

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

        private void buttonHistory_Click(object sender, EventArgs e)
        {
           DHistory DHistor = new DHistory();
            DHistor.Show();
        }
    }
}
