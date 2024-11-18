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
    public partial class DHistory : Form
    {
        string ConnectionString = fromlogin.ConnectionString;
        public DHistory()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadExistingData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Blood_Stock ";
                using (SqlDataAdapter db = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    db.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
       

        private void DHistory_Load(object sender, EventArgs e)
        {
            LoadExistingData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(ConnectionString))
            //{
            //    string query = "SELECT * FROM Blood_Stock WHERE donor_name = @donor_name ,blood_type=@blood_type ";

            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        // Replace 'yourTextBox' with the actual textbox control name where the first name is entered
            //        cmd.Parameters.AddWithValue("@donor_name ", textBoxSearch.Text);
            //      //  cmd.Parameters.AddWithValue("@blood_type",textBoxSearch.Text);

            //        try
            //        {
            //            conn.Open();

            //            // Execute the query and load the results into a DataTable
            //            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            //            {
            //                DataTable dt = new DataTable();
            //                adapter.Fill(dt);

            //                // Bind the DataTable to the DataGridView
            //                dataGridView1.DataSource = dt;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            // Handle exceptions
            //            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                // Base query
                string query = "SELECT * FROM Blood_Stock WHERE donor_name LIKE @search OR blood_type LIKE @search";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add the parameter for both donor_name and blood_type
                    cmd.Parameters.AddWithValue("@search", "%" + textBoxSearch.Text + "%"); // Using LIKE for partial matches

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
