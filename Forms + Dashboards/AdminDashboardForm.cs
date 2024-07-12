using MySql.Data.MySqlClient;

using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Company_Management_System_final
{
    public partial class AdminDashboardForm : Form
    {
        private string loggedInUserName;
        public AdminDashboardForm(string userName)
        {
            InitializeComponent();
            loggedInUserName = userName;
            label1.Text = "Welcome, " + loggedInUserName + "!";
            adminRegisteration1.Hide();
            userManagement1.Hide();
            adminHome1.Show();



        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            showPendingCount();
            ButtonColorChangeByClick(homebtn);

        }
        private void showPendingCount()
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            try
            {
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
                        label2.Text = rowCount.ToString();
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminRegisteration1.Hide();
            userManagement1.Hide();
            adminHome1.Show();
            ButtonColorChangeByClick(homebtn);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void ButtonColorChangeByClick(Button clickedButton)
        {
            // Reset all buttons to default color
            registrationbtn.BackColor = SystemColors.Control; // or any default color
            rolesbtn.BackColor = SystemColors.Control;       // or any default color
            homebtn.BackColor = SystemColors.Control;        // or any default color

            // Set the clicked button to the maroon color
            clickedButton.BackColor = Color.FromArgb(128, 0, 0);
        }


        private void registrationbtn_Click(object sender, EventArgs e)
        {
            adminRegisteration1.Show();
            userManagement1.Hide();
            adminHome1.Hide();
            ButtonColorChangeByClick(registrationbtn);
        }

        private void rolesbtn_Click(object sender, EventArgs e)
        {

            adminRegisteration1.Hide();
            userManagement1.Show();
            adminHome1.Hide();
            ButtonColorChangeByClick(rolesbtn);

        }

        private void rewardsbtn_Click(object sender, EventArgs e)
        {

        }

        private void registeration1_Load(object sender, EventArgs e)
        {

        }

        private void registeration1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login previousForm = new Login();
            previousForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adminRegisteration1_Load(object sender, EventArgs e)
        {

        }
    }
}
