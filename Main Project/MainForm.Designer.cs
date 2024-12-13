namespace Main_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.student_gridData = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_role = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.panel_scoreSubmenu = new System.Windows.Forms.Panel();
            this.button_scorePrint = new System.Windows.Forms.Button();
            this.button_manageScore = new System.Windows.Forms.Button();
            this.button_newScore = new System.Windows.Forms.Button();
            this.button_admin = new System.Windows.Forms.Button();
            this.panel_courseSubmenu = new System.Windows.Forms.Panel();
            this.button_manageCourse = new System.Windows.Forms.Button();
            this.button_newCourse = new System.Windows.Forms.Button();
            this.button_teacher = new System.Windows.Forms.Button();
            this.panel_stdsubmenu = new System.Windows.Forms.Panel();
            this.button_manageStd = new System.Windows.Forms.Button();
            this.button_registration = new System.Windows.Forms.Button();
            this.button_std = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_user = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.roleFilterComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_main.SuspendLayout();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_gridData)).BeginInit();
            this.panel_slide.SuspendLayout();
            this.panel_scoreSubmenu.SuspendLayout();
            this.panel_courseSubmenu.SuspendLayout();
            this.panel_stdsubmenu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(278, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1670, 983);
            this.panel_main.TabIndex = 3;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.panel3);
            this.panel_cover.Controls.Add(this.panel1);
            this.panel_cover.Controls.Add(this.student_gridData);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(1670, 983);
            this.panel_cover.TabIndex = 0;
            // 
            // student_gridData
            // 
            this.student_gridData.AllowUserToResizeRows = false;
            this.student_gridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.student_gridData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.student_gridData.CausesValidation = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.student_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.student_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_gridData.EnableHeadersVisualStyles = false;
            this.student_gridData.Location = new System.Drawing.Point(0, 118);
            this.student_gridData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.student_gridData.Name = "student_gridData";
            this.student_gridData.ReadOnly = true;
            this.student_gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.student_gridData.RowHeadersVisible = false;
            this.student_gridData.RowHeadersWidth = 500;
            this.student_gridData.Size = new System.Drawing.Size(1670, 688);
            this.student_gridData.TabIndex = 8;
            this.student_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_gridData_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 806);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1670, 177);
            this.panel3.TabIndex = 2;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.ForeColor = System.Drawing.Color.White;
            this.label_role.Location = new System.Drawing.Point(134, 69);
            this.label_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(72, 25);
            this.label_role.TabIndex = 3;
            this.label_role.Text = "Admin";
            this.label_role.Click += new System.EventHandler(this.label_role_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Role:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_slide
            // 
            this.panel_slide.AutoScroll = true;
            this.panel_slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel_slide.Controls.Add(this.button_exit);
            this.panel_slide.Controls.Add(this.displayButton);
            this.panel_slide.Controls.Add(this.panel_scoreSubmenu);
            this.panel_slide.Controls.Add(this.button_admin);
            this.panel_slide.Controls.Add(this.panel_courseSubmenu);
            this.panel_slide.Controls.Add(this.button_teacher);
            this.panel_slide.Controls.Add(this.panel_stdsubmenu);
            this.panel_slide.Controls.Add(this.button_std);
            this.panel_slide.Controls.Add(this.panel_logo);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(278, 983);
            this.panel_slide.TabIndex = 2;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(0, 785);
            this.button_exit.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_exit.Size = new System.Drawing.Size(278, 198);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.Color.Navy;
            this.displayButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayButton.FlatAppearance.BorderSize = 0;
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayButton.ForeColor = System.Drawing.Color.White;
            this.displayButton.Location = new System.Drawing.Point(0, 715);
            this.displayButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.displayButton.Name = "displayButton";
            this.displayButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.displayButton.Size = new System.Drawing.Size(278, 70);
            this.displayButton.TabIndex = 7;
            this.displayButton.Text = "Display Data";
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // panel_scoreSubmenu
            // 
            this.panel_scoreSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(200)))));
            this.panel_scoreSubmenu.Controls.Add(this.button_scorePrint);
            this.panel_scoreSubmenu.Controls.Add(this.button_manageScore);
            this.panel_scoreSubmenu.Controls.Add(this.button_newScore);
            this.panel_scoreSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_scoreSubmenu.Location = new System.Drawing.Point(0, 556);
            this.panel_scoreSubmenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_scoreSubmenu.Name = "panel_scoreSubmenu";
            this.panel_scoreSubmenu.Size = new System.Drawing.Size(278, 159);
            this.panel_scoreSubmenu.TabIndex = 6;
            // 
            // button_scorePrint
            // 
            this.button_scorePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_scorePrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_scorePrint.FlatAppearance.BorderSize = 0;
            this.button_scorePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scorePrint.ForeColor = System.Drawing.Color.White;
            this.button_scorePrint.Location = new System.Drawing.Point(0, 108);
            this.button_scorePrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_scorePrint.Name = "button_scorePrint";
            this.button_scorePrint.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.button_scorePrint.Size = new System.Drawing.Size(278, 56);
            this.button_scorePrint.TabIndex = 3;
            this.button_scorePrint.Text = "Working hours";
            this.button_scorePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_scorePrint.UseVisualStyleBackColor = false;
            // 
            // button_manageScore
            // 
            this.button_manageScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_manageScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_manageScore.FlatAppearance.BorderSize = 0;
            this.button_manageScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageScore.ForeColor = System.Drawing.Color.White;
            this.button_manageScore.Location = new System.Drawing.Point(0, 52);
            this.button_manageScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_manageScore.Name = "button_manageScore";
            this.button_manageScore.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.button_manageScore.Size = new System.Drawing.Size(278, 56);
            this.button_manageScore.TabIndex = 1;
            this.button_manageScore.Text = "Salary";
            this.button_manageScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_manageScore.UseVisualStyleBackColor = false;
            // 
            // button_newScore
            // 
            this.button_newScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_newScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newScore.FlatAppearance.BorderSize = 0;
            this.button_newScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newScore.ForeColor = System.Drawing.Color.White;
            this.button_newScore.Location = new System.Drawing.Point(0, 0);
            this.button_newScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_newScore.Name = "button_newScore";
            this.button_newScore.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.button_newScore.Size = new System.Drawing.Size(278, 52);
            this.button_newScore.TabIndex = 0;
            this.button_newScore.Text = "Full-time/ Part-time";
            this.button_newScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newScore.UseVisualStyleBackColor = false;
            // 
            // button_admin
            // 
            this.button_admin.BackColor = System.Drawing.Color.Navy;
            this.button_admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_admin.FlatAppearance.BorderSize = 0;
            this.button_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_admin.ForeColor = System.Drawing.Color.White;
            this.button_admin.Location = new System.Drawing.Point(0, 483);
            this.button_admin.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_admin.Name = "button_admin";
            this.button_admin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_admin.Size = new System.Drawing.Size(278, 73);
            this.button_admin.TabIndex = 5;
            this.button_admin.Text = "Administration";
            this.button_admin.UseVisualStyleBackColor = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // panel_courseSubmenu
            // 
            this.panel_courseSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(200)))));
            this.panel_courseSubmenu.Controls.Add(this.button_manageCourse);
            this.panel_courseSubmenu.Controls.Add(this.button_newCourse);
            this.panel_courseSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_courseSubmenu.Location = new System.Drawing.Point(0, 373);
            this.panel_courseSubmenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_courseSubmenu.Name = "panel_courseSubmenu";
            this.panel_courseSubmenu.Size = new System.Drawing.Size(278, 110);
            this.panel_courseSubmenu.TabIndex = 4;
            // 
            // button_manageCourse
            // 
            this.button_manageCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_manageCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_manageCourse.FlatAppearance.BorderSize = 0;
            this.button_manageCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageCourse.ForeColor = System.Drawing.Color.White;
            this.button_manageCourse.Location = new System.Drawing.Point(0, 59);
            this.button_manageCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_manageCourse.Name = "button_manageCourse";
            this.button_manageCourse.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.button_manageCourse.Size = new System.Drawing.Size(278, 53);
            this.button_manageCourse.TabIndex = 1;
            this.button_manageCourse.Text = "Subjects Taught";
            this.button_manageCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_manageCourse.UseVisualStyleBackColor = false;
            // 
            // button_newCourse
            // 
            this.button_newCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_newCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newCourse.FlatAppearance.BorderSize = 0;
            this.button_newCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newCourse.ForeColor = System.Drawing.Color.White;
            this.button_newCourse.Location = new System.Drawing.Point(0, 0);
            this.button_newCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_newCourse.Name = "button_newCourse";
            this.button_newCourse.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.button_newCourse.Size = new System.Drawing.Size(278, 59);
            this.button_newCourse.TabIndex = 0;
            this.button_newCourse.Text = "Salary";
            this.button_newCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newCourse.UseVisualStyleBackColor = false;
            // 
            // button_teacher
            // 
            this.button_teacher.BackColor = System.Drawing.Color.Navy;
            this.button_teacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_teacher.FlatAppearance.BorderSize = 0;
            this.button_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_teacher.ForeColor = System.Drawing.Color.White;
            this.button_teacher.Location = new System.Drawing.Point(0, 300);
            this.button_teacher.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_teacher.Name = "button_teacher";
            this.button_teacher.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_teacher.Size = new System.Drawing.Size(278, 73);
            this.button_teacher.TabIndex = 3;
            this.button_teacher.Text = "Teaching Staff";
            this.button_teacher.UseVisualStyleBackColor = false;
            this.button_teacher.Click += new System.EventHandler(this.button_teacher_Click);
            // 
            // panel_stdsubmenu
            // 
            this.panel_stdsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(200)))));
            this.panel_stdsubmenu.Controls.Add(this.button_manageStd);
            this.panel_stdsubmenu.Controls.Add(this.button_registration);
            this.panel_stdsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stdsubmenu.Location = new System.Drawing.Point(0, 185);
            this.panel_stdsubmenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_stdsubmenu.Name = "panel_stdsubmenu";
            this.panel_stdsubmenu.Size = new System.Drawing.Size(278, 115);
            this.panel_stdsubmenu.TabIndex = 2;
            // 
            // button_manageStd
            // 
            this.button_manageStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_manageStd.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_manageStd.FlatAppearance.BorderSize = 0;
            this.button_manageStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageStd.ForeColor = System.Drawing.Color.White;
            this.button_manageStd.Location = new System.Drawing.Point(0, 56);
            this.button_manageStd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_manageStd.Name = "button_manageStd";
            this.button_manageStd.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.button_manageStd.Size = new System.Drawing.Size(278, 62);
            this.button_manageStd.TabIndex = 1;
            this.button_manageStd.Text = "All Previous Subjects";
            this.button_manageStd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_manageStd.UseVisualStyleBackColor = false;
            // 
            // button_registration
            // 
            this.button_registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_registration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_registration.FlatAppearance.BorderSize = 0;
            this.button_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registration.ForeColor = System.Drawing.Color.White;
            this.button_registration.Location = new System.Drawing.Point(0, 0);
            this.button_registration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_registration.Name = "button_registration";
            this.button_registration.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.button_registration.Size = new System.Drawing.Size(278, 56);
            this.button_registration.TabIndex = 0;
            this.button_registration.Text = "All Current Subjects";
            this.button_registration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_registration.UseVisualStyleBackColor = false;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // button_std
            // 
            this.button_std.BackColor = System.Drawing.Color.Navy;
            this.button_std.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_std.FlatAppearance.BorderSize = 0;
            this.button_std.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_std.ForeColor = System.Drawing.Color.White;
            this.button_std.Location = new System.Drawing.Point(0, 118);
            this.button_std.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_std.Name = "button_std";
            this.button_std.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_std.Size = new System.Drawing.Size(278, 67);
            this.button_std.TabIndex = 1;
            this.button_std.Text = "Student";
            this.button_std.UseVisualStyleBackColor = false;
            this.button_std.Click += new System.EventHandler(this.button_std_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Controls.Add(this.label_role);
            this.panel_logo.Controls.Add(this.label_user);
            this.panel_logo.Controls.Add(this.label5);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(278, 118);
            this.panel_logo.TabIndex = 0;
            this.panel_logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_logo_Paint);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(134, 26);
            this.label_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(100, 25);
            this.label_user.TabIndex = 2;
            this.label_user.Text = "The Baor";
            this.label_user.Click += new System.EventHandler(this.label_user_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(200)))));
            this.label12.Location = new System.Drawing.Point(12, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(468, 37);
            this.label12.TabIndex = 0;
            this.label12.Text = "Desktop Management System";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // roleFilterComboBox
            // 
            this.roleFilterComboBox.FormattingEnabled = true;
            this.roleFilterComboBox.Items.AddRange(new object[] {
            "All"});
            this.roleFilterComboBox.Location = new System.Drawing.Point(19, 68);
            this.roleFilterComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roleFilterComboBox.Name = "roleFilterComboBox";
            this.roleFilterComboBox.Size = new System.Drawing.Size(180, 33);
            this.roleFilterComboBox.TabIndex = 9;
            this.roleFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.roleFilterComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roleFilterComboBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1670, 118);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1948, 983);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_slide);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form2";
            this.panel_main.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.student_gridData)).EndInit();
            this.panel_slide.ResumeLayout(false);
            this.panel_scoreSubmenu.ResumeLayout(false);
            this.panel_courseSubmenu.ResumeLayout(false);
            this.panel_stdsubmenu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Panel panel_scoreSubmenu;
        private System.Windows.Forms.Button button_scorePrint;
        private System.Windows.Forms.Button button_manageScore;
        private System.Windows.Forms.Button button_newScore;
        private System.Windows.Forms.Button button_admin;
        private System.Windows.Forms.Panel panel_courseSubmenu;
        private System.Windows.Forms.Button button_manageCourse;
        private System.Windows.Forms.Button button_newCourse;
        private System.Windows.Forms.Button button_teacher;
        private System.Windows.Forms.Panel panel_stdsubmenu;
        private System.Windows.Forms.Button button_manageStd;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Button button_std;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.DataGridView student_gridData;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox roleFilterComboBox;
        private System.Windows.Forms.Label label12;
    }
}