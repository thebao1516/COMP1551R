using Main_Project;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

class Student : Person
{
    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Documents\School.mdf;Integrated Security=True;Connect Timeout=30");

    public string StudentID { set; get; }
    public string StudentName { set; get; }
    public string StudentEmail { set; get; }
    public string StudentTelephone { set; get; }
    public string CurrentSubject1 { set; get; }
    public string CurrentSubject2 { set; get; }
    public string PreviousSubject1 { set; get; }
    public string PreviousSubject2 { set; get; }

    public Student(string name, string telephone, string email, Role role) : base(name, telephone, email, role)
    {
    }

    public List<Student> studentData()
    {
        List<Student> listData = new List<Student>();
        if (connect.State != ConnectionState.Open)
        {
            try
            {
                connect.Open();

                string sql = "SELECT * FROM students WHERE date_delete IS NULL";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Student addSD = new Student(this.Name, this.Telephone, this.Email, this.Role); // Using inherited constructor

                        addSD.StudentID = reader["student_id"].ToString();
                        addSD.StudentName = reader["student_name"].ToString();
                        addSD.StudentEmail = reader["student_email"].ToString();
                        addSD.StudentTelephone = reader["student_phone"].ToString();
                        addSD.CurrentSubject1 = reader["current_subject1"].ToString();
                        addSD.CurrentSubject2 = reader["current_subject2"].ToString();
                        addSD.PreviousSubject1 = reader["previous_subject1"].ToString();
                        addSD.PreviousSubject2 = reader["previous_subject2"].ToString();

                        listData.Add(addSD);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting Database: " + ex);
            }
            finally
            {
                connect.Close();
            }
        }
        return listData;

    }
}
