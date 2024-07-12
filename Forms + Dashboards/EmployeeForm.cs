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
using System.Xml.Linq;
using static Company_Management_System_final.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Company_Management_System_final
{
    public partial class EmployeeForm : Form
    {
        private string loggedInUserName;
        public EmployeeForm(string username)
        {
            InitializeComponent();
            loggedInUserName = username;
            label3.Text = "Welcome, " + loggedInUserName + "!";


            employeeHome1.Show();
            userControl11.Hide();
            userControl22.Hide();
            userControl31.Hide();
            ButtonColorChangeByClick(homebtn);


        }


        private void showemp()
        {

        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            showPendingCount();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            employeeHome1.Show();
            userControl11.Hide();
            userControl22.Hide();
            userControl31.Hide();
            ButtonColorChangeByClick(homebtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projectbtn_Click(object sender, EventArgs e)
        {
            employeeHome1.Hide();
            userControl11.Show();
            userControl22.Hide();
            userControl31.Hide();
            ButtonColorChangeByClick(projectbtn);

        }

        private void attendancebtn_Click(object sender, EventArgs e)
        {
            employeeHome1.Hide();
            userControl11.Hide();
            userControl22.Show();
            userControl31.Hide();
            ButtonColorChangeByClick(attendancebtn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login previousForm = new Login();
            previousForm.Show();
        }

        private void complainbtn_Click(object sender, EventArgs e)
        {

            employeeHome1.Hide();
            userControl11.Hide();
            userControl22.Hide();
            userControl31.Show();
            ButtonColorChangeByClick(complainbtn);
        }
        private void ButtonColorChangeByClick(Button clickedButton)
        {
           
            homebtn.BackColor = SystemColors.Control; 
            projectbtn.BackColor = SystemColors.Control; 
            attendancebtn.BackColor = SystemColors.Control; 
            complainbtn.BackColor = SystemColors.Control;

            
            clickedButton.BackColor = Color.FromArgb(128, 0, 0);
        }
        private void userControl31_Load(object sender, EventArgs e)
        {
            showPendingCount();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void employeeHome1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeeHome1_Load_1(object sender, EventArgs e)
        {

        }
        private void showPendingCount()
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";
           string name= GlobalVariables.Username;
            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                sqlCon.Open();
                
                // SQL query to count the number of rows in the project table
                string countQuery = "SELECT COUNT(*) FROM project WHERE Username=@Name";

                using (MySqlCommand cmd = new MySqlCommand(countQuery, sqlCon))
                {
                    // Assuming "name" is the parameter value you want to pass
                    cmd.Parameters.AddWithValue("@Name",name);

                    // Execute the query and get the count
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Display the count in the label
                    label2.Text = rowCount.ToString();
                }
            }
        }
            
        private void label2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
