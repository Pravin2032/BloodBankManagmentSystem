using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.UI
{
    public partial class fromlogin : Form
    {
        public static string ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;TrustServerCertificate=True";
        String userFullName;
        public fromlogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;

            if (IsValidUser(user, password))
            {
                FormHome home = new FormHome(userFullName);
                MessageBox.Show("Login Successful");
                textBox1.Clear();
                textBox2.Clear();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private bool IsValidUser(string username, string password)
        {
           
            bool isValid = false; // Variable to store validation status

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Query to retrieve full_name if credentials match
                    string query = "SELECT full_name FROM blood_users WHERE user_name = @user_name AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@user_name", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Execute the query and retrieve the full_name
                        object result = cmd.ExecuteScalar();
                        if (result != null) // Check if a matching record was found
                        {
                            userFullName = result.ToString();
                            isValid = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

          

            return isValid;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fromlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
