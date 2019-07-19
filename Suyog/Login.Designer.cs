namespace Suyog
{
    partial class LoginForm
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.lb_error = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.SeaShell;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.lb_error);
            this.LoginPanel.Controls.Add(this.btn_submit);
            this.LoginPanel.Controls.Add(this.lb_password);
            this.LoginPanel.Controls.Add(this.lb_userName);
            this.LoginPanel.Controls.Add(this.tb_password);
            this.LoginPanel.Controls.Add(this.tb_userName);
            this.LoginPanel.Location = new System.Drawing.Point(394, 191);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(343, 278);
            this.LoginPanel.TabIndex = 0;
            // 
            // lb_error
            // 
            this.lb_error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(65, 40);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(219, 16);
            this.lb_error.TabIndex = 5;
            this.lb_error.Text = "Invalid Username or Password";
            this.lb_error.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Location = new System.Drawing.Point(134, 197);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Login";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lb_password
            // 
            this.lb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(82, 149);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 13);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Password";
            // 
            // lb_userName
            // 
            this.lb_userName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_userName.AutoSize = true;
            this.lb_userName.Location = new System.Drawing.Point(82, 94);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(55, 13);
            this.lb_userName.TabIndex = 2;
            this.lb_userName.Text = "Username";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.LemonChiffon;
            this.tb_password.Location = new System.Drawing.Point(165, 146);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(130, 20);
            this.tb_password.TabIndex = 2;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_userName
            // 
            this.tb_userName.BackColor = System.Drawing.Color.LemonChiffon;
            this.tb_userName.Location = new System.Drawing.Point(165, 91);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(130, 20);
            this.tb_userName.TabIndex = 1;
            this.tb_userName.TextChanged += new System.EventHandler(this.Tb_userName_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 664);
            this.Controls.Add(this.LoginPanel);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lb_error;
    }
}

