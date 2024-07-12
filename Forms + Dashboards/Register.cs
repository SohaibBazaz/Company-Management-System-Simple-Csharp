using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System_final
{
    public partial class adminHome : UserControl
    {
        public adminHome()
        {
            InitializeComponent();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            showEmployeeCount();
            showEmployeeList();
            showPendingCount();
        }
        private void showEmployeeCount()
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(cs))
                {
                    sqlCon.Open();

                    // SQL query to count the number of rows in the employee table
                    string countQuery = "SELECT COUNT(*) FROM employee";

                    using (MySqlCommand cmd = new MySqlCommand(countQuery, sqlCon))
                    {
                        // Execute the query and get the count
                        int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the count in the label
                        label3.Text = rowCount.ToString();
                    }
                    string countQuery2 = "SELECT COUNT(*) FROM login where role='admin'";

                    using (MySqlCommand cmd = new MySqlCommand(countQuery2, sqlCon))
                    {
                        // Execute the query and get the count
                        int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the count in the label
                        label7.Text = rowCount.ToString();
                    }
                    string countQuery3 = "SELECT COUNT(*) FROM login where role='employee'";

                    using (MySqlCommand cmd = new MySqlCommand(countQuery3, sqlCon))
                    {
                        // Execute the query and get the count
                        int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the count in the label
                        label9.Text = rowCount.ToString();
                    }
                    string countQuery4 = "SELECT COUNT(*) FROM login where role='head'";

                    using (MySqlCommand cmd = new MySqlCommand(countQuery4, sqlCon))
                    {
                        // Execute the query and get the count
                        int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the count in the label
                        label8.Text = rowCount.ToString();
                    }
                }
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
        private void showEmployeeList()
        {
            string cs = @"server=localhost;userid=root;password123;database=mydb";

            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(cs))
                {
                    sqlCon.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM employee", sqlCon);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
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

        private void showbtn_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void showPendingCount()
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            
                using (MySqlConnection sqlCon = new MySqlConnection(cs))
                {
                    sqlCon.Open();

                    // SQL query to count the number of rows in the employee table
                    string countQuery = "SELECT COUNT(*) FROM temp_register";

                    using (MySqlCommand cmd = new MySqlCommand(countQuery, sqlCon))
                    {
                        // Execute the query and get the count
                        int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the count in the label
                        label11.Text = rowCount.ToString();
                    }
                }
            
            }
    }
}
