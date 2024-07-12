using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Company_Management_System_final
{
    public partial class EmployeeInfoFormcs : Form
    {
        public EmployeeInfoFormcs(string username)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox6.Text;
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string email = textBox3.Text;
            string cnic = textBox4.Text;
            string sex = textBox5.Text;  

            // Check if any required field is empty
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(cnic) ||
                string.IsNullOrWhiteSpace(sex))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string cs = @"server=localhost;userid=root;password=123;database=mydb";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    string insertQuery = "UPDATE temp_register " +
                     "SET First_name = @FirstName, Last_name = @LastName, " +
                     "Email = @Email, CNIC = @CNIC, Sex = @Sex " +
                     "WHERE name = @Name";
                    var cmd = new MySqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@CNIC", cnic);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@name", name);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           // textBox5.SelectedIndex = -1; // Clear selection from the ComboBox
        }
        private void EmployeeInfoFormcs_Load(object sender, EventArgs e)
        {
           
        }
    }
}