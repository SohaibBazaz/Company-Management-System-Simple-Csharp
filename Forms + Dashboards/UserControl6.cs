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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Company_Management_System_final
{
    public partial class UserControl6 : UserControl
    {
        public static class UserInfo
        {
            public static string UserName { get; set; }

        }
        public UserControl6()
        {
            InitializeComponent();


        }




        private void UserControl6_Load(object sender, EventArgs e)
        {
            showProjects();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void showProjects()
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();
                    string query = "select * from project";




                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);
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


        private void button1_Click(object sender, EventArgs e)
        {
            string start_date = starttxt.Text;
            string end_date = endtxt.Text;
            string projectname = projectnametxt.Text;
            string username = usernametxt.Text;




            if (start_date != "" || end_date != "" || projectname != "" || username != "")
            {

                InsertIntoProject(start_date, end_date, projectname, username);


            }
            else
            {
                MessageBox.Show("Input is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertIntoProject(string start_date, string end_date, string projectname, string username)
        {


            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();


                    string insertQuery = "insert into project(project_name, start_date, to_date, Username) values(@Pname, @start, @end, @Name)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@start", start_date);
                        cmd.Parameters.AddWithValue("@Pname", projectname);
                        cmd.Parameters.AddWithValue("@end", end_date);

                        cmd.Parameters.AddWithValue("@Name", username);


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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

    

