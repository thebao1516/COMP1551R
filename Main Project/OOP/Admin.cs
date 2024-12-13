using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Main_Project
{
    class Admin : Person
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THANH\OneDrive\Documents\School.mdf;Integrated Security=True;Connect Timeout=30");

        public int AdminID { get; set; }
        public string AdminEmail { get; set; }
        public string AdminName { get; set; }
        public string AdminPhone { get; set; }
        public string WorkingHours { get; set; }
        public string AdminPosition { get; set; }
        public double? AdminSalary { get; set; }

        // Parameterless constructor
        public Admin(string name) : base(name, "", "", Role.Admin)
        {
            // Initialize properties if needed
        }


        public List<Admin> adminData()
        {
            List<Admin> listData = new List<Admin>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM admins WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Admin addAD = new Admin("AdminName"); // Provide a name here

                            addAD.AdminID = Convert.ToInt32(reader["admin_id"]);
                            addAD.AdminEmail = reader["admin_email"].ToString();
                            addAD.AdminName = reader["admin_name"].ToString();
                            addAD.AdminPhone = reader["admin_phone"].ToString();
                            addAD.WorkingHours = reader["working_hours"].ToString();
                            addAD.AdminPosition = reader["admin_position"].ToString();
                            addAD.AdminSalary = reader["admin_salary"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["admin_salary"]);

                            listData.Add(addAD);
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
