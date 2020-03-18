using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Fake_Dashboard
{
    static class  DatabaseQuery
    {
        private static SQLiteConnection dbconnection = new SQLiteConnection("data source = Fake_Dashboard.db");
        public static void ConnectingDatabase()
        {
            //var dbconnection = new SQLiteConnection("data source = Fake_Dashboard.db");
            dbconnection.Open();
        }

        public static int Login(string upi, string password)
        {
            //dbconnection.Open();
            string sql = "SELECT UPI,Password,Identity FROM People";
            SQLiteCommand command = new SQLiteCommand(sql, dbconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (upi == reader["UPI"].ToString() & password == reader["Password"].ToString())
                {
                    switch (reader["Identity"])
                    {
                        case "Student":
                            reader.Close();
                            return 1;
                        case "Lecturer":
                            reader.Close();
                            return 2;
                        case "Dean":
                            reader.Close();
                            return 3;
                    }
                }
            }
            reader.Close();
            return 0;
        }

        public static void ShowStudentDataTable(DataGridView dataview,string courseNum)
        {
            string sqlQuery = "SELECT p.UPI,S.StudentID,p.FirstName,p.SurName,sc.CourseMark FROM People p INNER JOIN Student s ON p.UPI = s.UPI INNER JOIN StudentCourse sc ON s.StudentID = sc.StudentID INNER JOIN Course c ON sc.CourseID = c.CourseID WHERE c.courseNum = '" + courseNum + "'";
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter(sqlQuery, dbconnection);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            dataview.DataSource = dt;

        }

        public static void ShowLecturerDataTable(DataGridView dataview, string courseNum)
        {
            string sqlQuery = "SELECT p.UPI,p.FirstName,p.SurName FROM People p INNER JOIN Lecturer l ON p.UPI = l.UPI INNER JOIN LecturerCourse lc ON l.LecturerID = lc.LecturerID INNER JOIN Course c ON lc.CourseID = c.CourseID WHERE c.courseNum = '" + courseNum + "'";
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter(sqlQuery, dbconnection);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            dataview.DataSource = dt;
        }

        public static void AddStudentToCourse(string upi, string courseNum)
        {

        }

        public static void SetCourseNumComboBox(ComboBox cb)
        {
            string sqlQuery = "SELECT CourseNum From Course;";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, dbconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<string> CourseNumList = new List<string>();
            while (reader.Read())
            {
                CourseNumList.Add(reader["CourseNum"].ToString());
            }
            cb.Items.AddRange(CourseNumList.ToArray());
            cb.Text = cb.Items[0].ToString();
            reader.Close();
        }

        public static void ShowCourseDataTable(DataGridView dataview, string upi)
        {
            string sqlQuery = "SELECT c.CourseNum, sc.CourseMark From StudentCourse sc INNER JOIN Student s on sc.StudentID = s.StudentID INNER JOIN Course c on sc.CourseID = c.CourseID WHERE s.UPI = '" + upi + "'";
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter(sqlQuery, dbconnection);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
            dataview.DataSource = dt;
        }

        public static PeopleProfile GetProfile(string upi)
        {
            string sql = "SELECT * FROM People WHERE UPI = '" + upi + "'";
            SQLiteCommand command = new SQLiteCommand(sql, dbconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            PeopleProfile profile = new PeopleProfile(upi);
            while (reader.Read())
            {
                profile.Password = reader["Password"].ToString();
                profile.FirstName = reader["FirstName"].ToString();
                profile.Surname = reader["Surname"].ToString();
                profile.Gender = reader["Gender"].ToString();
                profile.DateOfBirth = reader["DateOfBirth"].ToString();
                profile.Email = reader["Email"].ToString();
                profile.PhoneNum = reader["PhoneNum"].ToString();
            }
            return profile;
        }

        public static void UpdateProfile (PeopleProfile p)
        {
            string sql = "UPDATE People SET Password = '" + p.Password + "',FirstName = '" + p.FirstName + "',Surname = '" + p.Surname + "',Gender = '" + p.Gender + "',DateOfBirth = '" + p.DateOfBirth + "',Email = '" + p.Email + "',PhoneNum = '" + p.PhoneNum + "'WHERE UPI = '" + p.UPI + "'";
            MessageBox.Show(sql);
            SQLiteCommand command = new SQLiteCommand(sql, dbconnection);
            command.ExecuteNonQuery();
        }

        public static int AddStudentToCourse(string upi, string surname, string courseNum, string courseMark)
        {
            string sql = "SELECT s.StudentID FROM Student s JOIN People p on s.UPI = p.UPI WHERE s.UPI = '" + upi + "' and p.Surname = '" + surname + "'";
            SQLiteCommand command = new SQLiteCommand(sql, dbconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            MessageBox.Show(sql);
            if (!reader.HasRows)
            {
                reader.Close();
                return 0;
            }
            else {
                reader.Read();
                string studentID = reader["StudentID"].ToString();
                reader.Close();
                ////////////
                string sql3 = "SELECT CourseID FROM Course WHERE CourseNum = '" + courseNum + "'";
                SQLiteCommand command3 = new SQLiteCommand(sql3, dbconnection);
                SQLiteDataReader reader3 = command3.ExecuteReader();
                reader3.Read();
                string courseID = reader3["courseID"].ToString();
                reader3.Close();
                ////////////
                dbconnection = new SQLiteConnection("data source = Fake_Dashboard.db");
                dbconnection.Open();
                string sql2 = "INSERT INTO StudentCourse (StudentID, CourseID, CourseMark) Values (" + studentID + "," + courseID + "," + courseMark + ")";
                SQLiteCommand command2 = new SQLiteCommand(sql2, dbconnection);
                command2.ExecuteNonQuery();
                return 1;
            }
        }


        //
        public static int AddLecturerToCourse(string upi, string surname, string courseNum)
        {
            string sql = "SELECT l.LecturerID FROM Lecturer l JOIN People p on l.UPI = p.UPI WHERE l.UPI = '" + upi + "' and p.Surname = '" + surname + "'";
            SQLiteCommand command = new SQLiteCommand(sql, dbconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return 0;
            }
            else
            {
                reader.Read();
                string lecturerID = reader["LecturerID"].ToString();
                reader.Close();
                ////////////
                string sql3 = "SELECT CourseID FROM Course WHERE CourseNum = '" + courseNum + "'";
                SQLiteCommand command3 = new SQLiteCommand(sql3, dbconnection);
                SQLiteDataReader reader3 = command3.ExecuteReader();
                reader3.Read();
                string courseID = reader3["courseID"].ToString();
                reader3.Close();
                dbconnection = new SQLiteConnection("data source = Fake_Dashboard.db");
                dbconnection.Open();
                string sql2 = "INSERT INTO LecturerCourse (LecturerID, CourseID) Values (" + lecturerID + "," + courseID +  ")";
                SQLiteCommand command2 = new SQLiteCommand(sql2, dbconnection);
                command2.ExecuteNonQuery();
                return 1;
            }
        }





        public static int EditingMark(string upi, string surname, string courseNum, string courseMark)
        {
            string sql = "SELECT s.StudentID FROM Student s JOIN People p on s.UPI = p.UPI WHERE s.UPI = '" + upi + "' and p.Surname = '" + surname + "'";
            SQLiteCommand command = new SQLiteCommand(sql, dbconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            MessageBox.Show(sql);
            if (!reader.HasRows)
            {
                //reader.Read();
                //MessageBox.Show(reader["StudentID"].ToString());
                reader.Close();
                return 0;
            }
            else
            {
                reader.Read();
                string studentID = reader["StudentID"].ToString();
                reader.Close();
                ////////////
                string sql3 = "SELECT CourseID FROM Course WHERE CourseNum = '" + courseNum + "'";
                SQLiteCommand command3 = new SQLiteCommand(sql3, dbconnection);
                SQLiteDataReader reader3 = command3.ExecuteReader();
                MessageBox.Show(sql3);
                reader3.Read();
                //MessageBox.Show(reader["StudentID"].ToString());
                string courseID = reader3["courseID"].ToString();
                reader3.Close();
                ////////////
                dbconnection = new SQLiteConnection("data source = Fake_Dashboard.db");
                dbconnection.Open();
                string sql2 = "UPDATE StudentCourse Set CourseMark = " + courseMark + " WHERE StudentID = " + studentID + " AND CourseID = " + courseID;
                SQLiteCommand command2 = new SQLiteCommand(sql2, dbconnection);
                command2.ExecuteNonQuery();
                MessageBox.Show(sql2);
                return 1;
            }
        }

        ///
        public static List<float> GetMarks(string courseNum)
        {
            List<float> markList = new List<float>();
            string sql = "SELECT CourseID FROM Course WHERE CourseNum = '" + courseNum + "'";
            SQLiteCommand command3 = new SQLiteCommand(sql, dbconnection);
            SQLiteDataReader reader3 = command3.ExecuteReader();
            reader3.Read();
            string courseID = reader3["courseID"].ToString();
            reader3.Close();
            string sql2 = "SELECT CourseMark FROM StudentCourse WHERE CourseID = " + courseID;
            SQLiteCommand command = new SQLiteCommand(sql2, dbconnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                markList.Add(Convert.ToSingle(reader[0].ToString()));
            }
            return markList;
        } 

    }
}
