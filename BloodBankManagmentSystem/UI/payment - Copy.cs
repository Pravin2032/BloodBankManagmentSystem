using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using CrystalDecisions.Shared;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Org.BouncyCastle.Asn1.Crmf;
using PdfiumViewer;

namespace BloodBankManagmentSystem.UI
{
    public partial class payment : Form
    {
        private object command;

        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            Phistory phistory  = new Phistory();
            phistory.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Updated connection string with TrustServerCertificate
            string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Get the values from the text boxes
                    string supplierName = textBoxSupplierName.Text.Trim();
                    string bloodType = comboBoxBloodType.Text.Trim();
                    string contact = textBoxContact.Text.Trim();
                    string recipientName = textBoxRName.Text.Trim();
                    string transactionDate = dateTimePickerTDate.Text.Trim();
                    string amount = textBoxAmount.Text.Trim();

                    // Validation checks
                    if (string.IsNullOrEmpty(supplierName) || string.IsNullOrEmpty(bloodType) || string.IsNullOrEmpty(contact) ||
                        string.IsNullOrEmpty(recipientName) || string.IsNullOrEmpty(transactionDate) || string.IsNullOrEmpty(amount))
                    {
                        MessageBox.Show("All fields must be filled.");
                        return;
                    }

                    if (!decimal.TryParse(amount, out decimal parsedAmount) || parsedAmount <= 0)
                    {
                        MessageBox.Show("Amount must be a valid positive number.");
                        return;
                    }

                    conn.Open();

                    // SQL query with parameters
                    string query = "INSERT INTO BloodTransactions (SupplierName, BloodType, Contact, RecipientName, TransactionDate, Amount) " +
                                   "VALUES (@SupplierName, @BloodType, @Contact, @RecipientName, @TransactionDate, @Amount)";

                    // Create and configure the SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Add parameters with actual values
                        sqlCommand.Parameters.AddWithValue("@SupplierName", supplierName);
                        sqlCommand.Parameters.AddWithValue("@BloodType", bloodType);
                        sqlCommand.Parameters.AddWithValue("@Contact", contact);
                        sqlCommand.Parameters.AddWithValue("@RecipientName", recipientName);
                        sqlCommand.Parameters.AddWithValue("@TransactionDate", transactionDate);
                        sqlCommand.Parameters.AddWithValue("@Amount", parsedAmount); // Use parsed decimal for amount

                        // Execute the query
                        sqlCommand.ExecuteNonQuery();
                    }

                    // Clear the input fields after successful insertion
                    textBoxSupplierName.Clear();
                    textBoxContact.Clear();
                    textBoxRName.Clear();
                    textBoxAmount.Clear();
                    comboBoxBloodType.SelectedIndex = -1; // Clear combo box selection
                    dateTimePickerTDate.Value = DateTime.Now; // Reset date picker to the current date

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
            textBoxSupplierName.Text = string.Empty;
            comboBoxBloodType.Text = string.Empty;
            textBoxContact.Text = string.Empty;
            textBoxRName.Text = string.Empty;
            textBoxAmount.Text = string.Empty;

            // Reset the DateTimePicker to the current date
            dateTimePickerTDate.Value = DateTime.Now;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }
        private List<string> SplitAddress(string address, int maxLineLength)
        {
            var lines = new List<string>();
            while (address.Length > maxLineLength)
            {
                int lastSpaceIndex = address.LastIndexOf(' ', maxLineLength);
                if (lastSpaceIndex < 0) lastSpaceIndex = maxLineLength;

                lines.Add(address.Substring(0, lastSpaceIndex).Trim());
                address = address.Substring(lastSpaceIndex).Trim();
            }
            if (!string.IsNullOrEmpty(address))
            {
                lines.Add(address);
            }

            return lines;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
