using Suyog.src;
using Suyog.src.Dto;
using Suyog.src.Model;
using Suyog.src.Repository;
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

namespace Suyog
{
    public partial class SalaryScreen : Form
    {
        private SalaryAdvanceService salaryAdvanceService;
        private EmployeeService employeeService;
        public SalaryScreen()
        {
            InitializeComponent();
            salaryAdvanceService = new SalaryAdvanceService();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lb_amt_Click(object sender, EventArgs e)
        {

        }

        private void SalaryScreen_Load(object sender, EventArgs e)
        {
            employeeService = new EmployeeService();
            cb_emp.DataSource = employeeService.DisplayEmployees();
            cb_emp.DisplayMember = "employeeName";
            cb_emp.Invalidate();

            //cb_emp.DataSource = new BindingList<EmployeeDto>(employeeService.displayEmployeeNames());
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = (Employee)cb_emp.SelectedItem;
                salaryAdvanceService.addSalary(Convert.ToInt32(employee.employeeId), employee.employeeName, cb_month.SelectedItem.ToString(), Convert.ToInt32(tb_amt.Text), dateTimePicker1.Value);
                updateList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateList()
        {
            List<SalaryDto> salarylist = salaryAdvanceService.GetSalary((Employee)cb_emp.SelectedValue);
            var list = new BindingList<SalaryDto>(salarylist);
            dg_salary.DataSource = list;
        }

    }
}
