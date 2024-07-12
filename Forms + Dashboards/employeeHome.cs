using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static Company_Management_System_final.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Company_Management_System_final
{
    public partial class employeeHome : UserControl
    {
        private string _userName;

        public employeeHome()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void ComplainCount()
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(*) FROM temp_issues WHERE name = @username";
                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    string _userName = GlobalVariables.Username;
                    cmd.Parameters.AddWithValue("@username", _userName);

                    // ExecuteScalar is used to retrieve a single value (the count)
                    object result = cmd.ExecuteScalar();


                    int count = Convert.ToInt32(result);
                    label4.Text = count.ToString();
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

        private void label10_Click(object sender, EventArgs e)
        {
        }

       

        private void employeeHome_Load(object sender, EventArgs e)
        {
            showEmployeeDetails();
            
            ComplainCount();
            showPendingCount();

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalVariables.Username);
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
                    label11.Text = rowCount.ToString();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
