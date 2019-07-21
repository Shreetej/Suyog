namespace Suyog
{
    partial class Employee
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
            this.EmployeeTab = new System.Windows.Forms.TabControl();
            this.listOfEmployees = new System.Windows.Forms.TabPage();
            this.dg_employees = new System.Windows.Forms.DataGridView();
            this.AddEmployee = new System.Windows.Forms.TabPage();
            this.ViewEmployee = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_dob = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_save = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EmployeeTab.SuspendLayout();
            this.listOfEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_employees)).BeginInit();
            this.AddEmployee.SuspendLayout();
            this.ViewEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.listOfEmployees);
            this.EmployeeTab.Controls.Add(this.AddEmployee);
            this.EmployeeTab.Controls.Add(this.ViewEmployee);
            this.EmployeeTab.Location = new System.Drawing.Point(47, 89);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.SelectedIndex = 0;
            this.EmployeeTab.Size = new System.Drawing.Size(916, 376);
            this.EmployeeTab.TabIndex = 1;
            this.EmployeeTab.SelectedIndexChanged += new System.EventHandler(this.EmployeeTab_SelectedIndexChanged);
            // 
            // listOfEmployees
            // 
            this.listOfEmployees.Controls.Add(this.dg_employees);
            this.listOfEmployees.Location = new System.Drawing.Point(4, 22);
            this.listOfEmployees.Name = "listOfEmployees";
            this.listOfEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.listOfEmployees.Size = new System.Drawing.Size(908, 350);
            this.listOfEmployees.TabIndex = 0;
            this.listOfEmployees.Text = "List of employees";
            this.listOfEmployees.UseVisualStyleBackColor = true;
            // 
            // dg_employees
            // 
            this.dg_employees.AllowUserToAddRows = false;
            this.dg_employees.AllowUserToDeleteRows = false;
            this.dg_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_employees.Location = new System.Drawing.Point(3, 3);
            this.dg_employees.Name = "dg_employees";
            this.dg_employees.ReadOnly = true;
            this.dg_employees.Size = new System.Drawing.Size(902, 344);
            this.dg_employees.TabIndex = 0;
            this.dg_employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_employees_CellContentClick);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Controls.Add(this.btn_save);
            this.AddEmployee.Controls.Add(this.label7);
            this.AddEmployee.Controls.Add(this.textBox3);
            this.AddEmployee.Controls.Add(this.label6);
            this.AddEmployee.Controls.Add(this.textBox2);
            this.AddEmployee.Controls.Add(this.label5);
            this.AddEmployee.Controls.Add(this.textBox1);
            this.AddEmployee.Controls.Add(this.label4);
            this.AddEmployee.Controls.Add(this.dateTimePicker2);
            this.AddEmployee.Controls.Add(this.dateTimePicker1);
            this.AddEmployee.Controls.Add(this.label3);
            this.AddEmployee.Controls.Add(this.lb_dob);
            this.AddEmployee.Controls.Add(this.rtb_address);
            this.AddEmployee.Controls.Add(this.lb_address);
            this.AddEmployee.Controls.Add(this.tb_name);
            this.AddEmployee.Controls.Add(this.label2);
            this.AddEmployee.Location = new System.Drawing.Point(4, 22);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmployee.Size = new System.Drawing.Size(908, 350);
            this.AddEmployee.TabIndex = 1;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // ViewEmployee
            // 
            this.ViewEmployee.Controls.Add(this.textBox5);
            this.ViewEmployee.Controls.Add(this.label10);
            this.ViewEmployee.Controls.Add(this.richTextBox1);
            this.ViewEmployee.Controls.Add(this.label9);
            this.ViewEmployee.Controls.Add(this.textBox4);
            this.ViewEmployee.Controls.Add(this.label8);
            this.ViewEmployee.Location = new System.Drawing.Point(4, 22);
            this.ViewEmployee.Name = "ViewEmployee";
            this.ViewEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.ViewEmployee.Size = new System.Drawing.Size(908, 350);
            this.ViewEmployee.TabIndex = 2;
            this.ViewEmployee.Text = "View Employee";
            this.ViewEmployee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(97, 26);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(213, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // lb_dob
            // 
            this.lb_dob.AutoSize = true;
            this.lb_dob.Location = new System.Drawing.Point(425, 29);
            this.lb_dob.Name = "lb_dob";
            this.lb_dob.Size = new System.Drawing.Size(71, 13);
            this.lb_dob.TabIndex = 4;
            this.lb_dob.Text = "Date of birth :";
            this.lb_dob.Click += new System.EventHandler(this.lb_dob_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of joining :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(512, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mobile :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(513, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aadhar :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(512, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pan Card :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Upload\r\nDocuments :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(365, 301);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(40, 74);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(51, 13);
            this.lb_address.TabIndex = 2;
            this.lb_address.Text = "Address :";
            this.lb_address.Click += new System.EventHandler(this.lb_address_Click);
            // 
            // rtb_address
            // 
            this.rtb_address.Location = new System.Drawing.Point(97, 71);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.Size = new System.Drawing.Size(213, 96);
            this.rtb_address.TabIndex = 3;
            this.rtb_address.Text = "";
            this.rtb_address.TextChanged += new System.EventHandler(this.rtb_address_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(90, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Address :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(523, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(213, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mobile :";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeTab);
            this.Name = "Employee";
            this.Text = "Employee";
            this.EmployeeTab.ResumeLayout(false);
            this.listOfEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_employees)).EndInit();
            this.AddEmployee.ResumeLayout(false);
            this.AddEmployee.PerformLayout();
            this.ViewEmployee.ResumeLayout(false);
            this.ViewEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl EmployeeTab;
        private System.Windows.Forms.TabPage listOfEmployees;
        private System.Windows.Forms.DataGridView dg_employees;
        private System.Windows.Forms.TabPage AddEmployee;
        private System.Windows.Forms.TabPage ViewEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_dob;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
    }
}