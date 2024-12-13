namespace Main_Project
{
    partial class AddAdminsForm
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
            this.admin_deleteBtn = new System.Windows.Forms.Button();
            this.admin_clearBtn = new System.Windows.Forms.Button();
            this.admin_updateBtn = new System.Windows.Forms.Button();
            this.admin_addBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admin_phone = new System.Windows.Forms.TextBox();
            this.working_hours = new System.Windows.Forms.TextBox();
            this.admin_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.admin_salary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.admin_position = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_gridData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_deleteBtn
            // 
            this.admin_deleteBtn.BackColor = System.Drawing.Color.Maroon;
            this.admin_deleteBtn.FlatAppearance.BorderSize = 0;
            this.admin_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.admin_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.admin_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.admin_deleteBtn.Location = new System.Drawing.Point(31, 762);
            this.admin_deleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.admin_deleteBtn.Name = "admin_deleteBtn";
            this.admin_deleteBtn.Size = new System.Drawing.Size(204, 67);
            this.admin_deleteBtn.TabIndex = 17;
            this.admin_deleteBtn.Text = "Delete";
            this.admin_deleteBtn.UseVisualStyleBackColor = false;
            this.admin_deleteBtn.Click += new System.EventHandler(this.admin_deleteBtn_Click);
            // 
            // admin_clearBtn
            // 
            this.admin_clearBtn.BackColor = System.Drawing.Color.Navy;
            this.admin_clearBtn.FlatAppearance.BorderSize = 0;
            this.admin_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.admin_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.admin_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_clearBtn.ForeColor = System.Drawing.Color.White;
            this.admin_clearBtn.Location = new System.Drawing.Point(1189, 853);
            this.admin_clearBtn.Margin = new System.Windows.Forms.Padding(6);
            this.admin_clearBtn.Name = "admin_clearBtn";
            this.admin_clearBtn.Size = new System.Drawing.Size(204, 67);
            this.admin_clearBtn.TabIndex = 16;
            this.admin_clearBtn.Text = "Clear";
            this.admin_clearBtn.UseVisualStyleBackColor = false;
            this.admin_clearBtn.Click += new System.EventHandler(this.admin_clearBtn_Click);
            // 
            // admin_updateBtn
            // 
            this.admin_updateBtn.BackColor = System.Drawing.Color.Navy;
            this.admin_updateBtn.FlatAppearance.BorderSize = 0;
            this.admin_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.admin_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.admin_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_updateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_updateBtn.ForeColor = System.Drawing.Color.White;
            this.admin_updateBtn.Location = new System.Drawing.Point(616, 578);
            this.admin_updateBtn.Margin = new System.Windows.Forms.Padding(6);
            this.admin_updateBtn.Name = "admin_updateBtn";
            this.admin_updateBtn.Size = new System.Drawing.Size(204, 67);
            this.admin_updateBtn.TabIndex = 15;
            this.admin_updateBtn.Text = "Update";
            this.admin_updateBtn.UseVisualStyleBackColor = false;
            this.admin_updateBtn.Click += new System.EventHandler(this.admin_updateBtn_Click);
            // 
            // admin_addBtn
            // 
            this.admin_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.admin_addBtn.FlatAppearance.BorderSize = 0;
            this.admin_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.admin_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.admin_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_addBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_addBtn.ForeColor = System.Drawing.Color.White;
            this.admin_addBtn.Location = new System.Drawing.Point(616, 494);
            this.admin_addBtn.Margin = new System.Windows.Forms.Padding(6);
            this.admin_addBtn.Name = "admin_addBtn";
            this.admin_addBtn.Size = new System.Drawing.Size(204, 67);
            this.admin_addBtn.TabIndex = 14;
            this.admin_addBtn.Text = "Add";
            this.admin_addBtn.UseVisualStyleBackColor = false;
            this.admin_addBtn.Click += new System.EventHandler(this.admin_addBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.admin_phone);
            this.panel2.Controls.Add(this.working_hours);
            this.panel2.Controls.Add(this.admin_email);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.admin_salary);
            this.panel2.Controls.Add(this.admin_deleteBtn);
            this.panel2.Controls.Add(this.admin_updateBtn);
            this.panel2.Controls.Add(this.admin_addBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.admin_position);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.admin_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.admin_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 915);
            this.panel2.TabIndex = 9;
            // 
            // admin_phone
            // 
            this.admin_phone.Location = new System.Drawing.Point(160, 235);
            this.admin_phone.Margin = new System.Windows.Forms.Padding(6);
            this.admin_phone.Multiline = true;
            this.admin_phone.Name = "admin_phone";
            this.admin_phone.Size = new System.Drawing.Size(580, 40);
            this.admin_phone.TabIndex = 27;
            // 
            // working_hours
            // 
            this.working_hours.Location = new System.Drawing.Point(238, 486);
            this.working_hours.Margin = new System.Windows.Forms.Padding(6);
            this.working_hours.Multiline = true;
            this.working_hours.Name = "working_hours";
            this.working_hours.Size = new System.Drawing.Size(284, 40);
            this.working_hours.TabIndex = 26;
            // 
            // admin_email
            // 
            this.admin_email.Location = new System.Drawing.Point(160, 319);
            this.admin_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admin_email.Name = "admin_email";
            this.admin_email.Size = new System.Drawing.Size(580, 31);
            this.admin_email.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 578);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Phone No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Email:";
            // 
            // admin_salary
            // 
            this.admin_salary.Location = new System.Drawing.Point(160, 182);
            this.admin_salary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admin_salary.Name = "admin_salary";
            this.admin_salary.Size = new System.Drawing.Size(580, 31);
            this.admin_salary.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 494);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Working Hours";
            // 
            // admin_position
            // 
            this.admin_position.Location = new System.Drawing.Point(238, 578);
            this.admin_position.Margin = new System.Windows.Forms.Padding(6);
            this.admin_position.Multiline = true;
            this.admin_position.Name = "admin_position";
            this.admin_position.Size = new System.Drawing.Size(284, 40);
            this.admin_position.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salary:";
            // 
            // admin_name
            // 
            this.admin_name.Location = new System.Drawing.Point(160, 111);
            this.admin_name.Margin = new System.Windows.Forms.Padding(6);
            this.admin_name.Multiline = true;
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(580, 45);
            this.admin_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // admin_id
            // 
            this.admin_id.Location = new System.Drawing.Point(160, 41);
            this.admin_id.Margin = new System.Windows.Forms.Padding(6);
            this.admin_id.Multiline = true;
            this.admin_id.Name = "admin_id";
            this.admin_id.Size = new System.Drawing.Size(580, 45);
            this.admin_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Admin ID:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.admin_gridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.admin_clearBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1706, 1002);
            this.panel1.TabIndex = 8;
            // 
            // admin_gridData
            // 
            this.admin_gridData.AllowUserToResizeRows = false;
            this.admin_gridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.admin_gridData.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.admin_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_gridData.EnableHeadersVisualStyles = false;
            this.admin_gridData.Location = new System.Drawing.Point(921, 91);
            this.admin_gridData.Margin = new System.Windows.Forms.Padding(6);
            this.admin_gridData.Name = "admin_gridData";
            this.admin_gridData.ReadOnly = true;
            this.admin_gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.admin_gridData.RowHeadersVisible = false;
            this.admin_gridData.RowHeadersWidth = 51;
            this.admin_gridData.Size = new System.Drawing.Size(747, 728);
            this.admin_gridData.TabIndex = 1;
            this.admin_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_gridData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin\'s Data";
            // 
            // AddAdminsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 1003);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddAdminsForm";
            this.Text = "Admin Form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button admin_deleteBtn;
        private System.Windows.Forms.Button admin_clearBtn;
        private System.Windows.Forms.Button admin_updateBtn;
        private System.Windows.Forms.Button admin_addBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox admin_salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox admin_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox admin_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox admin_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView admin_gridData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admin_email;
        private System.Windows.Forms.TextBox admin_phone;
        private System.Windows.Forms.TextBox working_hours;
    }
}