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
    public partial class headAttendance : UserControl
    {
        public headAttendance()
        {
            InitializeComponent();
        }


        private void headAttendance_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (MySqlConnection sqlCon = new MySqlConnection(cs))
            {
                try
                {
                    sqlCon.Open();
                    string query = "select * from attendance;";

                    
                        
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query,sqlCon);
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

    }
}
