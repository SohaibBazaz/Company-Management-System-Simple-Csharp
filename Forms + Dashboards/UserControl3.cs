using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Company_Management_System_final.Login;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Company_Management_System_final
{
    public partial class UserControl3 : UserControl
    {
        
        public UserControl3()
        {
            InitializeComponent();
            

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void sun()
        {


        }

        private void InsertIntoAttendance(string type, string description,string name)
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            
            

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                
                    con.Open();

                    
                    string insertQuery = "INSERT INTO temp_issues(name, type, description) VALUES(@name, @type, @description)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@name", name);
                        insertCmd.Parameters.AddWithValue("@type", type);
                        insertCmd.Parameters.AddWithValue("@description", description);

                        insertCmd.ExecuteNonQuery();
                    }
                }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = textBox1.Text;
            string description = textBox2.Text;
            string name = GlobalVariables.Username;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(description))
            {
                InsertIntoAttendance(type, description,name);
                showProjects();
            }
            else
            {
                MessageBox.Show("Input is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      


        private void UserControl3_Load(object sender, EventArgs e)
        {
            showProjects();
        }
        private void showProjects()
        {
            string name =GlobalVariables.Username;
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM temp_issues WHERE name = @name";

                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@name", name);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
