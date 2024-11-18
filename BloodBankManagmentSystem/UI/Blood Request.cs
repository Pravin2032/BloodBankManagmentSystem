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
    public partial class Blood_Request : Form
    {
        public Blood_Request()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            BRequestHistory bRequestHistory = new BRequestHistory();
            bRequestHistory.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Connection string with TrustServerCertificate
            string connectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Get the values from the text boxes
                    string requestorName = textBoxRequestorName.Text.Trim();
                    string contact = textBoxContact.Text.Trim();
                    string bloodType = comboBoxBloodType.Text.Trim();
                    string quantity = textBoxQuentity.Text.Trim(); // Ensure this is an integer
                    string date = dateTimePickerDataOfRequest.Text.Trim(); // Use DateTimePicker for the date
                    string reasonOfRequest = textBoxReasonOfRequest.Text.Trim();

                    // Validation checks
                    if (string.IsNullOrEmpty(requestorName) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(bloodType) ||
                        string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(reasonOfRequest))
                    {
                        MessageBox.Show("All fields must be filled.");
                        return;
                    }

                    if (!int.TryParse(quantity, out int parsedQuantity) || parsedQuantity <= 0)
                    {
                        MessageBox.Show("Quantity must be a positive integer.");
                        return;
                    }

                    conn.Open();

                    // SQL query with parameters
                    string query = "INSERT INTO bl_request (Requestor_Name, Contact, Blood_Type, Quantity, Date, Reason_of_Request) " +
                                   "VALUES (@requestorName, @contact, @bloodType, @quantity, @date, @reasonOfRequest)";

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values
                        sqlCommand.Parameters.AddWithValue("@requestorName", requestorName);
                        sqlCommand.Parameters.AddWithValue("@contact", contact);
                        sqlCommand.Parameters.AddWithValue("@bloodType", bloodType);
                        sqlCommand.Parameters.AddWithValue("@quantity", parsedQuantity); // Use parsed quantity
                        sqlCommand.Parameters.AddWithValue("@date", date);
                        sqlCommand.Parameters.AddWithValue("@reasonOfRequest", reasonOfRequest);

                        // Execute the query
                        sqlCommand.ExecuteNonQuery();
                    }

                    // Notify user of successful operation
                    MessageBox.Show("Data Saved Successfully.");

                    // Clear the input fields
                    textBoxRequestorName.Clear();
                    textBoxContact.Clear();
                    comboBoxBloodType.SelectedIndex = -1; // Clear combo box selection
                    textBoxQuentity.Clear();
                    textBoxReasonOfRequest.Clear();
                    dateTimePickerDataOfRequest.Value = DateTime.Now; // Reset the date picker to the current date
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., show an error message)
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
          textBoxRequestorName.Text = string.Empty;
            textBoxContact.Text = string.Empty;
            textBoxQuentity.Text    = string.Empty;
            textBoxReasonOfRequest.Text = string.Empty;
            comboBoxBloodType.Text = string.Empty;


            // Reset the DateTimePicker to the current date
            dateTimePickerDataOfRequest.Value = DateTime.Now;
        }

        private void Blood_Request_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDataOfRequest_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hos hos     = new Hos();
            hos.Show();
                
        }
    }
    }

