namespace Suyog
{
    partial class EmployeeDetails
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
            this.btn_uppancard = new System.Windows.Forms.Button();
            this.btn_upaadhar = new System.Windows.Forms.Button();
            this.btn_upphoto = new System.Windows.Forms.Button();
            this.lbl_pancardimg = new System.Windows.Forms.Label();
            this.lbl_aadharimg = new System.Windows.Forms.Label();
            this.lbl_photo = new System.Windows.Forms.Label();
            this.pb_pancard = new System.Windows.Forms.PictureBox();
            this.pb_aadhar = new System.Windows.Forms.PictureBox();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_pan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_aadhar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_doj = new System.Windows.Forms.DateTimePicker();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_dob = new System.Windows.Forms.Label();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewEmployee = new System.Windows.Forms.TabPage();
            this.btnv_pan = new System.Windows.Forms.Button();
            this.btnv_aadhar = new System.Windows.Forms.Button();
            this.btnv_upphoto = new System.Windows.Forms.Button();
            this.pbv_pancard = new System.Windows.Forms.PictureBox();
            this.pbv_aadhar = new System.Windows.Forms.PictureBox();
            this.pbv_photo = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tbv_pan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbv_aadhar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpv_doj = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpv_dob = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tbv_mobile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbv_address = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbv_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_saveEdit = new System.Windows.Forms.Button();
            this.btn_cancelEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_empId = new System.Windows.Forms.Label();
            this.empIdTxt = new System.Windows.Forms.Label();
            this.EmployeeTab.SuspendLayout();
            this.listOfEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_employees)).BeginInit();
            this.AddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pancard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aadhar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.ViewEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbv_pancard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbv_aadhar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbv_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.listOfEmployees);
            this.EmployeeTab.Controls.Add(this.AddEmployee);
            this.EmployeeTab.Controls.Add(this.ViewEmployee);
            this.EmployeeTab.Location = new System.Drawing.Point(12, 4);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.SelectedIndex = 0;
            this.EmployeeTab.Size = new System.Drawing.Size(824, 509);
            this.EmployeeTab.TabIndex = 1;
            this.EmployeeTab.SelectedIndexChanged += new System.EventHandler(this.EmployeeTab_SelectedIndexChanged);
            // 
            // listOfEmployees
            // 
            this.listOfEmployees.Controls.Add(this.dg_employees);
            this.listOfEmployees.Location = new System.Drawing.Point(4, 22);
            this.listOfEmployees.Name = "listOfEmployees";
            this.listOfEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.listOfEmployees.Size = new System.Drawing.Size(816, 483);
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
            this.dg_employees.Size = new System.Drawing.Size(810, 477);
            this.dg_employees.TabIndex = 0;
            this.dg_employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_employees_CellContentClick);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Controls.Add(this.btn_uppancard);
            this.AddEmployee.Controls.Add(this.btn_upaadhar);
            this.AddEmployee.Controls.Add(this.btn_upphoto);
            this.AddEmployee.Controls.Add(this.lbl_pancardimg);
            this.AddEmployee.Controls.Add(this.lbl_aadharimg);
            this.AddEmployee.Controls.Add(this.lbl_photo);
            this.AddEmployee.Controls.Add(this.pb_pancard);
            this.AddEmployee.Controls.Add(this.pb_aadhar);
            this.AddEmployee.Controls.Add(this.pb_photo);
            this.AddEmployee.Controls.Add(this.btn_save);
            this.AddEmployee.Controls.Add(this.label7);
            this.AddEmployee.Controls.Add(this.tb_pan);
            this.AddEmployee.Controls.Add(this.label6);
            this.AddEmployee.Controls.Add(this.tb_aadhar);
            this.AddEmployee.Controls.Add(this.label5);
            this.AddEmployee.Controls.Add(this.tb_mobile);
            this.AddEmployee.Controls.Add(this.label4);
            this.AddEmployee.Controls.Add(this.dtp_doj);
            this.AddEmployee.Controls.Add(this.dtp_dob);
            this.AddEmployee.Controls.Add(this.label3);
            this.AddEmployee.Controls.Add(this.lb_dob);
            this.AddEmployee.Controls.Add(this.rtb_address);
            this.AddEmployee.Controls.Add(this.lb_address);
            this.AddEmployee.Controls.Add(this.tb_name);
            this.AddEmployee.Controls.Add(this.label2);
            this.AddEmployee.Location = new System.Drawing.Point(4, 22);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmployee.Size = new System.Drawing.Size(816, 483);
            this.AddEmployee.TabIndex = 1;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // btn_uppancard
            // 
            this.btn_uppancard.Location = new System.Drawing.Point(610, 400);
            this.btn_uppancard.Name = "btn_uppancard";
            this.btn_uppancard.Size = new System.Drawing.Size(94, 23);
            this.btn_uppancard.TabIndex = 25;
            this.btn_uppancard.Text = "Upload Pancard";
            this.btn_uppancard.UseVisualStyleBackColor = true;
            this.btn_uppancard.Click += new System.EventHandler(this.btn_uppancard_Click);
            // 
            // btn_upaadhar
            // 
            this.btn_upaadhar.Location = new System.Drawing.Point(382, 400);
            this.btn_upaadhar.Name = "btn_upaadhar";
            this.btn_upaadhar.Size = new System.Drawing.Size(88, 23);
            this.btn_upaadhar.TabIndex = 24;
            this.btn_upaadhar.Text = "Upload Aadhar";
            this.btn_upaadhar.UseVisualStyleBackColor = true;
            this.btn_upaadhar.Click += new System.EventHandler(this.btn_upaadhar_Click);
            // 
            // btn_upphoto
            // 
            this.btn_upphoto.Location = new System.Drawing.Point(154, 400);
            this.btn_upphoto.Name = "btn_upphoto";
            this.btn_upphoto.Size = new System.Drawing.Size(91, 23);
            this.btn_upphoto.TabIndex = 23;
            this.btn_upphoto.Text = "Upload Photo";
            this.btn_upphoto.UseVisualStyleBackColor = true;
            this.btn_upphoto.Click += new System.EventHandler(this.btn_upphoto_Click);
            // 
            // lbl_pancardimg
            // 
            this.lbl_pancardimg.AutoSize = true;
            this.lbl_pancardimg.Location = new System.Drawing.Point(625, 231);
            this.lbl_pancardimg.Name = "lbl_pancardimg";
            this.lbl_pancardimg.Size = new System.Drawing.Size(51, 13);
            this.lbl_pancardimg.TabIndex = 21;
            this.lbl_pancardimg.Text = "Pan Card";
            this.lbl_pancardimg.Click += new System.EventHandler(this.lbl_pancardimg_Click);
            // 
            // lbl_aadharimg
            // 
            this.lbl_aadharimg.AutoSize = true;
            this.lbl_aadharimg.Location = new System.Drawing.Point(392, 231);
            this.lbl_aadharimg.Name = "lbl_aadharimg";
            this.lbl_aadharimg.Size = new System.Drawing.Size(66, 13);
            this.lbl_aadharimg.TabIndex = 20;
            this.lbl_aadharimg.Text = "Aadhar Card";
            this.lbl_aadharimg.Click += new System.EventHandler(this.lbl_aadharimg_Click);
            // 
            // lbl_photo
            // 
            this.lbl_photo.AutoSize = true;
            this.lbl_photo.Location = new System.Drawing.Point(171, 231);
            this.lbl_photo.Name = "lbl_photo";
            this.lbl_photo.Size = new System.Drawing.Size(35, 13);
            this.lbl_photo.TabIndex = 19;
            this.lbl_photo.Text = "Photo";
            this.lbl_photo.Click += new System.EventHandler(this.lbl_photo_Click);
            // 
            // pb_pancard
            // 
            this.pb_pancard.Location = new System.Drawing.Point(582, 247);
            this.pb_pancard.Name = "pb_pancard";
            this.pb_pancard.Size = new System.Drawing.Size(143, 147);
            this.pb_pancard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pancard.TabIndex = 18;
            this.pb_pancard.TabStop = false;
            this.pb_pancard.Click += new System.EventHandler(this.pb_pancard_Click);
            // 
            // pb_aadhar
            // 
            this.pb_aadhar.Location = new System.Drawing.Point(353, 247);
            this.pb_aadhar.Name = "pb_aadhar";
            this.pb_aadhar.Size = new System.Drawing.Size(143, 147);
            this.pb_aadhar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_aadhar.TabIndex = 17;
            this.pb_aadhar.TabStop = false;
            this.pb_aadhar.Click += new System.EventHandler(this.pb_aadhar_Click);
            // 
            // pb_photo
            // 
            this.pb_photo.Location = new System.Drawing.Point(129, 247);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(143, 147);
            this.pb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_photo.TabIndex = 16;
            this.pb_photo.TabStop = false;
            this.pb_photo.Click += new System.EventHandler(this.pb_photo_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(395, 440);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            // tb_pan
            // 
            this.tb_pan.Location = new System.Drawing.Point(512, 179);
            this.tb_pan.Name = "tb_pan";
            this.tb_pan.Size = new System.Drawing.Size(213, 20);
            this.tb_pan.TabIndex = 13;
            this.tb_pan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pan Card :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_aadhar
            // 
            this.tb_aadhar.Location = new System.Drawing.Point(513, 143);
            this.tb_aadhar.Name = "tb_aadhar";
            this.tb_aadhar.Size = new System.Drawing.Size(213, 20);
            this.tb_aadhar.TabIndex = 11;
            this.tb_aadhar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aadhar :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_mobile
            // 
            this.tb_mobile.Location = new System.Drawing.Point(513, 108);
            this.tb_mobile.Name = "tb_mobile";
            this.tb_mobile.Size = new System.Drawing.Size(213, 20);
            this.tb_mobile.TabIndex = 9;
            this.tb_mobile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mobile :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtp_doj
            // 
            this.dtp_doj.Location = new System.Drawing.Point(512, 68);
            this.dtp_doj.Name = "dtp_doj";
            this.dtp_doj.Size = new System.Drawing.Size(157, 20);
            this.dtp_doj.TabIndex = 7;
            this.dtp_doj.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(512, 26);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(157, 20);
            this.dtp_dob.TabIndex = 6;
            this.dtp_dob.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            // rtb_address
            // 
            this.rtb_address.Location = new System.Drawing.Point(97, 71);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.Size = new System.Drawing.Size(213, 96);
            this.rtb_address.TabIndex = 3;
            this.rtb_address.Text = "";
            this.rtb_address.TextChanged += new System.EventHandler(this.rtb_address_TextChanged);
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
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(97, 26);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(213, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
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
            // ViewEmployee
            // 
            this.ViewEmployee.Controls.Add(this.empIdTxt);
            this.ViewEmployee.Controls.Add(this.lbl_empId);
            this.ViewEmployee.Controls.Add(this.label15);
            this.ViewEmployee.Controls.Add(this.label8);
            this.ViewEmployee.Controls.Add(this.label1);
            this.ViewEmployee.Controls.Add(this.btnv_pan);
            this.ViewEmployee.Controls.Add(this.btnv_aadhar);
            this.ViewEmployee.Controls.Add(this.btnv_upphoto);
            this.ViewEmployee.Controls.Add(this.pbv_pancard);
            this.ViewEmployee.Controls.Add(this.pbv_aadhar);
            this.ViewEmployee.Controls.Add(this.pbv_photo);
            this.ViewEmployee.Controls.Add(this.tbv_pan);
            this.ViewEmployee.Controls.Add(this.label14);
            this.ViewEmployee.Controls.Add(this.tbv_aadhar);
            this.ViewEmployee.Controls.Add(this.label13);
            this.ViewEmployee.Controls.Add(this.dtpv_doj);
            this.ViewEmployee.Controls.Add(this.label12);
            this.ViewEmployee.Controls.Add(this.dtpv_dob);
            this.ViewEmployee.Controls.Add(this.label11);
            this.ViewEmployee.Controls.Add(this.tbv_mobile);
            this.ViewEmployee.Controls.Add(this.label10);
            this.ViewEmployee.Controls.Add(this.rtbv_address);
            this.ViewEmployee.Controls.Add(this.label9);
            this.ViewEmployee.Controls.Add(this.tbv_name);
            this.ViewEmployee.Controls.Add(this.lb_name);
            this.ViewEmployee.Controls.Add(this.btn_saveEdit);
            this.ViewEmployee.Controls.Add(this.btn_edit);
            this.ViewEmployee.Controls.Add(this.btn_cancelEdit);
            this.ViewEmployee.Controls.Add(this.btn_delete);
            this.ViewEmployee.Location = new System.Drawing.Point(4, 22);
            this.ViewEmployee.Name = "ViewEmployee";
            this.ViewEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.ViewEmployee.Size = new System.Drawing.Size(816, 483);
            this.ViewEmployee.TabIndex = 2;
            this.ViewEmployee.Text = "View Employee";
            this.ViewEmployee.UseVisualStyleBackColor = true;
            // 
            // btnv_pan
            // 
            this.btnv_pan.Location = new System.Drawing.Point(581, 393);
            this.btnv_pan.Name = "btnv_pan";
            this.btnv_pan.Size = new System.Drawing.Size(94, 23);
            this.btnv_pan.TabIndex = 27;
            this.btnv_pan.Text = "Upload Pancard";
            this.btnv_pan.UseVisualStyleBackColor = true;
            this.btnv_pan.Click += new System.EventHandler(this.Btnv_pan_Click);
            // 
            // btnv_aadhar
            // 
            this.btnv_aadhar.Location = new System.Drawing.Point(373, 393);
            this.btnv_aadhar.Name = "btnv_aadhar";
            this.btnv_aadhar.Size = new System.Drawing.Size(89, 23);
            this.btnv_aadhar.TabIndex = 26;
            this.btnv_aadhar.Text = "Upload Aadhar";
            this.btnv_aadhar.UseVisualStyleBackColor = true;
            this.btnv_aadhar.Click += new System.EventHandler(this.Btnv_aadhar_Click);
            // 
            // btnv_upphoto
            // 
            this.btnv_upphoto.Location = new System.Drawing.Point(157, 393);
            this.btnv_upphoto.Name = "btnv_upphoto";
            this.btnv_upphoto.Size = new System.Drawing.Size(86, 23);
            this.btnv_upphoto.TabIndex = 25;
            this.btnv_upphoto.Text = "Upload Photo";
            this.btnv_upphoto.UseVisualStyleBackColor = true;
            this.btnv_upphoto.Click += new System.EventHandler(this.Btnv_upphoto_Click);
            // 
            // pbv_pancard
            // 
            this.pbv_pancard.Location = new System.Drawing.Point(558, 244);
            this.pbv_pancard.Name = "pbv_pancard";
            this.pbv_pancard.Size = new System.Drawing.Size(138, 143);
            this.pbv_pancard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbv_pancard.TabIndex = 24;
            this.pbv_pancard.TabStop = false;
            // 
            // pbv_aadhar
            // 
            this.pbv_aadhar.Location = new System.Drawing.Point(348, 244);
            this.pbv_aadhar.Name = "pbv_aadhar";
            this.pbv_aadhar.Size = new System.Drawing.Size(138, 143);
            this.pbv_aadhar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbv_aadhar.TabIndex = 23;
            this.pbv_aadhar.TabStop = false;
            // 
            // pbv_photo
            // 
            this.pbv_photo.Location = new System.Drawing.Point(132, 244);
            this.pbv_photo.Name = "pbv_photo";
            this.pbv_photo.Size = new System.Drawing.Size(138, 143);
            this.pbv_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbv_photo.TabIndex = 22;
            this.pbv_photo.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(514, 437);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(302, 437);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // tbv_pan
            // 
            this.tbv_pan.Enabled = false;
            this.tbv_pan.Location = new System.Drawing.Point(528, 177);
            this.tbv_pan.Name = "tbv_pan";
            this.tbv_pan.Size = new System.Drawing.Size(213, 20);
            this.tbv_pan.TabIndex = 19;
            this.tbv_pan.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(442, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Pan Card :";
            // 
            // tbv_aadhar
            // 
            this.tbv_aadhar.Enabled = false;
            this.tbv_aadhar.Location = new System.Drawing.Point(528, 137);
            this.tbv_aadhar.Name = "tbv_aadhar";
            this.tbv_aadhar.Size = new System.Drawing.Size(213, 20);
            this.tbv_aadhar.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(442, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Aadhar :";
            // 
            // dtpv_doj
            // 
            this.dtpv_doj.Enabled = false;
            this.dtpv_doj.Location = new System.Drawing.Point(529, 63);
            this.dtpv_doj.Name = "dtpv_doj";
            this.dtpv_doj.Size = new System.Drawing.Size(157, 20);
            this.dtpv_doj.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(442, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Date of joining :";
            // 
            // dtpv_dob
            // 
            this.dtpv_dob.Enabled = false;
            this.dtpv_dob.Location = new System.Drawing.Point(528, 26);
            this.dtpv_dob.Name = "dtpv_dob";
            this.dtpv_dob.Size = new System.Drawing.Size(157, 20);
            this.dtpv_dob.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Date of birth :";
            // 
            // tbv_mobile
            // 
            this.tbv_mobile.Enabled = false;
            this.tbv_mobile.Location = new System.Drawing.Point(528, 99);
            this.tbv_mobile.Name = "tbv_mobile";
            this.tbv_mobile.Size = new System.Drawing.Size(213, 20);
            this.tbv_mobile.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mobile :";
            // 
            // rtbv_address
            // 
            this.rtbv_address.Enabled = false;
            this.rtbv_address.Location = new System.Drawing.Point(119, 71);
            this.rtbv_address.Name = "rtbv_address";
            this.rtbv_address.Size = new System.Drawing.Size(213, 96);
            this.rtbv_address.TabIndex = 5;
            this.rtbv_address.Text = "";
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
            // tbv_name
            // 
            this.tbv_name.Enabled = false;
            this.tbv_name.Location = new System.Drawing.Point(119, 29);
            this.tbv_name.Name = "tbv_name";
            this.tbv_name.Size = new System.Drawing.Size(213, 20);
            this.tbv_name.TabIndex = 3;
            this.tbv_name.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(33, 29);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(41, 13);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Name :";
            this.lb_name.Click += new System.EventHandler(this.label8_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_saveEdit
            // 
            this.btn_saveEdit.Location = new System.Drawing.Point(195, 437);
            this.btn_saveEdit.Name = "btn_saveEdit";
            this.btn_saveEdit.Size = new System.Drawing.Size(75, 23);
            this.btn_saveEdit.TabIndex = 28;
            this.btn_saveEdit.Text = "SAVE";
            this.btn_saveEdit.UseVisualStyleBackColor = true;
            this.btn_saveEdit.Click += new System.EventHandler(this.Btn_saveEdit_Click);
            // 
            // btn_cancelEdit
            // 
            this.btn_cancelEdit.Location = new System.Drawing.Point(411, 437);
            this.btn_cancelEdit.Name = "btn_cancelEdit";
            this.btn_cancelEdit.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelEdit.TabIndex = 29;
            this.btn_cancelEdit.Text = "CANCEL";
            this.btn_cancelEdit.UseVisualStyleBackColor = true;
            this.btn_cancelEdit.Click += new System.EventHandler(this.Btn_cancelEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Photo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Aadhar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(604, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Pancard";
            // 
            // lbl_empId
            // 
            this.lbl_empId.AutoSize = true;
            this.lbl_empId.Location = new System.Drawing.Point(36, 183);
            this.lbl_empId.Name = "lbl_empId";
            this.lbl_empId.Size = new System.Drawing.Size(74, 13);
            this.lbl_empId.TabIndex = 33;
            this.lbl_empId.Text = " Employee Id :";
            // 
            // empIdTxt
            // 
            this.empIdTxt.AutoSize = true;
            this.empIdTxt.Location = new System.Drawing.Point(116, 184);
            this.empIdTxt.Name = "empIdTxt";
            this.empIdTxt.Size = new System.Drawing.Size(0, 13);
            this.empIdTxt.TabIndex = 34;
            this.empIdTxt.Click += new System.EventHandler(this.Label17_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 517);
            this.Controls.Add(this.EmployeeTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDetails";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.EmployeeTab.ResumeLayout(false);
            this.listOfEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_employees)).EndInit();
            this.AddEmployee.ResumeLayout(false);
            this.AddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pancard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aadhar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.ViewEmployee.ResumeLayout(false);
            this.ViewEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbv_pancard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbv_aadhar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbv_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EmployeeTab;
        private System.Windows.Forms.TabPage listOfEmployees;
        private System.Windows.Forms.DataGridView dg_employees;
        private System.Windows.Forms.TabPage AddEmployee;
        private System.Windows.Forms.TabPage ViewEmployee;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_aadhar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_doj;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_dob;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbv_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.RichTextBox rtbv_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbv_mobile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpv_doj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpv_dob;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbv_pan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbv_aadhar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_pancardimg;
        private System.Windows.Forms.Label lbl_aadharimg;
        private System.Windows.Forms.Label lbl_photo;
        private System.Windows.Forms.PictureBox pb_pancard;
        private System.Windows.Forms.PictureBox pb_aadhar;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.Button btn_uppancard;
        private System.Windows.Forms.Button btn_upaadhar;
        private System.Windows.Forms.Button btn_upphoto;
        private System.Windows.Forms.Button btnv_pan;
        private System.Windows.Forms.Button btnv_aadhar;
        private System.Windows.Forms.Button btnv_upphoto;
        private System.Windows.Forms.PictureBox pbv_pancard;
        private System.Windows.Forms.PictureBox pbv_aadhar;
        private System.Windows.Forms.PictureBox pbv_photo;
        private System.Windows.Forms.Button btn_saveEdit;
        private System.Windows.Forms.Button btn_cancelEdit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label empIdTxt;
        private System.Windows.Forms.Label lbl_empId;
    }
}