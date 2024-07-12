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
    public partial class adminRegisteration : UserControl
    {
        string cs = @"server=localhost;userid=root;password=sohaibisnoob1;database=mydb";
        public adminRegisteration()
        {

            InitializeComponent();
            ButtonColorChangeByClick(addbtn, removebtn, showbtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get data from textboxes
            string name = usernametxt.Text;
            string password = passwordtxt.Text;
            string role = roletxt.Text;

            // Insert data into login table
            if (name != "" || password != "" || role != "")
            {
                // Insert data into login table
                InsertIntoLogin(name, password, role);

                // Delete data from temp_register table
                DeleteFromTempRegister(name);
            }
            else
            {
                MessageBox.Show("Input is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void InsertIntoLogin(string name, string password, string role)
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // SQL query to insert data into login
                    string insertLoginQuery = "INSERT INTO login (name, password, role) VALUES (@Name, @Password, @Role)";

                    // SQL query to insert data into temp_register
                    

                    using (MySqlCommand cmd = new MySqlCommand(insertLoginQuery, con))
                    {
                        // Add parameters for login table
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);

                        // Execute the command to insert into login table
                        cmd.ExecuteNonQuery();
                    }



                    // Transfer data from temp_register to employee table
                    // Transfer data from temp_register to employee table
                    string transferQuery = @"
    INSERT INTO employee (First_name, Last_name, CNIC, sex, Email, Username, Password)
SELECT First_name, Last_name, CNIC, Sex, Email, name, password
FROM temp_register
WHERE name = @Name";



                    using (MySqlCommand cmd = new MySqlCommand(transferQuery, con))
                    {
                        // Add parameter for name
                        cmd.Parameters.AddWithValue("@Name", name);

                        // Execute the command to transfer data
                        cmd.ExecuteNonQuery();
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
        }

        private void DeleteFromTempRegister(string name)
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // SQL query to delete data from temp_register
                    string deleteQuery = "DELETE FROM temp_register WHERE name = @Name";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Name", name);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();

                    // Corrected SQL query: SELECT * FROM temp_register
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM temp_register", sqlCon);
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

        private void removebtn_Click(object sender, EventArgs e)
        {
            // Get data from textboxes
            string name = usernametxt.Text;
            string password = passwordtxt.Text;
            string role = roletxt.Text;

            DeleteFromTempRegister(name);


        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void roletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ButtonColorChangeByClick(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.FromArgb(128, 0, 0);
            btn2.BackColor = Color.FromArgb(128, 0, 0);
            btn3.BackColor = Color.FromArgb(128, 0, 0);



        }

        private void roletxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
