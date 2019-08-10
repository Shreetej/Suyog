using Suyog.src.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScannerDemo;

namespace Suyog
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            panel_tab.Controls.Clear();
            AddBill addBill = new AddBill();
            addBill.TopLevel = false;
            panel_tab.Controls.Add(addBill);
            addBill.Dock = DockStyle.Fill;
            addBill.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
                    }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            panel_tab.Controls.Clear();
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.TopLevel = false;
            panel_tab.Controls.Add(employeeDetails);
            employeeDetails.Dock = DockStyle.Fill;
            employeeDetails.Show();

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_tab.Controls.Clear();
            searchForm searchForm = new searchForm();
            searchForm.TopLevel = false;
            panel_tab.Controls.Add(searchForm);
            searchForm.Dock = DockStyle.Fill;
            searchForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            panel_tab.Controls.Clear();
            SalaryScreen salaryScreen = new SalaryScreen();
            salaryScreen.TopLevel = false;
            panel_tab.Controls.Add(salaryScreen);
            salaryScreen.Dock = DockStyle.Fill;
            salaryScreen.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panel_tab.Controls.Clear();
            AdvanceScreen advanceScreen = new AdvanceScreen();
            advanceScreen.TopLevel = false;
            panel_tab.Controls.Add(advanceScreen);
            advanceScreen.Dock = DockStyle.Fill;
            advanceScreen.Show();
        }

        private void Btn_scan_Click(object sender, EventArgs e)
        {
            panel_tab.Controls.Clear();
            Form1 scanScreen = new Form1();
            scanScreen.TopLevel = false;
            panel_tab.Controls.Add(scanScreen);
            scanScreen.Dock = DockStyle.Fill;
            scanScreen.Show();
        }
    }
}
