namespace Suyog
{
    partial class Home
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.lb_appName = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.panel_tab = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_tab_search = new System.Windows.Forms.Button();
            this.homePanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(3, 109);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(197, 103);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(3, 218);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(197, 104);
            this.btn_scan.TabIndex = 3;
            this.btn_scan.Text = "SCAN BILL";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.Btn_scan_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 99);
            this.button4.TabIndex = 4;
            this.button4.Text = "ADVANCES";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 545);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 102);
            this.button5.TabIndex = 4;
            this.button5.Text = "SALARY";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(3, 328);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(197, 106);
            this.btn_employee.TabIndex = 9;
            this.btn_employee.Text = "EMPLOYEE";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // lb_appName
            // 
            this.lb_appName.AutoSize = true;
            this.lb_appName.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lb_appName.Location = new System.Drawing.Point(317, 31);
            this.lb_appName.Name = "lb_appName";
            this.lb_appName.Size = new System.Drawing.Size(283, 39);
            this.lb_appName.TabIndex = 10;
            this.lb_appName.Text = "SUYOG TRANSPORT";
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.panel_tab);
            this.homePanel.Controls.Add(this.lb_appName);
            this.homePanel.Location = new System.Drawing.Point(206, 2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(945, 661);
            this.homePanel.TabIndex = 11;
            this.homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePanel_Paint);
            // 
            // panel_tab
            // 
            this.panel_tab.Location = new System.Drawing.Point(21, 97);
            this.panel_tab.Name = "panel_tab";
            this.panel_tab.Size = new System.Drawing.Size(903, 546);
            this.panel_tab.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_tab_search);
            this.flowLayoutPanel2.Controls.Add(this.btn_add);
            this.flowLayoutPanel2.Controls.Add(this.btn_scan);
            this.flowLayoutPanel2.Controls.Add(this.btn_employee);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, -1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 668);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // btn_tab_search
            // 
            this.btn_tab_search.Location = new System.Drawing.Point(3, 3);
            this.btn_tab_search.Name = "btn_tab_search";
            this.btn_tab_search.Size = new System.Drawing.Size(197, 100);
            this.btn_tab_search.TabIndex = 3;
            this.btn_tab_search.Text = "SEARCH";
            this.btn_tab_search.UseVisualStyleBackColor = true;
            this.btn_tab_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 668);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.homePanel);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Label lb_appName;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_tab_search;
        private System.Windows.Forms.Panel panel_tab;
    }
}