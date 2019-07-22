namespace Suyog
{
    partial class BillsList
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
            this.dg_billList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_billList)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_billList
            // 
            this.dg_billList.AllowUserToAddRows = false;
            this.dg_billList.AllowUserToDeleteRows = false;
            this.dg_billList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_billList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_billList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_billList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_billList.Location = new System.Drawing.Point(0, 0);
            this.dg_billList.Name = "dg_billList";
            this.dg_billList.ReadOnly = true;
            this.dg_billList.Size = new System.Drawing.Size(868, 450);
            this.dg_billList.TabIndex = 0;
            // 
            // BillsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.dg_billList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillsList";
            this.Load += new System.EventHandler(this.BillsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_billList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_billList;
    }
}