using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Main_Project
{
    public partial class AddStudentsForm: Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THANH\OneDrive\Documents\School.mdf;Integrated Security=True;Connect Timeout=30");
        public AddStudentsForm()
        {
            InitializeComponent();
            displayStudentData();
        }
        public void RefreshGridData()
        {
            displayStudentData();
        }
        public void displayStudentData()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM students WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        student_gridData.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void student_addBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_email.Text == ""
                || student_phone.Text == ""
                || current_subject1.Text == ""
                || current_subject2.Text == ""
                || previous_subject1.Text == ""
                || previous_subject2.Text == ""
                )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // WE DON'T LIKE THE DUPLICATE STUDENT ID SO, WE NEED TO CHECK IF ON THE DATABASE HAS ALREADY TEACHER ID VALUE THAT SAME TO THE USER THAT WANT TO INSERT 
                        string checkStudentID = "SELECT COUNT(*) FROM students WHERE student_id = @studentID";

                        using (SqlCommand checkSID = new SqlCommand(checkStudentID, connect))
                        {
                            checkSID.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Student ID: " + student_id.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO students (student_id, student_name" +
                                    ", current_subject1, current_subject2, previous_subject1, previous_subject2, student_email, student_phone)" +
                                     
                                    "VALUES(@studentID, @studentName, @currentSubject1, @currentSubject2" +
                                    ", @previousSubject1, @previousSubject2, @studentEmail, @studentPhone" +
                                    ")";

                                // TO SAVE TO YOUR DIRECTORY
                               

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@currentSubject1", current_subject1.Text.Trim());
                                    cmd.Parameters.AddWithValue("@currentSubject2", current_subject2.Text.Trim());
                                    cmd.Parameters.AddWithValue("@previousSubject1", previous_subject1.Text.Trim());
                                    cmd.Parameters.AddWithValue("@previousSubject2", previous_subject2.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentEmail", student_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentPhone", student_phone.Text.Trim());


                                    cmd.ExecuteNonQuery();

                                    displayStudentData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        private void student_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        public void clearFields()
        {
            student_id.Text = "";
            student_name.Text = "";
            student_email.Text = "";
            student_phone.Text = "";
            current_subject1.Text = "";
            current_subject2.Text = "";
            previous_subject1.Text = "";
            previous_subject2.Text = "";

        }



        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_email.Text == ""
                || student_phone.Text == ""
                || current_subject1.Text == ""
                || current_subject2.Text == ""
                || previous_subject1.Text == ""
                || previous_subject2.Text == ""
                )
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to update Student ID: "
                            + student_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Now;

                            string updateData = "UPDATE students SET student_name = @studentName, " +
                                "current_subject1 = @currentSubject1, current_subject2 = @currentSubject2, " +
                                "previous_subject1 = @previousSubject1, previous_subject2 = @previousSubject2, student_email = @studentEmail, student_phone = @studentPhone " +
                                "WHERE student_id = @studentID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@currentSubject1", current_subject1.Text.Trim());
                                cmd.Parameters.AddWithValue("@currentSubject2", current_subject2.Text.Trim());
                                cmd.Parameters.AddWithValue("@previousSubject1", previous_subject1.Text.Trim());
                                cmd.Parameters.AddWithValue("@previousSubject2", previous_subject2.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentEmail", student_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentPhone", student_phone.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdated", today);
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Student information updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayStudentData(); // Refresh grid data
                                    clearFields();
                                }
                                else
                                {
                                    MessageBox.Show("No rows were updated.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            
                        }
                        }
                        else
                        {
                            MessageBox.Show("Update operation cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating student information: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Connection is already open.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void student_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = student_gridData.Rows[e.RowIndex];
                student_id.Text = row.Cells[1].Value.ToString();
                student_name.Text = row.Cells[2].Value.ToString();
                student_email.Text = row.Cells[3].Value.ToString();
                student_phone.Text = row.Cells[4].Value.ToString();
                current_subject1.Text = row.Cells[5].Value.ToString();
                current_subject2.Text = row.Cells[6].Value.ToString();
                previous_subject1.Text = row.Cells[7].Value.ToString();
                previous_subject2.Text = row.Cells[8].Value.ToString();  

            }
        }

        private void student_deleteBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete Student ID: " + student_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM students WHERE student_id = @studentID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                displayStudentData();
                                MessageBox.Show("Student deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("Delete failed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }


        private void student_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_addBtn_Click_2(object sender, EventArgs e)
        {

        }

        private void student_gridData_CellContentClickdd(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void student_updateBtn_Click_12(object sender, EventArgs e)
        {

        }

        private void student_clearBtn_Click4(object sender, EventArgs e)
        {

        }

        private void student_deleteBtn_Click_12(object sender, EventArgs e)
        {

        }

        private void previous_subject2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentsForm_Load(object sender, EventArgs e)
        {

        }

        private void student_phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
