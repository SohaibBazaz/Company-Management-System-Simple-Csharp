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
using static Company_Management_System_final.employeeHome;

namespace Company_Management_System_final
{
    public partial class employeeHomepage : UserControl
    {
        public static class UserInfo
        {
            public static string UserName { get; set; }

        }
        public employeeHomepage()
        {
            InitializeComponent();
            showEmployeeDetails();
            showprojectcount();
        }
        private void showEmployeeDetails()
        {
           
        }
        private void showprojectcount()
        {
           
        }
    }
}
