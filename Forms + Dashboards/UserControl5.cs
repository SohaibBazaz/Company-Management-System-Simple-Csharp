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
using static Company_Management_System_final.Login;

namespace Company_Management_System_final
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string approval = comboBox1.Text;


            if (name != "" || approval != "")
            {
                InsertIntoIssue(name, approval);


                DeleteFromTempRegister(name);
            }
            else
            {
                MessageBox.Show("Input is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                    string deleteQuery = "DELETE FROM temp_issues WHERE name = @Name";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@Name", name);


                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void InsertIntoIssue(string name, string approval)
        {
            string cs = @"server=localhost;userid=root;password=123,database=mydb";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();


                    string insertLoginQuery = "UPDATE temp_issues SET approval = @Approval WHERE name = @Name";




                    using (MySqlCommand cmd = new MySqlCommand(insertLoginQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@approval", approval);



                        cmd.ExecuteNonQuery();
                    }




                    string transferQuery = @"
    INSERT INTO issue (description, type, name,approval)
SELECT description, type,name,approval
FROM temp_issues
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void showProjects()
        {
            string name = GlobalVariables.Username;
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM temp_issues;";

                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);


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

        private void UserControl5_Load(object sender, EventArgs e)
        {
            showProjects();
        }
    }
}
