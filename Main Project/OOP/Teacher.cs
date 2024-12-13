using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Main_Project
{
    class Teacher : Person
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THANH\OneDrive\Documents\School.mdf;Integrated Security=True;Connect Timeout=30");
        public string TeacherID { set; get; }
        public string TeacherName { set; get; }
        public string TeacherEmail { set; get; }
        public string TeacherTelephone { set; get; }
        public double? TeacherSalary { set; get; }
        public string TeacherSubject1 { set; get; }
        public string TeacherSubject2 { set; get; }

        // Constructor for Teacher class
        public Teacher(string name) : base(name, "", "", Role.Teacher)
        {
            // Initialize properties if needed
        }

        // Method to fetch teacher data
        public List<Teacher> teacherData()
        {
            List<Teacher> listData = new List<Teacher>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM teachers WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Teacher addTD = new Teacher(""); // Provide a name here

                            addTD.TeacherID = reader["teacher_id"].ToString();
                            addTD.TeacherName = reader["teacher_name"].ToString();
                            addTD.TeacherEmail = reader["teacher_email"].ToString();
                            addTD.TeacherTelephone = reader["teacher_phone"].ToString();
                            addTD.TeacherSalary = reader["teacher_salary"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["teacher_salary"]);
                            addTD.TeacherSubject1 = reader["teacher_subject_1"].ToString();
                            addTD.TeacherSubject2 = reader["teacher_subject_2"].ToString();

                            listData.Add(addTD);
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
}
