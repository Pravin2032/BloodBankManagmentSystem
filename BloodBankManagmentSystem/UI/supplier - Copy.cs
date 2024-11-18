using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BloodBankManagmentSystem.UI
{
    public partial class supplier : Form
    {

    
        public supplier()
        {
            InitializeComponent();
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
                    // Get the values from the text boxes
                    string supplier_name = textBoxSupplierName.Text.Trim();
                    string contact = textBoxContact.Text.Trim();
                    string email = textBoxEmail.Text.Trim();
                    string blood_type = comboBoxBloodType.Text.Trim();
                    string quantity = textBoxQuantity.Text.Trim();
                    string date = dateTimePickerDate.Text.Trim();
                    string address = textBoxAddress.Text.Trim();

                    // Validation checks
                    if (string.IsNullOrEmpty(supplier_name) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(email) ||
                        string.IsNullOrEmpty(blood_type) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(date) ||
                        string.IsNullOrEmpty(address))
                    {
                        MessageBox.Show("All fields must be filled.");
                        return;
                    }

                    if (!int.TryParse(quantity, out int parsedQuantity) || parsedQuantity <= 0)
                    {
                        MessageBox.Show("Quantity must be a valid positive integer.");
                        return;
                    }

                    if (!email.Contains("@") || !email.Contains("."))
                    {
                        MessageBox.Show("Please enter a valid email address.");
                        return;
                    }

                    conn.Open();

                    // SQL query with parameters
                    string query = "INSERT INTO Suppliers(supplier_name, contact, email, blood_type, quantity, date, address) " +
                                   "VALUES(@supplier_name, @contact, @email, @blood_type, @quantity, @date, @address)";

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values
                        sqlCommand.Parameters.AddWithValue("@supplier_name", supplier_name);
                        sqlCommand.Parameters.AddWithValue("@contact", contact);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@blood_type", blood_type);
                        sqlCommand.Parameters.AddWithValue("@quantity", parsedQuantity); // Use parsed integer for quantity
                        sqlCommand.Parameters.AddWithValue("@date", date);
                        sqlCommand.Parameters.AddWithValue("@address", address);

                        // Execute the query
                        sqlCommand.ExecuteNonQuery();
                    }

                    // Clear the input fields after successful operation
                    textBoxSupplierName.Clear();
                    textBoxContact.Clear();
                    textBoxEmail.Clear();
                    comboBoxBloodType.SelectedIndex = -1; // Clear combo box selection
                    textBoxQuantity.Clear();
                    dateTimePickerDate.Value = DateTime.Now; // Reset date picker to current date
                    textBoxAddress.Clear();

                    // Notify user of successful operation
                    MessageBox.Show("Data Saved Successfully.");
                }
                catch (Exception ex)
                {
                    // Handle exceptions and display an error message
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

        }


        private void supplier_Load(object sender, EventArgs e)
            {
           
            }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            Shistory shistory = new Shistory();
             shistory.ShowDialog();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
            textBoxSupplierName.Text = string.Empty;
            textBoxContact.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            comboBoxBloodType.Text = string.Empty;
            textBoxQuantity.Text = string.Empty;
            textBoxAddress.Text = string.Empty;


            // Reset the DateTimePicker to the current date
           dateTimePickerDate.Value = DateTime.Now;
           
        }

        private void supplier_Load_1(object sender, EventArgs e)
        {

        }
    }
    }

