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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(761, 117);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(216, 263);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(149, 89);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(717, 263);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(149, 89);
            this.btn_scan.TabIndex = 3;
            this.btn_scan.Text = "SCAN BILL";
            this.btn_scan.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 423);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 89);
            this.button4.TabIndex = 4;
            this.button4.Text = "ADVANCES";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(717, 423);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 89);
            this.button5.TabIndex = 4;
            this.button5.Text = "SALARY";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cb_search
            // 
            this.cb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "BillNo",
            "TruckNo",
            "InvoiceNo",
            "BillDate",
            "SenderName",
            "ReceiverName",
            "FromLocation",
            "ToLocation"});
            this.cb_search.Location = new System.Drawing.Point(322, 119);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(165, 21);
            this.cb_search.TabIndex = 5;
            this.cb_search.SelectedIndexChanged += new System.EventHandler(this.cb_search_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search By :";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(526, 119);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(212, 20);
            this.tb_search.TabIndex = 7;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(526, 119);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(154, 20);
            this.dtp_date.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 668);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DateTimePicker dtp_date;
    }
}