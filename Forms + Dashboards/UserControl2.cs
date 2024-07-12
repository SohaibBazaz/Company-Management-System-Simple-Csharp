using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Session;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Company_Management_System_final
{
    public partial class UserControl2 : UserControl
    {


        public UserControl2()
        {
            InitializeComponent();

        }

        private void showAttendance()
        {

        }
        private void UserControl2_Load(object sender, EventArgs e)
        {

        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string date = textBox1.Text;
            string id = idtxt.Text;


            // Insert data into login table
            if (date != "" || id != "")
            {
                // Insert data into login table
                InsertIntoAttendance(date, id);


            }
            else
            {
                MessageBox.Show("Input is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertIntoAttendance(string date1, string id)
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    
                    string insertQuery = "insert into attendance(date, present, Employee_EmpID) values(@date, 'Present', @Employee_EmpID)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@date", date1);

                        cmd.Parameters.AddWithValue("@Employee_EmpID", id);

                       
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


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }


        private void showbtn_Click(object sender, EventArgs e)
        {
            string idText = idtxt.Text;
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("ID must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();
                    string query = "select * from attendance where Employee_EmpID=@Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Add your event handling logic here
        }
        private void label3_Click(object sender, EventArgs e)
        {
            // Add your event handling logic here
        }

        private void textBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
