using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class MainForm : Form
    {
        private DataTable dataTable; // Declare a DataTable field to store the original data

        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            PopulateStudentGrid();
            PopulateRoleFilter(); // Populate the role filter ComboBox
        }

        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            hideSubmenu();
            submenu.Visible = true;
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            AddStudentsForm addStudentsForm = new AddStudentsForm();
            addStudentsForm.ShowDialog(); // Show the form as a modal dialog
        }


        private void button_registration_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_teacher_Click(object sender, EventArgs e)
        {
            AddTeachersForm addTeachersForm = new AddTeachersForm();
            addTeachersForm.ShowDialog();
        }

        private void PopulateStudentGrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THANH\OneDrive\Documents\School.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    string query = "SELECT admin_name AS Name, 'Admin' AS Role, admin_email AS Email, admin_phone AS PhoneNumber FROM admins WHERE date_delete IS NULL " +
                                   "UNION ALL " +
                                   "SELECT teacher_name AS Name, 'Teacher' AS Role, teacher_email AS Email, teacher_phone AS PhoneNumber FROM teachers WHERE date_delete IS NULL " +
                                   "UNION ALL " +
                                   "SELECT student_name AS Name, 'Student' AS Role, student_email AS Email, student_phone AS PhoneNumber FROM students WHERE date_delete IS NULL";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable(); // Assign the DataTable to the field
                    adapter.Fill(dataTable);

                    student_gridData.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateRoleFilter()
        {
            // Populate the ComboBox with role options
            roleFilterComboBox.Items.Add("Admin");
            roleFilterComboBox.Items.Add("Teacher");
            roleFilterComboBox.Items.Add("Student");
            roleFilterComboBox.SelectedIndex = 0; // Select the first role by default
        }

        private void roleFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter the data based on the selected role
            if (dataTable != null)
            {
                DataView dataView = dataTable.DefaultView;
                string selectedRole = roleFilterComboBox.SelectedItem.ToString();

                // Check if "All" is selected
                if (selectedRole == "All")
                {
                    // Remove any existing filter
                    dataView.RowFilter = "";
                }
                else
                {
                    // Filter based on the selected role
                    dataView.RowFilter = $"Role = '{selectedRole}'";
                }

                // Update the DataGridView with filtered data
                student_gridData.DataSource = dataView.ToTable();
            }
        }

        private void label_user_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void student_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roleFilterComboBox_SelectedIndexChangedq(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            PopulateStudentGrid();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            AddAdminsForm addAdminsForm = new AddAdminsForm();
            addAdminsForm.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label_role_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
