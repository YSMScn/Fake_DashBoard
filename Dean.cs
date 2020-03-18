using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Fake_Dashboard.Editing;

namespace Fake_Dashboard
{
    public partial class Dean : Form
    {
        string UPI;
        string courseNum;
        public Dean(string LoginUPI)
        {
            UPI = LoginUPI;
            InitializeComponent();
            DatabaseQuery.SetCourseNumComboBox(CourseNumComboBox);
        }

        private void Dean_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CourseNumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseNum = CourseNumComboBox.Items[CourseNumComboBox.SelectedIndex].ToString();
            //MessageBox.Show(CourseNumComboBox.Items[CourseNumComboBox.SelectedIndex].ToString());
            DatabaseQuery.ShowStudentDataTable(this.StudentDataTable, courseNum);
            DatabaseQuery.ShowLecturerDataTable(this.LecturerDataTable, courseNum);
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(UPI);
            profile.Show();
        }

        private void AddNewStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm(courseNum);
            addStudentForm.Show();

        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            Editing editing = new Editing(courseNum);
            editing.OnRefreshEvent += new RefreshEventHandle(this.RefreshData);
            editing.Show();
        }

        private void RefreshData()
        {
            DatabaseQuery.ShowStudentDataTable(this.StudentDataTable, courseNum);
        }

        private void ShowStatsButton_Click(object sender, EventArgs e)
        {
            List<float> markList = DatabaseQuery.GetMarks(courseNum);
            float average = markList.Average();
            float maxMark = markList.Max();
            float minMark = markList.Min();
            float numOfStudent = markList.ToArray().Length;
            MessageBox.Show("There are " + numOfStudent.ToString() + " students in course " + courseNum + "\n" + "Max Mark: " + maxMark + "\n" + "Min Mark: " + minMark + "\n" + "Average: " + average);

        }

        private void AddLecturerButton_Click(object sender, EventArgs e)
        {
            AddLecturerForm addLecturerForm = new AddLecturerForm(courseNum);
            addLecturerForm.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DashBorad db = new DashBorad();
            db.Show();
            this.Hide();
        }
    }
}
