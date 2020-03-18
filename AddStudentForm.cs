using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fake_Dashboard
{
    public partial class AddStudentForm : Form
    {
        private string courseNum;
        public AddStudentForm(string cNum)
        {
            courseNum = cNum;
            InitializeComponent();
            
            this.Text = "Add Student To " + courseNum;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int format = checkdataformat();
            switch (format)
            {
                case 0:
                    string upi = this.UPITextBox.Text.ToString();
                    string surname = this.SurnameTextBox.Text.ToString();
                    string courseaMark = this.MarkTextBox.Text.ToString();
                    int temp = DatabaseQuery.AddStudentToCourse(upi, surname, courseNum, courseaMark);
                    if (temp == 0) {
                        MessageBox.Show("Can't find this student, please check the UPI and Surname");
                        break;
                    }
                    else
                    {
                        this.Close();
                        break;
                    }
                    
                case 1:
                    MessageBox.Show("UPI format is wrong, it should contain 9 numbers");
                    break;
                case 2:
                    MessageBox.Show("The length of UPI must be 9");
                    break;
                case 3:
                    MessageBox.Show("Surname format is wrong, please check it");
                    break;
                case 4:
                    MessageBox.Show("Please enter student's Surname");
                    break;
                case 5:
                    MessageBox.Show("Please check the format of mark, it should be an integer between 0 and 100");
                    break;

            }
            
            

        }

        private int checkdataformat()
        {
            //0 All good
            //1 Upi format is wrong
            //2 Upi is empty
            //3 Surname format is wrong
            //4 Surname is empty
            //5 Mark format is wrong
            Regex a = new Regex("^[A-Za-z]+$");
            Regex b = new Regex("^[1-9][0-9]{7}");
            Regex c = new Regex("^0|100|[1-9][0-9]?(.[0-9]{2})?$");
            int format = 0;
            if (this.UPITextBox.Text.ToString().Length == 0)
            {
                format = 2;
            }
            else if (!b.IsMatch(this.UPITextBox.Text.ToString()))
            {
                format = 1;
            }
            else if (this.SurnameTextBox.Text.Length == 0)
            {
                format = 4;
            }
            else if (!a.IsMatch(this.SurnameTextBox.Text.ToString()))
            {
                format = 3;
            }
            else if (!c.IsMatch(this.MarkTextBox.Text.ToString()))
            {
                format = 5;
            }
            return format;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void MarkTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MarkLabel_Click(object sender, EventArgs e)
        {

        }

        private void UPITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void UPILabel_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
