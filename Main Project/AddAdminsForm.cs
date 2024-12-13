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
    public partial class AddAdminsForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THANH\OneDrive\Documents\School.mdf;Integrated Security=True;Connect Timeout=30");
        public AddAdminsForm()
        {
            InitializeComponent();

            adminDisplayData();
        }

        public void adminDisplayData()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM admins WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        admin_gridData.DataSource = dataTable;
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

        private void admin_addBtn_Click(object sender, EventArgs e)
        {
            if (admin_id.Text == ""
                || admin_name.Text == ""
                || admin_salary.Text == ""
                || admin_email.Text == ""
                || admin_phone.Text == ""
                || admin_position.Text == ""
                || working_hours.Text == ""
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

                        // WE DON'T LIKE THE DUPLICATE admin ID SO, WE NEED TO CHECK IF ON THE DATABASE HAS ALREADY admin ID VALUE THAT SAME TO THE USER THAT WANT TO INSERT 
                        string checkadminID = "SELECT COUNT(*) FROM admins WHERE admin_id = @adminID";

                        using (SqlCommand checkAID = new SqlCommand(checkadminID, connect))
                        {
                            checkAID.Parameters.AddWithValue("@adminID", admin_id.Text.Trim());
                            int count = (int)checkAID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("admin ID: " + admin_id.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO admins " +
                                                   "(admin_id, admin_name, admin_salary, admin_email, " +
                                                    " admin_phone, admin_position, working_hours) " +
                                                      "VALUES(@adminID, @adminName, @adminSalary, @adminEmail," +
                                                      " @adminPhone, @adminPosition, @workingHours)";


                                // TO SAVE TO YOUR DIRECTORY




                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@adminID", admin_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@adminName", admin_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@adminSalary", admin_salary.Text.Trim());
                                    cmd.Parameters.AddWithValue("@adminPhone", admin_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@adminEmail", admin_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@adminPosition", admin_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@workingHours", working_hours.Text.Trim());
                                    cmd.ExecuteNonQuery();

                                    adminDisplayData();

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

        private void admin_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            admin_id.Text = "";
            admin_name.Text = "";
            admin_salary.Text = "";
            admin_email.Text = "";
            admin_phone.Text = "";
            admin_position.Text = "";
            working_hours.Text = "";
        }

        private void admin_updateBtn_Click(object sender, EventArgs e)
        {
            if (admin_id.Text == ""
                || admin_name.Text == ""
                || admin_salary.Text == ""
                || admin_email.Text == ""
                || admin_phone.Text == ""
                || admin_position.Text == ""
                || working_hours.Text == ""
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

                        DialogResult check = MessageBox.Show("Are you sure you want to Update admin ID: "
                            + admin_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE admins SET " +
                                "admin_name = @adminName, admin_salary = @adminSalary" +
                                ", admin_phone = @adminPhone, admin_email = @adminEmail" +
                                ", admin_position = @adminPosition, working_hours = @workingHours" +
                                " WHERE admin_id = @adminID";


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@adminID", admin_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@adminName", admin_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@adminSalary", admin_salary.Text.Trim());
                                cmd.Parameters.AddWithValue("@adminPhone", admin_phone.Text.Trim());
                                cmd.Parameters.AddWithValue("@adminEmail", admin_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@adminPosition", admin_position.Text.Trim());
                                cmd.Parameters.AddWithValue("@workingHours", working_hours.Text.Trim());

                                cmd.ExecuteNonQuery();

                                adminDisplayData();

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

        private void admin_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = admin_gridData.Rows[e.RowIndex];
                admin_id.Text = row.Cells[1].Value.ToString();
                admin_name.Text = row.Cells[2].Value.ToString();
                admin_salary.Text = row.Cells[3].Value.ToString();
                admin_phone.Text = row.Cells[4].Value.ToString();
                admin_email.Text = row.Cells[5].Value.ToString();
                admin_position.Text = row.Cells[5].Value.ToString();
                working_hours.Text = row.Cells[5].Value.ToString();
            }

        }

        private void admin_deleteBtn_Click(object sender, EventArgs e)
        {
            if (admin_id.Text == "")
            {
                MessageBox.Show("Please select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    DialogResult check = MessageBox.Show("Are you sure you want to delete admin ID: " + admin_id.Text + "?",
                        "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        string deleteData = "DELETE FROM admins WHERE admin_id = @adminID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@adminID", admin_id.Text.Trim());

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                adminDisplayData();
                                MessageBox.Show("admin deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void admin_addBtn_Click_(object sender, EventArgs e)
        {

        }

        private void admin_updateBtn_Click_(object sender, EventArgs e)
        {

        }

        private void admin_clearBtn_Click_(object sender, EventArgs e)
        {

        }

        private void admin_deleteBtn_Click_(object sender, EventArgs e)
        {

        }

        private void admin_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
