namespace Suyog
{
    partial class searchForm
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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_search = new System.Windows.Forms.Label();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel_billList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(422, 36);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(154, 20);
            this.dtp_date.TabIndex = 13;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(422, 36);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(212, 20);
            this.tb_search.TabIndex = 12;
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Location = new System.Drawing.Point(146, 39);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(62, 13);
            this.lb_search.TabIndex = 11;
            this.lb_search.Text = "Search By :";
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
            this.cb_search.Location = new System.Drawing.Point(218, 36);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(165, 21);
            this.cb_search.TabIndex = 10;
            this.cb_search.SelectedIndexChanged += new System.EventHandler(this.cb_search_SelectedIndexChanged_1);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(657, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel_billList
            // 
            this.panel_billList.Location = new System.Drawing.Point(28, 89);
            this.panel_billList.Name = "panel_billList";
            this.panel_billList.Size = new System.Drawing.Size(876, 420);
            this.panel_billList.TabIndex = 14;
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 540);
            this.Controls.Add(this.panel_billList);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchForm";
            this.Text = "searchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel_billList;
    }
}