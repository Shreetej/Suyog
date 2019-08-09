namespace Suyog
{
    partial class AdvanceScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_salaryDate = new System.Windows.Forms.Label();
            this.tb_amt = new System.Windows.Forms.TextBox();
            this.lb_amt = new System.Windows.Forms.Label();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.lb_month = new System.Windows.Forms.Label();
            this.cb_emp = new System.Windows.Forms.ComboBox();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.panel_payment = new System.Windows.Forms.Panel();
            this.dg_advance = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_advance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lb_salaryDate);
            this.panel1.Controls.Add(this.tb_amt);
            this.panel1.Controls.Add(this.lb_amt);
            this.panel1.Controls.Add(this.cb_month);
            this.panel1.Controls.Add(this.lb_month);
            this.panel1.Location = new System.Drawing.Point(21, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 71);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(469, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lb_salaryDate
            // 
            this.lb_salaryDate.AutoSize = true;
            this.lb_salaryDate.Location = new System.Drawing.Point(410, 13);
            this.lb_salaryDate.Name = "lb_salaryDate";
            this.lb_salaryDate.Size = new System.Drawing.Size(53, 26);
            this.lb_salaryDate.TabIndex = 9;
            this.lb_salaryDate.Text = "Date of\r\npayment :";
            // 
            // tb_amt
            // 
            this.tb_amt.Location = new System.Drawing.Point(266, 18);
            this.tb_amt.Name = "tb_amt";
            this.tb_amt.Size = new System.Drawing.Size(100, 20);
            this.tb_amt.TabIndex = 8;
            // 
            // lb_amt
            // 
            this.lb_amt.AutoSize = true;
            this.lb_amt.Location = new System.Drawing.Point(211, 21);
            this.lb_amt.Name = "lb_amt";
            this.lb_amt.Size = new System.Drawing.Size(49, 13);
            this.lb_amt.TabIndex = 7;
            this.lb_amt.Text = "Amount :";
            // 
            // cb_month
            // 
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "March",
            "April",
            "May",
            "June",
            "July",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.cb_month.Location = new System.Drawing.Point(92, 18);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(77, 21);
            this.cb_month.TabIndex = 6;
            // 
            // lb_month
            // 
            this.lb_month.AutoSize = true;
            this.lb_month.Location = new System.Drawing.Point(27, 13);
            this.lb_month.Name = "lb_month";
            this.lb_month.Size = new System.Drawing.Size(49, 26);
            this.lb_month.TabIndex = 5;
            this.lb_month.Text = "Month of\r\n Salary :";
            // 
            // cb_emp
            // 
            this.cb_emp.FormattingEnabled = true;
            this.cb_emp.Location = new System.Drawing.Point(370, 29);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(121, 21);
            this.cb_emp.TabIndex = 8;
            this.cb_emp.SelectedIndexChanged += new System.EventHandler(this.Cb_emp_SelectedIndexChanged);
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Location = new System.Drawing.Point(305, 32);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(59, 13);
            this.lbl_employee.TabIndex = 7;
            this.lbl_employee.Text = "Employee :";
            // 
            // panel_payment
            // 
            this.panel_payment.Controls.Add(this.dg_advance);
            this.panel_payment.Location = new System.Drawing.Point(21, 173);
            this.panel_payment.Name = "panel_payment";
            this.panel_payment.Size = new System.Drawing.Size(750, 270);
            this.panel_payment.TabIndex = 9;
            // 
            // dg_advance
            // 
            this.dg_advance.AllowUserToAddRows = false;
            this.dg_advance.AllowUserToDeleteRows = false;
            this.dg_advance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_advance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_advance.Location = new System.Drawing.Point(0, 0);
            this.dg_advance.Name = "dg_advance";
            this.dg_advance.ReadOnly = true;
            this.dg_advance.Size = new System.Drawing.Size(750, 270);
            this.dg_advance.TabIndex = 0;
            // 
            // AdvanceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_payment);
            this.Controls.Add(this.cb_emp);
            this.Controls.Add(this.lbl_employee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdvanceScreen";
            this.Text = "AdvanceScreen";
            this.Load += new System.EventHandler(this.AdvanceScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_payment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_advance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_salaryDate;
        private System.Windows.Forms.TextBox tb_amt;
        private System.Windows.Forms.Label lb_amt;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.Label lb_month;
        private System.Windows.Forms.ComboBox cb_emp;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.Panel panel_payment;
        private System.Windows.Forms.DataGridView dg_advance;
    }
}