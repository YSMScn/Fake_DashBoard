using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fake_Dashboard
{
    public partial class Student : Form
    {
        private string upi;
        public Student(string LoginUPI)
        {
            upi = LoginUPI;
            InitializeComponent();
            MessageBox.Show(LoginUPI);
            DatabaseQuery.ShowCourseDataTable(this.StudentDataTable, LoginUPI);
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StudentsDetailButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(upi);
            profile.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DashBorad db = new DashBorad();
            db.Show();
            this.Hide();
        }
    }
}
