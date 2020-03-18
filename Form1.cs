using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Fake_Dashboard
{
    public partial class DashBorad : Form
    {
        public DashBorad()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //var dbconnection = new SQLiteConnection("data source = Fake_Dashboard.db");
            //dbconnection.Open();
            //int upitemp = 123456;
            //string passwordtemp = "123456";
            //string sql = "SELECT UPI,Password FROM People";
            //SQLiteCommand command = new SQLiteCommand(sql,dbconnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            //bool a = false;
            //while (reader.Read())
            //{
            //    if(UPITextBox.Text == reader["UPI"].ToString() & PasswordTextBox.Text == reader["Password"].ToString())
            //    {
            //        a = true;
            //    }
            //}
            //if ( a == false)
            //{
            //    this.LoginDetailLabel.Visible = true;
            //}
            //else
            //{
            //    MessageBox.Show("Welcome");
            //}
            string upi = UPITextBox.Text;
            string password = PasswordTextBox.Text;
            int LoginDetail = DatabaseQuery.Login(upi,password);
            switch (LoginDetail)
            {
                case 0:
                    LoginDetailLabel.Visible = true;
                    break;
                case 1:
                    //MessageBox.Show("Welcome Student");
                    Student student = new Student(upi);
                    student.Location = this.Location;
                    student.StartPosition = this.StartPosition;
                    student.Size = this.Size;
                    student.Show();
                    this.Hide();
                    break;
                case 2:
                    //MessageBox.Show("Welcome Lecturer");
                    Lecturer Lecturer = new Lecturer(upi);
                    Lecturer.Location = this.Location;
                    Lecturer.StartPosition = this.StartPosition;
                    Lecturer.Size = this.Size;
                    Lecturer.ShowDialog();
                    this.Hide();
                    break;
                case 3:
                    //MessageBox.Show("Welcome Dean");
                    Dean dean = new Dean(upi);
                    dean.Location = this.Location;
                    dean.StartPosition = this.StartPosition;
                    dean.Size = this.Size;
                    dean.ShowDialog();
                    this.Hide();
                    break;
            }
        }

        private void DashBorad_Load(object sender, EventArgs e)
        {

        }

        private void SigninButton_Click(object sender, EventArgs e)
        {

        }
    }
}
