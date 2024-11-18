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
    public partial class SStock : Form
    {
        public SStock()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StockH StockH = new StockH();
            StockH.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {// Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Get the values from the text boxes
                    string blood_type = comboBox1.Text.Trim();
                    string quantity = textBox1.Text.Trim();
                    string supplier_name = textBox2.Text.Trim();
                    string date_collected = dateTimePicker1.Text.Trim();
                    string expiry_date = dateTimePicker2.Text.Trim();

                    // Validation checks
                    if (string.IsNullOrEmpty(blood_type) || string.IsNullOrEmpty(quantity) ||
                        string.IsNullOrEmpty(supplier_name) || string.IsNullOrEmpty(date_collected) ||
                        string.IsNullOrEmpty(expiry_date))
                    {
                        MessageBox.Show("All fields must be filled.");
                        return;
                    }

                    // Validate that quantity is a positive number
                    if (!int.TryParse(quantity, out int quantityValue) || quantityValue <= 0)
                    {
                        MessageBox.Show("Quantity must be a positive integer.");
                        return;
                    }

                    conn.Open();

                    // SQL query with parameters
                    string query = "INSERT INTO supply_stock (blood_type, quantity, supplier_name, date_collected, expiry_date) " +
                                   "VALUES (@blood_type, @quantity, @supplier_name, @date_collected, @expiry_date)";

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values
                        sqlCommand.Parameters.AddWithValue("@blood_type", blood_type);
                        sqlCommand.Parameters.AddWithValue("@quantity", quantityValue);
                        sqlCommand.Parameters.AddWithValue("@supplier_name", supplier_name);
                        sqlCommand.Parameters.AddWithValue("@date_collected", date_collected);
                        sqlCommand.Parameters.AddWithValue("@expiry_date", expiry_date);

                        // Execute the query
                        sqlCommand.ExecuteNonQuery();

                        // Clear input fields
                        textBox1.Clear();
                        textBox2.Clear();
                        comboBox1.SelectedIndex = -1; // Clear ComboBox selection
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            // Get the values from the text boxes
            string blood_type = comboBox1.Text;
            string quantity = textBox1.Text;
            string supplier_name = textBox2.Text;
            string date_collected = dateTimePicker1.Text;
            string expiry_date = dateTimePicker2.Text;

            // Check if userId is provided
            if (string.IsNullOrEmpty(supplier_name))
            {
                MessageBox.Show("Please provide a supplier_names.");
                return;
            }

            // SQL query with parameters for updating user data
            string query = @"
        UPDATE supply_stock 
        SET blood_type=@blood_type,
            quantity=@quantity,
            supplier_name=@supplier_name,
          date_collected=@date_collected,
           expiry_date=@expiry_date
        WHERE supplier_name= @supplier_name"; // Assuming 'user_id' is the primary key

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
                        sqlCommand.Parameters.AddWithValue("@supplier_name", supplier_name);
                        sqlCommand.Parameters.AddWithValue("@date_collected", date_collected);
                        sqlCommand.Parameters.AddWithValue("@expiry_date", expiry_date);

                        textBox1.Clear();
                        textBox2.Clear();
                        comboBox1.Text = string.Empty;
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
            comboBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;


            // Reset the DateTimePicker to the current date
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
