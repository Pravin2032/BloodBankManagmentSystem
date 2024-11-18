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
using System.Windows.Forms.VisualStyles;

namespace BloodBankManagmentSystem.UI
{
    public partial class BRequestHistory : Form
    {
        string ConnectionString = fromlogin.ConnectionString;
        public BRequestHistory()
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
                string query = "SELECT * FROM bl_request ";
                using (SqlDataAdapter db = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    db.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void BRequestHistory_Load(object sender, EventArgs e)
        {
            LoadExistingData();
        
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM bl_request WHERE requestor_name = @requestor_name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Replace 'yourTextBox' with the actual textbox control name where the first name is entered
                    cmd.Parameters.AddWithValue("@requestor_name", textBoxBSearch.Text);

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
