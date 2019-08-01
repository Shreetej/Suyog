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
    public partial class EmployeeDetails : Form
    {
        private EmployeeService employeeService;

        public EmployeeDetails()
        {
            InitializeComponent();
            btn_saveEdit.Hide();
            btn_cancelEdit.Hide();
        }

        private void dg_employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow viewRow = this.dg_employees.Rows[e.RowIndex];
                loadViewEmployee(viewRow);
                this.ViewEmployee.Select();
            }
        }

        private void loadViewEmployee(DataGridViewRow viewRow)
        {
            empIdTxt.Text = viewRow.Cells["employeeId"].Value.ToString(); 
            tbv_name.Text = viewRow.Cells["employeeName"].Value.ToString();
            rtbv_address.Text = viewRow.Cells["employeeAddress"].Value.ToString();
            tbv_aadhar.Text = viewRow.Cells["aadhar"].Value.ToString();
            tbv_pan.Text = viewRow.Cells["pancard"].Value.ToString();
            tbv_mobile.Text = viewRow.Cells["mobile"].Value.ToString();
            
            pbv_photo.Image = EmployeeService.byteArrayToImage((byte[])viewRow.Cells["photo"].Value);
            pbv_aadhar.Image = EmployeeService.byteArrayToImage((byte[])viewRow.Cells["aadharimg"].Value);
            pbv_pancard.Image = EmployeeService.byteArrayToImage((byte[])viewRow.Cells["pancardimg"].Value);
            dtpv_dob.Value = (DateTime)viewRow.Cells["dob"].Value;
            dtpv_doj.Value = (DateTime)viewRow.Cells["doj"].Value;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (EmployeeTab.SelectedIndex == 1)
            {
                employeeService = new EmployeeService();
                var list = employeeService.DisplayEmployees();
                var bindingList = new BindingList<Employee>(list);
                var source = new BindingSource(bindingList, null);
                dg_employees.DataSource = source;
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtb_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_address_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lb_dob_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_upphoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openphoto = new OpenFileDialog() { /*Filter ="JPEG|jpg",*/ ValidateNames = true, Multiselect = true })
            {
                if (openphoto.ShowDialog() == DialogResult.OK )
                {
                    pb_photo.Image = Image.FromFile(openphoto.FileName);
                }
            }
                
        }

        private void btn_upaadhar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openaadhar = new OpenFileDialog() { ValidateNames = true, Multiselect = true })
            {
                if (openaadhar.ShowDialog() == DialogResult.OK)
                {
                    pb_aadhar.Image = Image.FromFile(openaadhar.FileName);
                }
            }
        }

        private void btn_uppancard_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openpan = new OpenFileDialog() {  ValidateNames = true, Multiselect = false })
            {
                if (openpan.ShowDialog() == DialogResult.OK)
                {
                    pb_pancard.Image = Image.FromFile(openpan.FileName);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                employeeService = new EmployeeService();
                Employee employee = employeeService.addEmployee(tb_name.Text,rtb_address.Text,dtp_dob.Value,dtp_doj.Value,tb_mobile.Text,tb_aadhar.Text,tb_pan.Text,pb_photo.Image,pb_aadhar.Image,pb_pancard.Image);
                EmployeeListLoad();
                MessageBox.Show("Employee details added.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pb_photo_Click(object sender, EventArgs e)
        {

        }

        private void pb_aadhar_Click(object sender, EventArgs e)
        {

        }

        private void pb_pancard_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pancardimg_Click(object sender, EventArgs e)
        {

        }

        private void lbl_aadharimg_Click(object sender, EventArgs e)
        {

        }

        private void lbl_photo_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            EmployeeTab.SelectedIndexChanged += EmployeeTab_SelectedIndexChanged;
            EmployeeListLoad();
        }

        private void EmployeeListLoad()
        {
            var list = GetEmployees();
            var bindingList = new BindingList<Employee>(list);
            var source = new BindingSource(bindingList, null);
            dg_employees.DataSource = source;
        }
        
        private List<Employee> GetEmployees()
        {
            employeeService = new EmployeeService();
            return employeeService.DisplayEmployees();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            tbv_name.Enabled = true;
            tbv_pan.Enabled = true;
            tbv_mobile.Enabled = true;
            tbv_aadhar.Enabled = true;
            dtpv_dob.Enabled = true;
            dtpv_doj.Enabled = true;
            rtbv_address.Enabled = true;
            btnv_aadhar.Enabled = true;
            btnv_pan.Enabled = true;
            btnv_upphoto.Enabled = true;
            btn_saveEdit.Show();
            btn_cancelEdit.Show();
            btn_edit.Hide();
            btn_delete.Hide();
        }

        private void Btn_cancelEdit_Click(object sender, EventArgs e)
        {
            btn_saveEdit.Hide();
            btn_cancelEdit.Hide();
            btn_edit.Show();
            btn_delete.Show();
        }

        private void Btnv_upphoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openphoto = new OpenFileDialog() { /*Filter ="JPEG|jpg",*/ ValidateNames = true, Multiselect = true })
            {
                if (openphoto.ShowDialog() == DialogResult.OK)
                {
                    pbv_photo.Image = Image.FromFile(openphoto.FileName);
                }
            }
        }

        private void Btnv_aadhar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openphoto = new OpenFileDialog() { /*Filter ="JPEG|jpg",*/ ValidateNames = true, Multiselect = true })
            {
                if (openphoto.ShowDialog() == DialogResult.OK)
                {
                    pbv_aadhar.Image = Image.FromFile(openphoto.FileName);
                }
            }
        }

        private void Btnv_pan_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openphoto = new OpenFileDialog() { /*Filter ="JPEG|jpg",*/ ValidateNames = true, Multiselect = true })
            {
                if (openphoto.ShowDialog() == DialogResult.OK)
                {
                    pbv_pancard.Image = Image.FromFile(openphoto.FileName);
                }
            }
        }

        private void Btn_saveEdit_Click(object sender, EventArgs e)
        {
            employeeService = new EmployeeService();
            Employee updatedEmployee = new Employee();
            updatedEmployee.employeeId = Convert.ToInt32(empIdTxt.Text);
            updatedEmployee.employeeName = tbv_name.Text;
            updatedEmployee.employeeAddress = rtbv_address.Text;
            updatedEmployee.dob = dtpv_dob.Value;
            updatedEmployee.doj = dtpv_doj.Value;
            updatedEmployee.mobile = tbv_mobile.Text;
            updatedEmployee.aadhar = tbv_aadhar.Text;
            updatedEmployee.pancard = tbv_pan.Text;
            employeeService.updateEmployee(updatedEmployee, pbv_photo.Image, pbv_aadhar.Image, pbv_pancard.Image);
            MessageBox.Show("Employee details updated");
            EmployeeListLoad();
        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            employeeService = new EmployeeService();
            employeeService.deleteEmployee(Convert.ToInt32(empIdTxt.Text));
            EmployeeListLoad();
            clearViewEmployeeControls();
            
        }

        private void clearViewEmployeeControls()
        {
            empIdTxt.Text = "";
            tbv_name.Text = "";
            rtbv_address.Text = "";
            tbv_aadhar.Text = "";
            tbv_pan.Text = "";
            tbv_mobile.Text = "";
            pbv_photo.Image = null;
            pbv_aadhar.Image = null;
            pbv_pancard.Image = null;
            dtpv_dob.Value = dtpv_dob.MinDate;
            dtpv_doj.Value = dtpv_doj.MinDate;
        }


    }
}
