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
    public partial class DepartmentHeadForm : Form
    {
        private string loggedInUserName;
        public DepartmentHeadForm(string username)
        {
            InitializeComponent();
            loggedInUserName = username;
            label3.Text = "Welcome, " + loggedInUserName + "!";

            userControl41.Show();
            userControl51.Hide();//complain
            userControl61.Hide();//project
            headAttendance1.Hide();//attendance
            ButtonColorChangeByClick(homebtn);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            userControl41.Show();
            userControl51.Hide();//complain
            userControl61.Hide();//project
            headAttendance1.Hide();//attendance
            ButtonColorChangeByClick(homebtn);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login previousForm = new Login();
            previousForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void userControl61_Load(object sender, EventArgs e)
        {

        }

        private void attendancebtn_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl51.Hide();//complain
            userControl61.Hide();//project
            headAttendance1.Show();//attendance
            ButtonColorChangeByClick(attendancebtn);

        }

        private void projectbtn_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl51.Hide();//complain
            userControl61.Show();//project
            headAttendance1.Hide();//attendance
            ButtonColorChangeByClick(projectbtn);
        }

        private void complainbtn_Click(object sender, EventArgs e)
        {
            userControl41.Hide();
            userControl51.Show();//complain
            userControl61.Hide();//project
            headAttendance1.Hide();//attendance
            ButtonColorChangeByClick(complainbtn);
        }
        private void ButtonColorChangeByClick(Button clickedButton)
        {
           
            homebtn.BackColor = SystemColors.Control;
            attendancebtn.BackColor = SystemColors.Control;
            projectbtn.BackColor = SystemColors.Control;
            complainbtn.BackColor = SystemColors.Control; 

            clickedButton.BackColor = Color.FromArgb(128, 0, 0);
        }
    }
}
