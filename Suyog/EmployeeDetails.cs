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
        }

        private void dg_employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeTab_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            using (OpenFileDialog openphoto = new OpenFileDialog() { Filter ="JPEG|jpg", ValidateNames = true, Multiselect = true })
            {
                if (openphoto.ShowDialog() == DialogResult.OK )
                {
                    pb_photo.Image = Image.FromFile(openphoto.FileName);
                }
            }
                
        }

        private void btn_upaadhar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openaadhar = new OpenFileDialog() { Filter = "JPEG|jpg", ValidateNames = true, Multiselect = true })
            {
                if (openaadhar.ShowDialog() == DialogResult.OK)
                {
                    pb_aadhar.Image = Image.FromFile(openaadhar.FileName);
                }
            }
        }

        private void btn_uppancard_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openpan = new OpenFileDialog() { Filter = "JPEG|jpg", ValidateNames = true, Multiselect = true })
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
    }
}
