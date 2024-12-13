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
    public partial class AddTeachersForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THANH\OneDrive\Documents\School.mdf;Integrated Security=True;Connect Timeout=30");
        public AddTeachersForm()
        {
            InitializeComponent();

            teacherDisplayData();
        }

        public void teacherDisplayData()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM teachers WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        teacher_gridData.DataSource = dataTable;
                        teacherDisplayData();
                    }
                }
                catch (Exception ex)
                {
                    teacherDisplayData();
                    MessageBox.Show("Error retrieving student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


                private void teacher_addBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_email.Text == ""
                || teacher_phone.Text == ""
                || teacher_salary.Text == ""
                || teacher_subject_1.Text == ""
                || teacher_subject_2.Text == ""
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

                        // WE DON'T LIKE THE DUPLICATE TEACHER ID SO, WE NEED TO CHECK IF ON THE DATABASE HAS ALREADY TEACHER ID VALUE THAT SAME TO THE USER THAT WANT TO INSERT 
                        string checkTeacherID = "SELECT COUNT(*) FROM teachers WHERE teacher_id = @teacherID";

                        using (SqlCommand checkTID = new SqlCommand(checkTeacherID, connect))
                        {
                            checkTID.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                            int count = (int)checkTID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Teacher ID: " + teacher_id.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO teachers " +
                                    "(teacher_id, teacher_name, teacher_salary, teacher_subject_1, " +
                                    " teacher_subject_2, teacher_email, teacher_phone) " +
                                    "VALUES(@teacherID, @teacherName, @teacherSalary, @teacherSubject1," +
                                    " @teacherSubject2, @teacherEmail, @teacherPhone)";

                                // TO SAVE TO YOUR DIRECTORY




                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherEmail", teacher_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherPhone", teacher_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherSalary", teacher_salary.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherSubject1", teacher_subject_1.Text.Trim());

                                    cmd.Parameters.AddWithValue("@teacherSubject2", teacher_subject_2.Text.Trim());


                                    cmd.ExecuteNonQuery();

                                    teacherDisplayData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    teacherDisplayData();

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

        private void teacher_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            teacher_id.Text = "";
            teacher_name.Text = "";
            teacher_email.Text = "";
            teacher_phone.Text = "";
            teacher_salary.Text = ""; 
            teacher_subject_2.Text = "";
            teacher_subject_1.Text = "";
        }

        private void teacher_updateBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_email.Text == ""
                || teacher_phone.Text == ""
                || teacher_salary.Text == ""
                || teacher_subject_1.Text == ""
                || teacher_subject_2.Text == ""
                )
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Teacher ID: "
                            + teacher_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE teachers SET " +
                                "teacher_name = @teacherName, teacher_salary = @teacherSalary, teacher_email = @teacherEmail, teacher_phone = @teacherPhone" +
                                ", teacher_subject_1 = @teacherSubject1" +
                                ", teacher_subject_2 = @teacherSubject2" +
                                " WHERE teacher_id = @teacherID";


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherEmail", teacher_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherPhone", teacher_phone.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherSalary", teacher_salary.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherSubject2", teacher_subject_2.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherSubject1", teacher_subject_1.Text.Trim());

                                cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                teacherDisplayData();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
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

        private void teacher_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = teacher_gridData.Rows[e.RowIndex];
                teacher_id.Text = row.Cells[1].Value.ToString();
                teacher_name.Text = row.Cells[2].Value.ToString();
                teacher_email.Text = row.Cells[3].Value.ToString();
                teacher_phone.Text = row.Cells[4].Value.ToString();
                teacher_salary.Text = row.Cells[5].Value.ToString();
                teacher_subject_2.Text = row.Cells[6].Value.ToString();
                teacher_subject_1.Text = row.Cells[7].Value.ToString();
            }

        }

        private void teacher_deleteBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == "")
            {
                MessageBox.Show("Please select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    DialogResult check = MessageBox.Show("Are you sure you want to delete Teacher ID: " + teacher_id.Text + "?",
                        "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        string deleteData = "DELETE FROM teachers WHERE teacher_id = @teacherID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                teacherDisplayData();
                                MessageBox.Show("Teacher deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("Delete failed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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


        private void teacher_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void teacher_gridData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void teacher_subject_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teacher_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void teacher_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teacher_salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacher_subject_1_TextChanged(object sender, EventArgs e)
        {

        }
    }    
}
