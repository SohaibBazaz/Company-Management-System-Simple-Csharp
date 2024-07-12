using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Company_Management_System_final
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();


                    if (usernametxt.Text == "" || passwordtxt.Text == "")
                    {
                        MessageBox.Show("Missing Information");
                        return;
                    }
                    if (passwordtxt.Text == confirmpasswordtxt.Text)
                    {

                        string checkUserQuery = "SELECT COUNT(*) FROM temp_register WHERE name=@name";
                        var checkUserCmd = new MySqlCommand(checkUserQuery, con);
                        checkUserCmd.Parameters.AddWithValue("@name", usernametxt.Text);
                        int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another one.");
                            return;
                        }

                        string insertQuery = "INSERT INTO temp_register (name, password) VALUES (@name, @password)";
                        var insertCmd = new MySqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@name", usernametxt.Text);
                        insertCmd.Parameters.AddWithValue("@password", passwordtxt.Text);
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Signup Successful");

                            usernametxt.Text = "";
                            passwordtxt.Text = "";
                            confirmpasswordtxt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Signup Failed. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password did not match");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("An error occurred. Please try again later.");
                }
            }
            string name = usernametxt.Text;
            EmployeeInfoFormcs emp = new EmployeeInfoFormcs(name);
            emp.ShowDialog();

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login newlogin = new Login();
            newlogin.Show();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
