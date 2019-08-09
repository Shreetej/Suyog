using Suyog.src.Dto;
using Suyog.src.Model;
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
    public partial class AdvanceScreen : Form
    {
        private EmployeeService employeeService;
        private SalaryAdvanceService salaryAdvanceService;
        public AdvanceScreen()
        {
            InitializeComponent();
        }

        private void Cb_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            advanceListLoad();
        }

        private void AdvanceScreen_Load(object sender, EventArgs e)
        {
            employeeService = new EmployeeService();
            cb_emp.DataSource = employeeService.DisplayEmployees();
            cb_emp.DisplayMember = "employeeName";
            cb_emp.Invalidate();
 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = (Employee)cb_emp.SelectedItem;
                salaryAdvanceService.addAdvance(Convert.ToInt32(employee.employeeId), employee.employeeName, cb_month.SelectedItem.ToString(), Convert.ToInt32(tb_amt.Text), dateTimePicker1.Value);
                advanceListLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void advanceListLoad()
        {
            salaryAdvanceService = new SalaryAdvanceService();
            List<AdvanceDto> advancelist = salaryAdvanceService.GetAdvance((Employee)cb_emp.SelectedValue);
            var list = new BindingList<AdvanceDto>(advancelist);
            dg_advance.DataSource = list;

        }
    }
}
