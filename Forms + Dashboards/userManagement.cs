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
    public partial class userManagement : UserControl
    {
        public userManagement()
        {
            InitializeComponent();
            showLoginDetails();
            ButtonColorChangeByClick(updatebtn, viewbtn);
        }
        private void showLoginDetails()
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();


                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM login", sqlCon);
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            // Get data from textboxes
            string name = usernametxt.Text;
            string password = passwordtxt.Text;
            string role = roletxt.Text;
            string idText = idtxt.Text;

            // Check if ID is a valid integer
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("ID must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(role))
            {

                UpdateLogin(name, password, role, id);
            }
            else
            {
                MessageBox.Show("Input is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateLogin(string name, string password, string role, int id)
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();


                    string insertQuery = "UPDATE login SET name = @Name, password = @Password, role=@Role WHERE id=@Id";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Id", id);


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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void ButtonColorChangeByClick(Button btn1, Button btn2)
        {
            btn1.BackColor = Color.FromArgb(128, 0, 0);
            btn2.BackColor = Color.FromArgb(128, 0, 0);



        }

        private void roletxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
