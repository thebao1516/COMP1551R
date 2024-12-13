namespace Main_Project
{
    partial class AddTeachersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_deleteBtn = new System.Windows.Forms.Button();
            this.teacher_clearBtn = new System.Windows.Forms.Button();
            this.teacher_updateBtn = new System.Windows.Forms.Button();
            this.teacher_addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacher_gridData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.teacher_subject_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.teacher_email = new System.Windows.Forms.TextBox();
            this.teacher_phone = new System.Windows.Forms.TextBox();
            this.teacher_salary = new System.Windows.Forms.TextBox();
            this.teacher_subject_1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher\'s Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // teacher_deleteBtn
            // 
            this.teacher_deleteBtn.BackColor = System.Drawing.Color.Maroon;
            this.teacher_deleteBtn.FlatAppearance.BorderSize = 0;
            this.teacher_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_deleteBtn.Location = new System.Drawing.Point(45, 768);
            this.teacher_deleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.teacher_deleteBtn.Name = "teacher_deleteBtn";
            this.teacher_deleteBtn.Size = new System.Drawing.Size(204, 67);
            this.teacher_deleteBtn.TabIndex = 17;
            this.teacher_deleteBtn.Text = "Delete";
            this.teacher_deleteBtn.UseVisualStyleBackColor = false;
            this.teacher_deleteBtn.Click += new System.EventHandler(this.teacher_deleteBtn_Click);
            // 
            // teacher_clearBtn
            // 
            this.teacher_clearBtn.BackColor = System.Drawing.Color.Navy;
            this.teacher_clearBtn.FlatAppearance.BorderSize = 0;
            this.teacher_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_clearBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_clearBtn.Location = new System.Drawing.Point(1057, 842);
            this.teacher_clearBtn.Margin = new System.Windows.Forms.Padding(6);
            this.teacher_clearBtn.Name = "teacher_clearBtn";
            this.teacher_clearBtn.Size = new System.Drawing.Size(204, 67);
            this.teacher_clearBtn.TabIndex = 16;
            this.teacher_clearBtn.Text = "Clear";
            this.teacher_clearBtn.UseVisualStyleBackColor = false;
            this.teacher_clearBtn.Click += new System.EventHandler(this.teacher_clearBtn_Click);
            // 
            // teacher_updateBtn
            // 
            this.teacher_updateBtn.BackColor = System.Drawing.Color.Navy;
            this.teacher_updateBtn.FlatAppearance.BorderSize = 0;
            this.teacher_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_updateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_updateBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_updateBtn.Location = new System.Drawing.Point(536, 509);
            this.teacher_updateBtn.Margin = new System.Windows.Forms.Padding(6);
            this.teacher_updateBtn.Name = "teacher_updateBtn";
            this.teacher_updateBtn.Size = new System.Drawing.Size(204, 67);
            this.teacher_updateBtn.TabIndex = 15;
            this.teacher_updateBtn.Text = "Update";
            this.teacher_updateBtn.UseVisualStyleBackColor = false;
            this.teacher_updateBtn.Click += new System.EventHandler(this.teacher_updateBtn_Click);
            // 
            // teacher_addBtn
            // 
            this.teacher_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teacher_addBtn.FlatAppearance.BorderSize = 0;
            this.teacher_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_addBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_addBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_addBtn.Location = new System.Drawing.Point(536, 428);
            this.teacher_addBtn.Margin = new System.Windows.Forms.Padding(6);
            this.teacher_addBtn.Name = "teacher_addBtn";
            this.teacher_addBtn.Size = new System.Drawing.Size(204, 67);
            this.teacher_addBtn.TabIndex = 14;
            this.teacher_addBtn.Text = "Add";
            this.teacher_addBtn.UseVisualStyleBackColor = false;
            this.teacher_addBtn.Click += new System.EventHandler(this.teacher_addBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.teacher_gridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.teacher_clearBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1558, 973);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // teacher_gridData
            // 
            this.teacher_gridData.AllowUserToResizeRows = false;
            this.teacher_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.teacher_gridData.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacher_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teacher_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_gridData.EnableHeadersVisualStyles = false;
            this.teacher_gridData.Location = new System.Drawing.Point(845, 69);
            this.teacher_gridData.Margin = new System.Windows.Forms.Padding(6);
            this.teacher_gridData.Name = "teacher_gridData";
            this.teacher_gridData.ReadOnly = true;
            this.teacher_gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.teacher_gridData.RowHeadersVisible = false;
            this.teacher_gridData.RowHeadersWidth = 51;
            this.teacher_gridData.Size = new System.Drawing.Size(643, 746);
            this.teacher_gridData.TabIndex = 1;
            this.teacher_gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacher_gridData_CellClick);
            this.teacher_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacher_gridData_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 459);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Subject 1";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // teacher_subject_2
            // 
            this.teacher_subject_2.Location = new System.Drawing.Point(173, 509);
            this.teacher_subject_2.Margin = new System.Windows.Forms.Padding(6);
            this.teacher_subject_2.Multiline = true;
            this.teacher_subject_2.Name = "teacher_subject_2";
            this.teacher_subject_2.Size = new System.Drawing.Size(333, 45);
            this.teacher_subject_2.TabIndex = 7;
            this.teacher_subject_2.TextChanged += new System.EventHandler(this.teacher_subject_2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 529);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subject 2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salary:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // teacher_name
            // 
            this.teacher_name.Location = new System.Drawing.Point(173, 111);
            this.teacher_name.Margin = new System.Windows.Forms.Padding(6);
            this.teacher_name.Multiline = true;
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(535, 45);
            this.teacher_name.TabIndex = 3;
            this.teacher_name.TextChanged += new System.EventHandler(this.teacher_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // teacher_id
            // 
            this.teacher_id.Location = new System.Drawing.Point(173, 41);
            this.teacher_id.Margin = new System.Windows.Forms.Padding(6);
            this.teacher_id.Multiline = true;
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.Size = new System.Drawing.Size(535, 45);
            this.teacher_id.TabIndex = 1;
            this.teacher_id.TextChanged += new System.EventHandler(this.teacher_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teacher ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.teacher_email);
            this.panel2.Controls.Add(this.teacher_phone);
            this.panel2.Controls.Add(this.teacher_salary);
            this.panel2.Controls.Add(this.teacher_subject_1);
            this.panel2.Controls.Add(this.teacher_deleteBtn);
            this.panel2.Controls.Add(this.teacher_updateBtn);
            this.panel2.Controls.Add(this.teacher_addBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.teacher_subject_2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teacher_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.teacher_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 899);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-6, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email:";
            // 
            // teacher_email
            // 
            this.teacher_email.Location = new System.Drawing.Point(173, 323);
            this.teacher_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacher_email.Name = "teacher_email";
            this.teacher_email.Size = new System.Drawing.Size(535, 31);
            this.teacher_email.TabIndex = 21;
            // 
            // teacher_phone
            // 
            this.teacher_phone.Location = new System.Drawing.Point(173, 259);
            this.teacher_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacher_phone.Name = "teacher_phone";
            this.teacher_phone.Size = new System.Drawing.Size(535, 31);
            this.teacher_phone.TabIndex = 20;
            // 
            // teacher_salary
            // 
            this.teacher_salary.Location = new System.Drawing.Point(173, 200);
            this.teacher_salary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacher_salary.Name = "teacher_salary";
            this.teacher_salary.Size = new System.Drawing.Size(535, 31);
            this.teacher_salary.TabIndex = 19;
            this.teacher_salary.TextChanged += new System.EventHandler(this.teacher_salary_TextChanged);
            // 
            // teacher_subject_1
            // 
            this.teacher_subject_1.Location = new System.Drawing.Point(173, 449);
            this.teacher_subject_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacher_subject_1.Name = "teacher_subject_1";
            this.teacher_subject_1.Size = new System.Drawing.Size(333, 31);
            this.teacher_subject_1.TabIndex = 18;
            this.teacher_subject_1.TextChanged += new System.EventHandler(this.teacher_subject_1_TextChanged);
            // 
            // AddTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 973);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTeachersForm";
            this.Text = "Teacher Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teacher_deleteBtn;
        private System.Windows.Forms.Button teacher_clearBtn;
        private System.Windows.Forms.Button teacher_updateBtn;
        private System.Windows.Forms.Button teacher_addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView teacher_gridData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teacher_subject_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox teacher_subject_1;
        private System.Windows.Forms.TextBox teacher_salary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teacher_email;
        private System.Windows.Forms.TextBox teacher_phone;
    }
}