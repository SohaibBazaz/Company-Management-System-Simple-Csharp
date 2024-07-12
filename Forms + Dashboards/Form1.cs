using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Company_Management_System_final;

namespace Company_Management_System_final


{


    public partial class Login : Form
    {
        private string loggedInUserName = "";
        public Login()
        {

            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerDashboard = new RegisterForm();
            registerDashboard.Show();

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=123;database=mydb";

            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    string stm = "SELECT name, password, role FROM login WHERE name=@name";
                    var cmd = new MySqlCommand(stm, con);

                    cmd.Parameters.AddWithValue("@name", usernametxt.Text);

                    if (usernametxt.Text == "" || passwordtxt.Text == "")
                    {
                        MessageBox.Show("Missing Information");
                        return;
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["password"].ToString();
                            string enteredPassword = passwordtxt.Text;


                            if (storedPassword == enteredPassword)
                            {
                                loggedInUserName = reader["name"].ToString();
                                MessageBox.Show("Login Successful");
                                string role = reader["role"].ToString();
                                GlobalVariables.Username = usernametxt.Text;

                                switch (role)
                                {
                                    case "admin":
                                        MessageBox.Show("Admin Login Successful");

                                        AdminDashboardForm adminDashboard = new AdminDashboardForm(loggedInUserName);
                                        adminDashboard.Show();
                                        this.Hide();
                                        break;
                                    case "head":
                                        MessageBox.Show("Department Head Login Successful");

                                        DepartmentHeadForm departmentDashboard = new DepartmentHeadForm(loggedInUserName);
                                        departmentDashboard.Show();
                                        this.Hide();
                                        break;
                                    case "employee":


                                        
                                        EmployeeForm employeeDashboard = new EmployeeForm(loggedInUserName);
                                        employeeDashboard.Show();
                                        this.Hide();

                                        break;
                                    default:
                                        MessageBox.Show("Unknown Role. Please contact administrator.");
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Login Failed. Incorrect password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Failed. Username not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

        public static class GlobalVariables
        {
            public static string Username;
        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            //passwordtxt.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void nametextbox()
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

