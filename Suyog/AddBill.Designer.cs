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
            this.tb_units = new System.Windows.Forms.TextBox();
            this.lb_units = new System.Windows.Forms.Label();
            this.dg_materials = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_qty = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_materials)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_billno
            // 
            this.lb_billno.AutoSize = true;
            this.lb_billno.Location = new System.Drawing.Point(75, 37);
            this.lb_billno.Name = "lb_billno";
            this.lb_billno.Size = new System.Drawing.Size(41, 13);
            this.lb_billno.TabIndex = 0;
            this.lb_billno.Text = "Bill no :";
            this.lb_billno.Click += new System.EventHandler(this.lb_billno_Click);
            // 
            // tb_billNo
            // 
            this.tb_billNo.Location = new System.Drawing.Point(122, 34);
            this.tb_billNo.Name = "tb_billNo";
            this.tb_billNo.Size = new System.Drawing.Size(100, 20);
            this.tb_billNo.TabIndex = 1;
            this.tb_billNo.TextChanged += new System.EventHandler(this.tb_billNo_TextChanged);
            // 
            // lb_truckno
            // 
            this.lb_truckno.AutoSize = true;
            this.lb_truckno.Location = new System.Drawing.Point(324, 37);
            this.lb_truckno.Name = "lb_truckno";
            this.lb_truckno.Size = new System.Drawing.Size(56, 13);
            this.lb_truckno.TabIndex = 2;
            this.lb_truckno.Text = "Truck no :";
            this.lb_truckno.Click += new System.EventHandler(this.lb_truckno_Click);
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Location = new System.Drawing.Point(579, 38);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(63, 13);
            this.o.TabIndex = 4;
            this.o.Text = "Invoice no :";
            this.o.Click += new System.EventHandler(this.Label2_Click);
            // 
            // tb_invoiceNo
            // 
            this.tb_invoiceNo.Location = new System.Drawing.Point(648, 35);
            this.tb_invoiceNo.Name = "tb_invoiceNo";
            this.tb_invoiceNo.Size = new System.Drawing.Size(100, 20);
            this.tb_invoiceNo.TabIndex = 2;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(596, 176);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(36, 13);
            this.lb_date.TabIndex = 6;
            this.lb_date.Text = "Date :";
            // 
            // billDate
            // 
            this.billDate.Location = new System.Drawing.Point(638, 172);
            this.billDate.Name = "billDate";
            this.billDate.Size = new System.Drawing.Size(110, 20);
            this.billDate.TabIndex = 7;
            // 
            // lb_sender
            // 
            this.lb_sender.AutoSize = true;
            this.lb_sender.Location = new System.Drawing.Point(75, 89);
            this.lb_sender.Name = "lb_sender";
            this.lb_sender.Size = new System.Drawing.Size(47, 13);
            this.lb_sender.TabIndex = 8;
            this.lb_sender.Text = "Sender :";
            this.lb_sender.Click += new System.EventHandler(this.lb_sender_Click);
            // 
            // cb_truckno
            // 
            this.cb_truckno.FormattingEnabled = true;
            this.cb_truckno.Location = new System.Drawing.Point(386, 33);
            this.cb_truckno.Name = "cb_truckno";
            this.cb_truckno.Size = new System.Drawing.Size(149, 21);
            this.cb_truckno.TabIndex = 1;
            this.cb_truckno.SelectedIndexChanged += new System.EventHandler(this.cb_truckno_SelectedIndexChanged);
            // 
            // cb_sender
            // 
            this.cb_sender.FormattingEnabled = true;
            this.cb_sender.Location = new System.Drawing.Point(137, 86);
            this.cb_sender.Name = "cb_sender";
            this.cb_sender.Size = new System.Drawing.Size(262, 21);
            this.cb_sender.TabIndex = 3;
            this.cb_sender.SelectedIndexChanged += new System.EventHandler(this.cb_sender_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reciever :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_reciever
            // 
            this.cb_reciever.FormattingEnabled = true;
            this.cb_reciever.Location = new System.Drawing.Point(137, 130);
            this.cb_reciever.Name = "cb_reciever";
            this.cb_reciever.Size = new System.Drawing.Size(262, 21);
            this.cb_reciever.TabIndex = 5;
            this.cb_reciever.SelectedIndexChanged += new System.EventHandler(this.cb_reciever_SelectedIndexChanged);
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(648, 84);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(100, 20);
            this.tb_from.TabIndex = 4;
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Location = new System.Drawing.Point(569, 87);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(76, 13);
            this.lb_from.TabIndex = 13;
            this.lb_from.Text = "From location :";
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(648, 129);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(100, 20);
            this.tb_to.TabIndex = 6;
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Location = new System.Drawing.Point(579, 132);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(66, 13);
            this.lb_to.TabIndex = 15;
            this.lb_to.Text = "To location :";
            // 
            // cb_materialType
            // 
            this.cb_materialType.FormattingEnabled = true;
            this.cb_materialType.Location = new System.Drawing.Point(158, 209);
            this.cb_materialType.Name = "cb_materialType";
            this.cb_materialType.Size = new System.Drawing.Size(151, 21);
            this.cb_materialType.TabIndex = 8;
            this.cb_materialType.SelectedIndexChanged += new System.EventHandler(this.cb_materialType_SelectedIndexChanged);
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(75, 212);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(77, 13);
            this.lb_type.TabIndex = 17;
            this.lb_type.Text = "Material Type :";
            this.lb_type.Click += new System.EventHandler(this.lb_type_Click);
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(418, 209);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(100, 20);
            this.tb_qty.TabIndex = 9;
            // 
            // tb_units
            // 
            this.tb_units.Location = new System.Drawing.Point(648, 208);
            this.tb_units.Name = "tb_units";
            this.tb_units.Size = new System.Drawing.Size(100, 20);
            this.tb_units.TabIndex = 10;
            this.tb_units.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lb_units
            // 
            this.lb_units.AutoSize = true;
            this.lb_units.Location = new System.Drawing.Point(596, 212);
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
            this.dg_materials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_materials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_materials.Location = new System.Drawing.Point(31, 277);
            this.dg_materials.Name = "dg_materials";
            this.dg_materials.Size = new System.Drawing.Size(779, 183);
            this.dg_materials.TabIndex = 24;
            this.dg_materials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_materials_CellContentClick);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(310, 482);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_qty
            // 
            this.lb_qty.AutoSize = true;
            this.lb_qty.Location = new System.Drawing.Point(360, 212);
            this.lb_qty.Name = "lb_qty";
            this.lb_qty.Size = new System.Drawing.Size(52, 13);
            this.lb_qty.TabIndex = 19;
            this.lb_qty.Text = "Quantity :";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(443, 482);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.lb_billno);
            this.panel1.Controls.Add(this.lb_from);
            this.panel1.Controls.Add(this.tb_billNo);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.tb_qty);
            this.panel1.Controls.Add(this.lb_qty);
            this.panel1.Controls.Add(this.tb_from);
            this.panel1.Controls.Add(this.cb_materialType);
            this.panel1.Controls.Add(this.dg_materials);
            this.panel1.Controls.Add(this.lb_type);
            this.panel1.Controls.Add(this.lb_to);
            this.panel1.Controls.Add(this.cb_reciever);
            this.panel1.Controls.Add(this.lb_units);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_units);
            this.panel1.Controls.Add(this.cb_sender);
            this.panel1.Controls.Add(this.tb_to);
            this.panel1.Controls.Add(this.cb_truckno);
            this.panel1.Controls.Add(this.billDate);
            this.panel1.Controls.Add(this.lb_sender);
            this.panel1.Controls.Add(this.lb_date);
            this.panel1.Controls.Add(this.lb_truckno);
            this.panel1.Controls.Add(this.o);
            this.panel1.Controls.Add(this.tb_invoiceNo);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 539);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(386, 248);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 543);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBill";
            this.Text = "AddBill";
            this.Load += new System.EventHandler(this.AddBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_materials)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox tb_units;
        private System.Windows.Forms.Label lb_units;
        private System.Windows.Forms.DataGridView dg_materials;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_qty;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
    }
}