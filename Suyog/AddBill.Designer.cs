namespace Suyog
{
    partial class AddBill
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
            this.lb_billno = new System.Windows.Forms.Label();
            this.tb_billNo = new System.Windows.Forms.TextBox();
            this.lb_truckno = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.tb_invoiceNo = new System.Windows.Forms.TextBox();
            this.lb_date = new System.Windows.Forms.Label();
            this.billDate = new System.Windows.Forms.DateTimePicker();
            this.lb_sender = new System.Windows.Forms.Label();
            this.cb_truckno = new System.Windows.Forms.ComboBox();
            this.cb_sender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_reciever = new System.Windows.Forms.ComboBox();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.lb_from = new System.Windows.Forms.Label();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.lb_to = new System.Windows.Forms.Label();
            this.cb_materialType = new System.Windows.Forms.ComboBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_units = new System.Windows.Forms.TextBox();
            this.lb_units = new System.Windows.Forms.Label();
            this.dg_materials = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_qty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_materials)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_billno
            // 
            this.lb_billno.AutoSize = true;
            this.lb_billno.Location = new System.Drawing.Point(77, 64);
            this.lb_billno.Name = "lb_billno";
            this.lb_billno.Size = new System.Drawing.Size(41, 13);
            this.lb_billno.TabIndex = 0;
            this.lb_billno.Text = "Bill no :";
            // 
            // tb_billNo
            // 
            this.tb_billNo.Location = new System.Drawing.Point(124, 61);
            this.tb_billNo.Name = "tb_billNo";
            this.tb_billNo.Size = new System.Drawing.Size(100, 20);
            this.tb_billNo.TabIndex = 1;
            // 
            // lb_truckno
            // 
            this.lb_truckno.AutoSize = true;
            this.lb_truckno.Location = new System.Drawing.Point(333, 64);
            this.lb_truckno.Name = "lb_truckno";
            this.lb_truckno.Size = new System.Drawing.Size(56, 13);
            this.lb_truckno.TabIndex = 2;
            this.lb_truckno.Text = "Truck no :";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Location = new System.Drawing.Point(605, 68);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(63, 13);
            this.o.TabIndex = 4;
            this.o.Text = "Invoice no :";
            this.o.Click += new System.EventHandler(this.Label2_Click);
            // 
            // tb_invoiceNo
            // 
            this.tb_invoiceNo.Location = new System.Drawing.Point(674, 65);
            this.tb_invoiceNo.Name = "tb_invoiceNo";
            this.tb_invoiceNo.Size = new System.Drawing.Size(100, 20);
            this.tb_invoiceNo.TabIndex = 5;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(869, 68);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(36, 13);
            this.lb_date.TabIndex = 6;
            this.lb_date.Text = "Date :";
            // 
            // billDate
            // 
            this.billDate.Location = new System.Drawing.Point(911, 65);
            this.billDate.Name = "billDate";
            this.billDate.Size = new System.Drawing.Size(199, 20);
            this.billDate.TabIndex = 7;
            // 
            // lb_sender
            // 
            this.lb_sender.AutoSize = true;
            this.lb_sender.Location = new System.Drawing.Point(77, 150);
            this.lb_sender.Name = "lb_sender";
            this.lb_sender.Size = new System.Drawing.Size(47, 13);
            this.lb_sender.TabIndex = 8;
            this.lb_sender.Text = "Sender :";
            // 
            // cb_truckno
            // 
            this.cb_truckno.FormattingEnabled = true;
            this.cb_truckno.Location = new System.Drawing.Point(395, 60);
            this.cb_truckno.Name = "cb_truckno";
            this.cb_truckno.Size = new System.Drawing.Size(149, 21);
            this.cb_truckno.TabIndex = 9;
            // 
            // cb_sender
            // 
            this.cb_sender.FormattingEnabled = true;
            this.cb_sender.Location = new System.Drawing.Point(139, 147);
            this.cb_sender.Name = "cb_sender";
            this.cb_sender.Size = new System.Drawing.Size(432, 21);
            this.cb_sender.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reciever :";
            // 
            // cb_reciever
            // 
            this.cb_reciever.FormattingEnabled = true;
            this.cb_reciever.Location = new System.Drawing.Point(139, 206);
            this.cb_reciever.Name = "cb_reciever";
            this.cb_reciever.Size = new System.Drawing.Size(432, 21);
            this.cb_reciever.TabIndex = 12;
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(922, 150);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(100, 20);
            this.tb_from.TabIndex = 14;
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Location = new System.Drawing.Point(840, 153);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(76, 13);
            this.lb_from.TabIndex = 13;
            this.lb_from.Text = "From location :";
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(922, 206);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(100, 20);
            this.tb_to.TabIndex = 16;
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Location = new System.Drawing.Point(840, 209);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(66, 13);
            this.lb_to.TabIndex = 15;
            this.lb_to.Text = "To location :";
            // 
            // cb_materialType
            // 
            this.cb_materialType.FormattingEnabled = true;
            this.cb_materialType.Location = new System.Drawing.Point(160, 294);
            this.cb_materialType.Name = "cb_materialType";
            this.cb_materialType.Size = new System.Drawing.Size(190, 21);
            this.cb_materialType.TabIndex = 18;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(77, 298);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(77, 13);
            this.lb_type.TabIndex = 17;
            this.lb_type.Text = "Material Type :";
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(544, 294);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(100, 20);
            this.tb_qty.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1076, 205);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // tb_units
            // 
            this.tb_units.Location = new System.Drawing.Point(833, 295);
            this.tb_units.Name = "tb_units";
            this.tb_units.Size = new System.Drawing.Size(100, 20);
            this.tb_units.TabIndex = 23;
            this.tb_units.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lb_units
            // 
            this.lb_units.AutoSize = true;
            this.lb_units.Location = new System.Drawing.Point(790, 298);
            this.lb_units.Name = "lb_units";
            this.lb_units.Size = new System.Drawing.Size(37, 13);
            this.lb_units.TabIndex = 22;
            this.lb_units.Text = "Units :";
            // 
            // dg_materials
            // 
            this.dg_materials.AllowUserToAddRows = false;
            this.dg_materials.AllowUserToResizeColumns = false;
            this.dg_materials.AllowUserToResizeRows = false;
            this.dg_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_materials.Location = new System.Drawing.Point(48, 375);
            this.dg_materials.Name = "dg_materials";
            this.dg_materials.Size = new System.Drawing.Size(1076, 183);
            this.dg_materials.TabIndex = 24;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1025, 293);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(544, 603);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(48, 271);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1076, 67);
            this.flowLayoutPanel2.TabIndex = 27;
            // 
            // lb_qty
            // 
            this.lb_qty.AutoSize = true;
            this.lb_qty.Location = new System.Drawing.Point(486, 297);
            this.lb_qty.Name = "lb_qty";
            this.lb_qty.Size = new System.Drawing.Size(52, 13);
            this.lb_qty.TabIndex = 19;
            this.lb_qty.Text = "Quantity :";
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 667);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dg_materials);
            this.Controls.Add(this.tb_units);
            this.Controls.Add(this.lb_units);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.lb_qty);
            this.Controls.Add(this.cb_materialType);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.lb_to);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.lb_from);
            this.Controls.Add(this.cb_reciever);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_sender);
            this.Controls.Add(this.cb_truckno);
            this.Controls.Add(this.lb_sender);
            this.Controls.Add(this.billDate);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.tb_invoiceNo);
            this.Controls.Add(this.o);
            this.Controls.Add(this.lb_truckno);
            this.Controls.Add(this.tb_billNo);
            this.Controls.Add(this.lb_billno);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "AddBill";
            this.Text = "AddBill";
            ((System.ComponentModel.ISupportInitialize)(this.dg_materials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_billno;
        private System.Windows.Forms.TextBox tb_billNo;
        private System.Windows.Forms.Label lb_truckno;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.TextBox tb_invoiceNo;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.DateTimePicker billDate;
        private System.Windows.Forms.Label lb_sender;
        private System.Windows.Forms.ComboBox cb_truckno;
        private System.Windows.Forms.ComboBox cb_sender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_reciever;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.ComboBox cb_materialType;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tb_units;
        private System.Windows.Forms.Label lb_units;
        private System.Windows.Forms.DataGridView dg_materials;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lb_qty;
    }
}