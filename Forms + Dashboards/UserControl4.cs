using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Company_Management_System_final.Login;

namespace Company_Management_System_final
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ProjectCount()
        {

            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(*) FROM temp_issues;";// Removed quotes around @username
                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result);
                    label2.Text = count.ToString();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void showEmployeeDetails()
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM employee WHERE Username = @username";// Removed quotes around @username
                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    string _userName = GlobalVariables.Username;
                    cmd.Parameters.AddWithValue("@username", _userName);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            ProjectCount();
            showEmployeeDetails();
            showPendingCount();
        }
        private void showPendingCount()
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";
            string name = GlobalVariables.Username;
            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                sqlCon.Open();

                // SQL query to count the number of rows in the project table
                string countQuery = "SELECT COUNT(*) FROM project WHERE Username=@Name";

                using (MySqlCommand cmd = new MySqlCommand(countQuery, sqlCon))
                {
                    // Assuming "name" is the parameter value you want to pass
                    cmd.Parameters.AddWithValue("@Name", name);

                    // Execute the query and get the count
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    label4.Text = rowCount.ToString();
                }
            }
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
