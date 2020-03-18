using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Fake_Dashboard
{
    public partial class Profile : Form
    {
        private string UPI;
        public Profile(string upi)
        {
            UPI = upi;
            InitializeComponent();

            setTextBox(UPI);
            MessageBox.Show(this.GenderTextBox.Text);
            MessageBox.Show(this.GenderTextBox.Text.Length.ToString());
        }

        public void setTextBox(string upi)
        {
            PeopleProfile profile = DatabaseQuery.GetProfile(upi);
            this.UpiTextBox.Text = upi;
            this.PasswordTextBox.Text = profile.Password;
            this.SurnameTextBox.Text = profile.Surname;
            this.FirstNameTextBox.Text = profile.FirstName;
            this.GenderTextBox.Text = profile.Gender;
            this.DOBTextBox.Text = profile.DateOfBirth;
            this.EmailTextBox.Text = profile.Email;
            this.PhoneNumTextBox.Text = profile.PhoneNum;

        }

        public int checkDataFormat()
        {
            //0 format is ok
            //1 DateOfBirth format is wrong
            //2 Email format is wrong
            //3 Gender format is wrong
            //4 Name format is wrong
            //5 Password is too short
            //6 First name text box is empty
            //7 Surname text box is empty
            //8 Gender text box is empty
            //9 DOB text box is empty
            //10 Phone Number format is wrong
            int format = 0;
            Regex e = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
            Regex d = new Regex("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$");
            Regex n = new Regex("^[A-Za-z]+$");
            Regex p = new Regex("^[0-9]*$");
            if (this.DOBTextBox.Text.Length != 0 & !d.IsMatch(this.DOBTextBox.Text))
            {
                format = 1;
            }
            else if (this.EmailTextBox.Text.Length != 0 & !e.IsMatch(this.EmailTextBox.Text))
            {
                format = 2;
            }
            else if (this.GenderTextBox.Text.Length != 0 &(!this.GenderTextBox.Text.Equals("M")|| this.GenderTextBox.Text.Equals("F")))
            {
                format = 3;
            }
            else if (!n.IsMatch(this.FirstNameTextBox.Text) & !n.IsMatch(this.SurnameTextBox.Text))
            {
                format = 4;
            }
            else if (this.PasswordTextBox.Text.Length < 8)
            {
                format = 5;
            }
            else if (this.FirstNameTextBox.Text.Length == 0)
            {
                format = 6;
            }
            else if (this.SurnameTextBox.Text.Length == 0)
            {
                format = 7;
            }
            else if (this.GenderTextBox.Text.Length == 0)
            {
                format = 8;
            }
            else if (this.DOBTextBox.Text.Length == 0)
            {
                format = 9;
            }
            else if (!p.IsMatch(this.PhoneNumTextBox.Text.ToString()))
            {
                format = 10;
            }
            return format;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int format = checkDataFormat();
            switch (format)
            {
                case 0:
                    PeopleProfile p = new PeopleProfile(UPI);
                    p.Password = this.PasswordTextBox.Text;
                    p.Surname = this.SurnameTextBox.Text;
                    p.FirstName = this.FirstNameTextBox.Text;
                    p.Gender = this.GenderTextBox.Text;
                    p.DateOfBirth = this.DOBTextBox.Text;
                    p.Email = this.EmailTextBox.Text;
                    p.PhoneNum = this.PhoneNumTextBox.Text;
                    DatabaseQuery.UpdateProfile(p);
                    this.Close();
                    break;
                case 1:
                    MessageBox.Show("Please check your date of birth format, should be in format dd/mm/yyyy");
                    break;
                case 2:
                    MessageBox.Show("Please check your Email format");
                    break;
                case 3:
                    MessageBox.Show("Please make sure your Gender is M or F");
                    break;
                case 4:
                    MessageBox.Show("Please check your Name format");
                    break;
                case 5:
                    MessageBox.Show("Password must have minimum of 6 characters");
                    break;
                case 6:
                    MessageBox.Show("Please enter your first name");
                    break;
                case 7:
                    MessageBox.Show("Please enter your surname");
                    break;
                case 8:
                    MessageBox.Show("Please enter your gender");
                    break;
                case 9:
                    MessageBox.Show("Please enter your data of birth in format dd/mm/yyyy");
                    break;
                case 10:
                    MessageBox.Show("Please check your Phone number format");
                    break;
            }
        }
    }
}
